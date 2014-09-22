using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using SITAWarning.Properties;

namespace DialogFinder
{
    public partial class SetupForm : Form
    {
        bool _mAllowVisible;     // ContextMenu's Show command used
        bool _mAllowClose;       // ContextMenu's Exit command used
        bool _mLoadFired;        // Form was shown once
        private System.Timers.Timer gTimer; 

        public SetupForm()
        {
            InitializeComponent();
            PopulateListBox();
            gTimer = new System.Timers.Timer();
            gTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            var timeperiod = Settings.Default.CheckInterval;
            gTimer.Interval = timeperiod > 0 ? timeperiod : 300000;
            gTimer.Enabled = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            this.showToolStripMenuItem.Click += toolStripMenuItem1_Click;
            this.exitToolStripMenuItem.Click += finddialogToolStripMenuItem_Click;
        }

        private void PopulateListBox()
        {
            try
            {
                string[] mailaddresses = Settings.Default.Mailaddresses.Split(Convert.ToChar(";"));
                foreach (var mail in mailaddresses)
                {
                    var mailstr = mail.Trim();
                    if (mailstr != "")
                    {
                        listBox1.Items.Add(mail);
                    }
                }
                Settings.Default.Mailaddresses = "";
            }
            catch (Exception)
            {
                listBox1.Items.Clear();
            }
        }

        protected override void SetVisibleCore(bool value) {
            if (!_mAllowVisible) {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            PopulateMailAddresses();
            if (!_mAllowClose) {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void PopulateMailAddresses()
        {
            var sb = new StringBuilder();

            foreach (var mailitem in listBox1.Items)
            {
                sb.Append(mailitem + ";");
            }

            Settings.Default.Mailaddresses = sb.ToString();
            Settings.Default.Save();
        }


        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var hwnd = Win32.FindWindow("#32770", "RM Message Server");
            //var hwnd = Win32.FindWindow("#32770", "Users");
            if (hwnd != 0)
            {
                //MessageBox.Show("Users active");
                SendMailWarning();
            }
            //else
            //{
            //    MessageBox.Show(@"Users NOT active");
            //}

        }

        public void SendMailWarning()
        {
            var mail = new mail();
            var sb = new StringBuilder();

            foreach (var mailitem in listBox1.Items)
            {
                sb.Append(mailitem + ",");
            }

            mail.SendMail(sb.ToString());
            gTimer.Stop();

            if (MessageBox.Show(@"Close this message to start the check of SITA again!", @"Warning mail has been sent",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                // Restarts the timer.
                gTimer.Enabled = true;
            }
        }

        private void finddialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mAllowClose = _mAllowVisible = true;
            if (!_mLoadFired) Show();
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _mAllowVisible = true;
            _mLoadFired = true;
            Show();
        }

        private void addMail_Click(object sender, EventArgs e)
        {
            var emailtext = tb_mail.Text.Trim();
            if (emailtext != "")
            {
                listBox1.Items.Add(emailtext);
                tb_mail.Clear();
            }
        }

        private void deleteMail_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

    }
}
