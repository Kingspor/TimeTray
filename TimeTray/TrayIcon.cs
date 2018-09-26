using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TimeTray
{
    public class TrayIcon : Form
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private Timer clockWatch = new Timer();

        private String workingDirectory;
        private DateTime beginnTime;
        private DateTime feierabendTime;
        private String logPath;
        public String log
        {
            get
            { return logPath; }
            set
            { logPath = value; }
        }

        private String[] allLines;
        public String[] logContent
        {
            get { return allLines; }
            set { allLines = value; }
        }
        [STAThread]
        static void Main()
        {
            Application.Run(new TrayIcon());

        }

        public TrayIcon()
        {
            clockWatch.Tick += new EventHandler(TimerEventProcessor);
            //50000 ms = 50 Sek
            clockWatch.Interval = 50000;
            //clockWatch.Interval = 5000;
            clockWatch.Start();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            workingDirectory = Directory.GetCurrentDirectory();
            log = Path.Combine(workingDirectory, "time.log");
            logContent = File.ReadAllLines(log);
            String[] lastEntry = readLastFromLog();
            //Jetzige Zeit
            //Console.WriteLine(nowTime.ToString());
            //Console.WriteLine(workingDirectory.ToString());

            beginnTime = DateTime.Now;
            //feierabendTime = beginnTime.AddHours(Properties.Settings.Default.tagesArbeitszeit.Hour);
            //feierabendTime = beginnTime.AddMinutes(Properties.Settings.Default.tagesArbeitszeit.Minute);
            feierabendTime = beginnTime.AddHours(Properties.Settings.Default.laengeArbeitszeit);
            feierabendTime = feierabendTime.AddMinutes(Properties.Settings.Default.laengeBreakfast+ Properties.Settings.Default.laengeLunch);
            
            //Properties.Settings.Default.feierabend
            //Properties.Settings.Default.feierabend = feierabendTime;
            String beginnTimeString;
            String feierabendTimeString;
            String todayString;

            String[] arrToday = { beginnTime.ToString("dd.MM.yyyy"), beginnTime.ToString("HH:mm"), feierabendTime.ToString("HH:mm") };

            if (lastEntry[0] == arrToday[0])
            {
                todayString = lastEntry[0];
                beginnTimeString = lastEntry[1];
                feierabendTimeString = lastEntry[2];

                Properties.Settings.Default.feierabend = DateTime.ParseExact(feierabendTimeString, "HH:mm", null);
            } else
            {
                todayString = arrToday[0];
                beginnTimeString = arrToday[1];
                feierabendTimeString = arrToday[2];
                LogWrite(beginnTime, feierabendTime);
                Properties.Settings.Default.feierabend = feierabendTime;
            }
            Console.WriteLine(Properties.Settings.Default.feierabend.ToString("HH:mm"));

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Read", read);
            trayMenu.MenuItems.Add("Datum: " + todayString);
            trayMenu.MenuItems.Add("Beginn: " + beginnTimeString);
            trayMenu.MenuItems.Add("Ende: " + feierabendTimeString);
            trayMenu.MenuItems.Add("Einstellungen", OpenGui);
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "GEORG Erinnerung";
            trayIcon.Icon = TimeTray.Properties.Resources.TrayIcon_icon;

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;


        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
            Properties.Settings.Default.Save();
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            //Cleanup so that the icon will be removed when the application is closed
            //trayIcon.Visible = false;
            trayIcon.Dispose();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            DateTime timeTmp = DateTime.Now;
            Console.Write(timeTmp.ToString());
            //Frühstückstimer. Erinnerung 5 min vorher
            if(Properties.Settings.Default.notifyCheck == CheckState.Checked)
            {
                DateTime breakfastTimeNotify = Properties.Settings.Default.breakfast.AddMinutes(-Properties.Settings.Default.notifyMinutes);
                if (timeTmp.Hour == breakfastTimeNotify.Hour && timeTmp.Minute == breakfastTimeNotify.Minute)
                {
                    trayIcon.ShowBalloonTip(10000, "Frühstück", "Pause in " + Properties.Settings.Default.notifyMinutes + " Minuten", ToolTipIcon.Info);
                }

                DateTime lunchTimeNotify = Properties.Settings.Default.lunchtime.AddMinutes(-Properties.Settings.Default.notifyMinutes);
                if (timeTmp.Hour == lunchTimeNotify.Hour && timeTmp.Minute == lunchTimeNotify.Minute)
                {
                    trayIcon.ShowBalloonTip(10000, "Mittagessen", "Pause in " + Properties.Settings.Default.notifyMinutes + " Minuten", ToolTipIcon.Info);
                }

                DateTime endTimeNotify = Properties.Settings.Default.feierabend.AddMinutes(-Properties.Settings.Default.notifyMinutes);
                //if (timeTmp.Hour >= endTimeNotify.Hour && timeTmp.Minute == endTimeNotify.Minute)
                if(timeTmp >= endTimeNotify)
                {
                    clockWatch.Interval = 300000 ;
                    trayIcon.ShowBalloonTip(10000, "Feierabend", "Arbeitszeit überschritten", ToolTipIcon.Warning);
                }
            }
        }

        private void read(object sender, EventArgs e)
        {
            readLastFromLog();
        }

        protected override void Dispose(bool isDisposing)
        {
            // Release the icon resource.
            trayIcon.Dispose();
        }

        private void LogWrite(DateTime begin, DateTime ending)
        {
            string[] data = { begin.ToString("dd.MM.yyyy"), begin.ToString("HH:mm"), ending.ToString("HH:mm") };
            // String message = Environment.NewLine + string.Join(",", data);
            String message = string.Join(",", data);
            //var path = Path.Combine(workingDirectory, "time.log");
            File.AppendAllLines(log, new string[] {message});
        }

        private String[] readLastFromLog()
        {
            //var path = Path.Combine(workingDirectory, "time.log");
            //Console.WriteLine(log.ToString());
            DateTime today = DateTime.Today;
            //string[] lines = File.ReadAllLines(log);
            //Console.WriteLine(lines.Length);
            //Console.WriteLine(lines[lines.Length - 1]);

            String[] readData = logContent[logContent.Length - 1].Split(',');
            return readData;
        }
        public String[] selectFromLog(DateTime date)
        {
            String searchDate = date.ToString("dd.MM.yyyy");
            String[] readLine = readLastFromLog();
            //int index = Array.IndexOf(logContent, searchDate);
            int index = Array.FindIndex(logContent, logEntry => logEntry.StartsWith(searchDate));

            //for (int i = 0; i < logContent.Length; i++)
            //{
                //if(logContent[i].StartsWith(searchDate))
                //{
                    //Console.WriteLine("SearchDate-Index: " + searchDate + " , " + i);
                    try
                    {
                        readLine = logContent[index].Split(',');
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                //}
            //}
            return readLine;
        }

        private void OpenGui(object sender, EventArgs e)
        {
            TimeLineGui timeLineGui = new TimeLineGui(this, trayIcon);
            timeLineGui.WindowState = FormWindowState.Normal;
            timeLineGui.Show();
            

        }
    }
}
