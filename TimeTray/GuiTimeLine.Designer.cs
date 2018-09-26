namespace TimeTray
{
    partial class TimeLineGui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLineGui));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeBreakfast = new System.Windows.Forms.DateTimePicker();
            this.timeNoon = new System.Windows.Forms.DateTimePicker();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblNoon = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.calSelectDate = new System.Windows.Forms.MonthCalendar();
            this.lblBeginn = new System.Windows.Forms.Label();
            this.lblEnde = new System.Windows.Forms.Label();
            this.lblBeginnDate = new System.Windows.Forms.Label();
            this.lblEndeTime = new System.Windows.Forms.Label();
            this.lblBeginnTime = new System.Windows.Forms.Label();
            this.upDownLaengeBreakfast = new System.Windows.Forms.NumericUpDown();
            this.upDownLaengeLunch = new System.Windows.Forms.NumericUpDown();
            this.upDownLaengeArbeitszeit = new System.Windows.Forms.NumericUpDown();
            this.lblArbeitszeit = new System.Windows.Forms.Label();
            this.lblLaengeBreak = new System.Windows.Forms.Label();
            this.lblSollzeit = new System.Windows.Forms.Label();
            this.lblSollzeitTime = new System.Windows.Forms.Label();
            this.lblNotify = new System.Windows.Forms.Label();
            this.upDownNotify = new System.Windows.Forms.NumericUpDown();
            this.chkBoxNotify = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLaengeBreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLaengeLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLaengeArbeitszeit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // timeBreakfast
            // 
            this.timeBreakfast.CustomFormat = "HH:mm";
            this.timeBreakfast.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBreakfast.Location = new System.Drawing.Point(109, 24);
            this.timeBreakfast.Name = "timeBreakfast";
            this.timeBreakfast.ShowUpDown = true;
            this.timeBreakfast.Size = new System.Drawing.Size(88, 20);
            this.timeBreakfast.TabIndex = 0;
            this.timeBreakfast.Value = new System.DateTime(2018, 9, 24, 9, 0, 0, 0);
            this.timeBreakfast.ValueChanged += new System.EventHandler(this.timeBreakfast_ValueChanged);
            // 
            // timeNoon
            // 
            this.timeNoon.CustomFormat = "HH:mm";
            this.timeNoon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeNoon.Location = new System.Drawing.Point(109, 50);
            this.timeNoon.Name = "timeNoon";
            this.timeNoon.ShowUpDown = true;
            this.timeNoon.Size = new System.Drawing.Size(88, 20);
            this.timeNoon.TabIndex = 1;
            this.timeNoon.Value = new System.DateTime(2018, 9, 24, 12, 0, 0, 0);
            this.timeNoon.ValueChanged += new System.EventHandler(this.timeNoon_ValueChanged);
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(15, 24);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(88, 13);
            this.lblBreakfast.TabIndex = 2;
            this.lblBreakfast.Text = "Frühstückspause";
            // 
            // lblNoon
            // 
            this.lblNoon.AutoSize = true;
            this.lblNoon.Location = new System.Drawing.Point(15, 50);
            this.lblNoon.Name = "lblNoon";
            this.lblNoon.Size = new System.Drawing.Size(70, 13);
            this.lblNoon.TabIndex = 3;
            this.lblNoon.Text = "Mittagspause";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(18, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // calSelectDate
            // 
            this.calSelectDate.Location = new System.Drawing.Point(18, 211);
            this.calSelectDate.MaxDate = new System.DateTime(2018, 9, 25, 0, 0, 0, 0);
            this.calSelectDate.MaxSelectionCount = 1;
            this.calSelectDate.Name = "calSelectDate";
            this.calSelectDate.ShowTodayCircle = false;
            this.calSelectDate.TabIndex = 5;
            this.calSelectDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calSelectDate_DateSelected);
            // 
            // lblBeginn
            // 
            this.lblBeginn.AutoSize = true;
            this.lblBeginn.Location = new System.Drawing.Point(200, 211);
            this.lblBeginn.Name = "lblBeginn";
            this.lblBeginn.Size = new System.Drawing.Size(40, 13);
            this.lblBeginn.TabIndex = 6;
            this.lblBeginn.Text = "Beginn";
            // 
            // lblEnde
            // 
            this.lblEnde.AutoSize = true;
            this.lblEnde.Location = new System.Drawing.Point(200, 241);
            this.lblEnde.Name = "lblEnde";
            this.lblEnde.Size = new System.Drawing.Size(32, 13);
            this.lblEnde.TabIndex = 7;
            this.lblEnde.Text = "Ende";
            // 
            // lblBeginnDate
            // 
            this.lblBeginnDate.AutoSize = true;
            this.lblBeginnDate.Location = new System.Drawing.Point(247, 211);
            this.lblBeginnDate.Name = "lblBeginnDate";
            this.lblBeginnDate.Size = new System.Drawing.Size(0, 13);
            this.lblBeginnDate.TabIndex = 8;
            // 
            // lblEndeTime
            // 
            this.lblEndeTime.AutoSize = true;
            this.lblEndeTime.Location = new System.Drawing.Point(242, 241);
            this.lblEndeTime.Name = "lblEndeTime";
            this.lblEndeTime.Size = new System.Drawing.Size(55, 13);
            this.lblEndeTime.TabIndex = 9;
            this.lblEndeTime.Text = "EndeTime";
            // 
            // lblBeginnTime
            // 
            this.lblBeginnTime.AutoSize = true;
            this.lblBeginnTime.Location = new System.Drawing.Point(242, 211);
            this.lblBeginnTime.Name = "lblBeginnTime";
            this.lblBeginnTime.Size = new System.Drawing.Size(63, 13);
            this.lblBeginnTime.TabIndex = 10;
            this.lblBeginnTime.Text = "BeginnTime";
            // 
            // upDownLaengeBreakfast
            // 
            this.upDownLaengeBreakfast.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownLaengeBreakfast.Location = new System.Drawing.Point(214, 24);
            this.upDownLaengeBreakfast.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownLaengeBreakfast.Name = "upDownLaengeBreakfast";
            this.upDownLaengeBreakfast.Size = new System.Drawing.Size(44, 20);
            this.upDownLaengeBreakfast.TabIndex = 11;
            this.upDownLaengeBreakfast.ValueChanged += new System.EventHandler(this.upDownLaengeBreakfast_ValueChanged);
            // 
            // upDownLaengeLunch
            // 
            this.upDownLaengeLunch.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownLaengeLunch.Location = new System.Drawing.Point(214, 49);
            this.upDownLaengeLunch.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownLaengeLunch.Name = "upDownLaengeLunch";
            this.upDownLaengeLunch.Size = new System.Drawing.Size(44, 20);
            this.upDownLaengeLunch.TabIndex = 12;
            this.upDownLaengeLunch.ValueChanged += new System.EventHandler(this.upDownLaengeLunch_ValueChanged);
            // 
            // upDownLaengeArbeitszeit
            // 
            this.upDownLaengeArbeitszeit.Location = new System.Drawing.Point(109, 76);
            this.upDownLaengeArbeitszeit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownLaengeArbeitszeit.Name = "upDownLaengeArbeitszeit";
            this.upDownLaengeArbeitszeit.Size = new System.Drawing.Size(44, 20);
            this.upDownLaengeArbeitszeit.TabIndex = 13;
            this.upDownLaengeArbeitszeit.ValueChanged += new System.EventHandler(this.upDownLaengeArbeitszeit_ValueChanged);
            // 
            // lblArbeitszeit
            // 
            this.lblArbeitszeit.AutoSize = true;
            this.lblArbeitszeit.Location = new System.Drawing.Point(15, 78);
            this.lblArbeitszeit.Name = "lblArbeitszeit";
            this.lblArbeitszeit.Size = new System.Drawing.Size(85, 13);
            this.lblArbeitszeit.TabIndex = 14;
            this.lblArbeitszeit.Text = "Arbeitszeit in Std";
            // 
            // lblLaengeBreak
            // 
            this.lblLaengeBreak.AutoSize = true;
            this.lblLaengeBreak.Location = new System.Drawing.Point(200, 8);
            this.lblLaengeBreak.Name = "lblLaengeBreak";
            this.lblLaengeBreak.Size = new System.Drawing.Size(107, 13);
            this.lblLaengeBreak.TabIndex = 15;
            this.lblLaengeBreak.Text = "Pausen-Länge in Min";
            // 
            // lblSollzeit
            // 
            this.lblSollzeit.AutoSize = true;
            this.lblSollzeit.Location = new System.Drawing.Point(200, 275);
            this.lblSollzeit.Name = "lblSollzeit";
            this.lblSollzeit.Size = new System.Drawing.Size(40, 13);
            this.lblSollzeit.TabIndex = 16;
            this.lblSollzeit.Text = "Sollzeit";
            // 
            // lblSollzeitTime
            // 
            this.lblSollzeitTime.AutoSize = true;
            this.lblSollzeitTime.Location = new System.Drawing.Point(242, 275);
            this.lblSollzeitTime.Name = "lblSollzeitTime";
            this.lblSollzeitTime.Size = new System.Drawing.Size(63, 13);
            this.lblSollzeitTime.TabIndex = 17;
            this.lblSollzeitTime.Text = "SollzeitTime";
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Location = new System.Drawing.Point(314, 8);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(121, 13);
            this.lblNotify.TabIndex = 18;
            this.lblNotify.Text = "Benachrichtigung in Min";
            // 
            // upDownNotify
            // 
            this.upDownNotify.Location = new System.Drawing.Point(317, 23);
            this.upDownNotify.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownNotify.Name = "upDownNotify";
            this.upDownNotify.Size = new System.Drawing.Size(38, 20);
            this.upDownNotify.TabIndex = 19;
            this.upDownNotify.ValueChanged += new System.EventHandler(this.upDownNotify_ValueChanged);
            // 
            // chkBoxNotify
            // 
            this.chkBoxNotify.AutoSize = true;
            this.chkBoxNotify.Checked = true;
            this.chkBoxNotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxNotify.Location = new System.Drawing.Point(317, 55);
            this.chkBoxNotify.Name = "chkBoxNotify";
            this.chkBoxNotify.Size = new System.Drawing.Size(150, 17);
            this.chkBoxNotify.TabIndex = 21;
            this.chkBoxNotify.Text = "Benachrichtigung Ja/Nein";
            this.chkBoxNotify.UseVisualStyleBackColor = true;
            this.chkBoxNotify.CheckedChanged += new System.EventHandler(this.chkBoxNotify_CheckedChanged);
            // 
            // TimeLineGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 391);
            this.Controls.Add(this.chkBoxNotify);
            this.Controls.Add(this.upDownNotify);
            this.Controls.Add(this.lblNotify);
            this.Controls.Add(this.lblSollzeitTime);
            this.Controls.Add(this.lblSollzeit);
            this.Controls.Add(this.lblLaengeBreak);
            this.Controls.Add(this.lblArbeitszeit);
            this.Controls.Add(this.upDownLaengeArbeitszeit);
            this.Controls.Add(this.upDownLaengeLunch);
            this.Controls.Add(this.upDownLaengeBreakfast);
            this.Controls.Add(this.lblBeginnTime);
            this.Controls.Add(this.lblEndeTime);
            this.Controls.Add(this.lblBeginnDate);
            this.Controls.Add(this.lblEnde);
            this.Controls.Add(this.lblBeginn);
            this.Controls.Add(this.calSelectDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNoon);
            this.Controls.Add(this.lblBreakfast);
            this.Controls.Add(this.timeNoon);
            this.Controls.Add(this.timeBreakfast);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeLineGui";
            this.Text = "TimeLine";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.upDownLaengeBreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLaengeLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLaengeArbeitszeit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownNotify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker timeBreakfast;
        private System.Windows.Forms.DateTimePicker timeNoon;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblNoon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MonthCalendar calSelectDate;
        private System.Windows.Forms.Label lblBeginn;
        private System.Windows.Forms.Label lblEnde;
        private System.Windows.Forms.Label lblBeginnDate;
        private System.Windows.Forms.Label lblEndeTime;
        private System.Windows.Forms.Label lblBeginnTime;
        private System.Windows.Forms.NumericUpDown upDownLaengeBreakfast;
        private System.Windows.Forms.NumericUpDown upDownLaengeLunch;
        private System.Windows.Forms.NumericUpDown upDownLaengeArbeitszeit;
        private System.Windows.Forms.Label lblArbeitszeit;
        private System.Windows.Forms.Label lblLaengeBreak;
        private System.Windows.Forms.Label lblSollzeit;
        private System.Windows.Forms.Label lblSollzeitTime;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.NumericUpDown upDownNotify;
        private System.Windows.Forms.CheckBox chkBoxNotify;
    }
}

