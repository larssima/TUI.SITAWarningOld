namespace DialogFinder
{
    partial class SetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finddialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStrip();
            this.addMail = new System.Windows.Forms.Button();
            this.deleteMail = new System.Windows.Forms.Button();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 251);
            this.listBox1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SITA warning";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.finddialogToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem1.Text = "Show";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // finddialogToolStripMenuItem
            // 
            this.finddialogToolStripMenuItem.Name = "finddialogToolStripMenuItem";
            this.finddialogToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.finddialogToolStripMenuItem.Text = "Exit";
            this.finddialogToolStripMenuItem.Click += new System.EventHandler(this.finddialogToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.None;
            this.showToolStripMenuItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.showToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.showToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.showToolStripMenuItem.TabIndex = 3;
            this.showToolStripMenuItem.Text = "toolStrip1";
            this.showToolStripMenuItem.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.None;
            this.exitToolStripMenuItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.exitToolStripMenuItem.Location = new System.Drawing.Point(0, 25);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.exitToolStripMenuItem.TabIndex = 4;
            this.exitToolStripMenuItem.Text = "toolStrip2";
            this.exitToolStripMenuItem.Visible = false;
            // 
            // addMail
            // 
            this.addMail.Location = new System.Drawing.Point(22, 308);
            this.addMail.Name = "addMail";
            this.addMail.Size = new System.Drawing.Size(75, 24);
            this.addMail.TabIndex = 5;
            this.addMail.Text = "Add";
            this.addMail.UseVisualStyleBackColor = true;
            this.addMail.Click += new System.EventHandler(this.addMail_Click);
            // 
            // deleteMail
            // 
            this.deleteMail.Location = new System.Drawing.Point(103, 309);
            this.deleteMail.Name = "deleteMail";
            this.deleteMail.Size = new System.Drawing.Size(75, 23);
            this.deleteMail.TabIndex = 6;
            this.deleteMail.Text = "Delete";
            this.deleteMail.UseVisualStyleBackColor = true;
            this.deleteMail.Click += new System.EventHandler(this.deleteMail_Click);
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(22, 279);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(300, 20);
            this.tb_mail.TabIndex = 7;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 349);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.deleteMail);
            this.Controls.Add(this.addMail);
            this.Controls.Add(this.showToolStripMenuItem);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exitToolStripMenuItem);
            this.Name = "SetupForm";
            this.Text = "SITA Warning";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip showToolStripMenuItem;
        private System.Windows.Forms.ToolStrip exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finddialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button addMail;
        private System.Windows.Forms.Button deleteMail;
        private System.Windows.Forms.TextBox tb_mail;
    }
}

