using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace TimeTray
{
    public partial class TimeLineGui : Form
    {
        TrayIcon trayApp;
        NotifyIcon trayIcon;
        public TimeLineGui(TrayIcon trayApp, NotifyIcon trayIcon)
        {
            this.trayApp = trayApp;
            this.trayIcon = trayIcon;

            InitializeComponent();

            this.initializeValues();
            btnSave.Enabled = false;
            calSelectDate.MaxDate = DateTime.Today;
            calSelectDate.SelectionStart = DateTime.Today;
            Properties.Settings.Default.Save();
        }

        private void initializeValues()
        {
            this.setSelectableDates();
            chkBoxNotify.CheckState = Properties.Settings.Default.notifyCheck;
            berechneSollzeit();
            //Properties.Settings.Default.feierabend = 
            upDownLaengeBreakfast.Value = Properties.Settings.Default.laengeBreakfast;
            upDownLaengeLunch.Value = Properties.Settings.Default.laengeLunch;
            upDownLaengeArbeitszeit.Value = Properties.Settings.Default.laengeArbeitszeit;
            upDownNotify.Value = Properties.Settings.Default.notifyMinutes;
            setLbl(trayApp.selectFromLog(DateTime.Now.Date));
        }
        private void timeBreakfast_ValueChanged(object sender, EventArgs e)
        {
            string brText;
            brText = timeBreakfast.Text;
            //if (brText == ConfigurationManager.AppSettings["breakfast"])
            if (brText == Properties.Settings.Default.breakfast.ToString("HH:mm"))
            {
                btnSave.Enabled = false;
            } else {
                btnSave.Enabled = true;
                //Console.WriteLine(timeBreakfast.Text);
            }
        }

        private void timeNoon_ValueChanged(object sender, EventArgs e)
        {
            string brText;
            brText = timeNoon.Text;
            if (brText == Properties.Settings.Default.lunchtime.ToString("HH:mm"))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                //Console.WriteLine(timeNoon.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.breakfast = DateTime.ParseExact(timeBreakfast.Text, "HH:mm", null);
            Properties.Settings.Default.lunchtime = DateTime.ParseExact(timeNoon.Text, "HH:mm", null);
            Properties.Settings.Default.laengeBreakfast = (int)upDownLaengeBreakfast.Value;
            Properties.Settings.Default.laengeLunch = (int)upDownLaengeLunch.Value;
            Properties.Settings.Default.laengeArbeitszeit = (int)upDownLaengeArbeitszeit.Value;
            Properties.Settings.Default.notifyCheck = chkBoxNotify.CheckState;
            Properties.Settings.Default.notifyMinutes = (int)upDownNotify.Value;
            berechneSollzeit();
            btnSave.Enabled = false;
            Properties.Settings.Default.Save();
        }

        private void calSelectDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = calSelectDate.SelectionRange.Start;
            if ((Array.IndexOf(calSelectDate.BoldedDates, selectedDate)) > -1)
            {
                setLbl(trayApp.selectFromLog(selectedDate));
            } else
            {
                trayIcon.ShowBalloonTip(600, "Ungueltiges Datum", "Kein gueltiges Datum gefunden.", ToolTipIcon.Error);
            }
        }

        private void setLbl(String[] dateSelected)
        {
            timeBreakfast.Text = Properties.Settings.Default.breakfast.ToString("HH:mm");
            timeNoon.Text = Properties.Settings.Default.lunchtime.ToString("HH:mm");
            lblBeginnTime.Text = dateSelected[1];
            lblEndeTime.Text = dateSelected[2];
            //lblSollzeitTime.Text = Properties.Settings.Default.tagesArbeitszeit.ToString("HH:mm");
            int tmpSollMinutes = (Properties.Settings.Default.laengeBreakfast + Properties.Settings.Default.laengeLunch) % 60;
            lblSollzeitTime.Text = Properties.Settings.Default.laengeArbeitszeit + " Std " + tmpSollMinutes + " Min";
        }

        private void setSelectableDates()
        {
            for(int i = 1; i < trayApp.logContent.Length; i++)
            {
                calSelectDate.AddBoldedDate(DateTime.Parse((trayApp.logContent[i].Split(','))[0]));
            }
        }

        private void upDownLaengeBreakfast_ValueChanged(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.laengeBreakfast == (int)upDownLaengeBreakfast.Value)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            //Properties.Settings.Default.laengeBreakfast = (int)upDownLaengeBreakfast.Value;
        }

        private void upDownLaengeLunch_ValueChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.laengeLunch = (int)upDownLaengeLunch.Value;
            if (Properties.Settings.Default.laengeLunch == (int)upDownLaengeLunch.Value)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void upDownLaengeArbeitszeit_ValueChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.laengeArbeitszeit = (int)upDownLaengeArbeitszeit.Value;
            if (Properties.Settings.Default.laengeArbeitszeit == (int)upDownLaengeArbeitszeit.Value)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void berechneSollzeit()
        {
            DateTime timeZero = DateTime.ParseExact("00:00", "HH:mm", null);
            timeZero.AddHours(Properties.Settings.Default.laengeArbeitszeit);
            timeZero.AddMinutes(Properties.Settings.Default.laengeLunch + Properties.Settings.Default.laengeBreakfast);
            //Properties.Settings.Default.tagesArbeitszeit = timeZero;
            //Console.WriteLine(Properties.Settings.Default.tagesArbeitszeit.ToString());
        }

        private void chkBoxNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.notifyCheck == chkBoxNotify.CheckState)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void upDownNotify_ValueChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.notifyMinutes == (int)upDownNotify.Value)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }
    }
}
