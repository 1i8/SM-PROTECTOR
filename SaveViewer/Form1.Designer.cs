
namespace SaveViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.accountsthisdeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.sMAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsecureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.liveCheck = new System.Windows.Forms.Timer(this.components);
            this.darkListView1 = new DarkUI.Controls.DarkListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.darkStatusStrip1.SuspendLayout();
            this.darkMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.AutoSize = false;
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1});
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 348);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(734, 29);
            this.darkStatusStrip1.SizingGrip = false;
            this.darkStatusStrip1.TabIndex = 0;
            this.darkStatusStrip1.Text = "darkStatusStrip1";
            this.darkStatusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.darkStatusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 16);
            this.toolStripStatusLabel1.Text = "Protection Status: Idle";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsthisdeviceToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::SaveViewerProtector.Properties.Resources.Glowing_Ball;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 19);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // accountsthisdeviceToolStripMenuItem
            // 
            this.accountsthisdeviceToolStripMenuItem.Name = "accountsthisdeviceToolStripMenuItem";
            this.accountsthisdeviceToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.accountsthisdeviceToolStripMenuItem.Text = "Accounts (this/device)";
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMAPIToolStripMenuItem,
            this.securityToolStripMenuItem});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip1.Size = new System.Drawing.Size(734, 24);
            this.darkMenuStrip1.TabIndex = 1;
            this.darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // sMAPIToolStripMenuItem
            // 
            this.sMAPIToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.sMAPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.sMAPIToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sMAPIToolStripMenuItem.Name = "sMAPIToolStripMenuItem";
            this.sMAPIToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sMAPIToolStripMenuItem.Text = "SMAPI";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.securityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secureToolStripMenuItem,
            this.unsecureToolStripMenuItem,
            this.createCertificateToolStripMenuItem});
            this.securityToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.securityToolStripMenuItem.Text = "Security";
            // 
            // secureToolStripMenuItem
            // 
            this.secureToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.secureToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.secureToolStripMenuItem.Name = "secureToolStripMenuItem";
            this.secureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.secureToolStripMenuItem.Text = "Secure";
            this.secureToolStripMenuItem.Click += new System.EventHandler(this.secureToolStripMenuItem_Click);
            // 
            // unsecureToolStripMenuItem
            // 
            this.unsecureToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.unsecureToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.unsecureToolStripMenuItem.Name = "unsecureToolStripMenuItem";
            this.unsecureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.unsecureToolStripMenuItem.Text = "Unsecure";
            this.unsecureToolStripMenuItem.Click += new System.EventHandler(this.unsecureToolStripMenuItem_Click);
            // 
            // createCertificateToolStripMenuItem
            // 
            this.createCertificateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.createCertificateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.createCertificateToolStripMenuItem.Name = "createCertificateToolStripMenuItem";
            this.createCertificateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.createCertificateToolStripMenuItem.Text = "Create Certificate";
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(491, 56);
            this.darkTextBox1.Multiline = true;
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(228, 293);
            this.darkTextBox1.TabIndex = 2;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(488, 40);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(74, 13);
            this.darkLabel1.TabIndex = 3;
            this.darkLabel1.Text = "Security Logs:";
            // 
            // liveCheck
            // 
            this.liveCheck.Tick += new System.EventHandler(this.liveCheck_Tick);
            // 
            // darkListView1
            // 
            this.darkListView1.Location = new System.Drawing.Point(15, 40);
            this.darkListView1.Name = "darkListView1";
            this.darkListView1.ShowIcons = true;
            this.darkListView1.Size = new System.Drawing.Size(467, 305);
            this.darkListView1.TabIndex = 4;
            this.darkListView1.Text = "darkListView1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 377);
            this.Controls.Add(this.darkListView1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkStatusStrip1);
            this.Controls.Add(this.darkMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.darkMenuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SM:PROTECTOR (GUI)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.darkStatusStrip1.ResumeLayout(false);
            this.darkStatusStrip1.PerformLayout();
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem accountsthisdeviceToolStripMenuItem;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sMAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsecureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCertificateToolStripMenuItem;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.Timer liveCheck;
        private DarkUI.Controls.DarkListView darkListView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

