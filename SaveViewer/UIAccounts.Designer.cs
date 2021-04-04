
namespace SaveViewerProtector
{
    partial class UIAccounts
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
            this.darkListView1 = new DarkUI.Controls.DarkListView();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // darkListView1
            // 
            this.darkListView1.Location = new System.Drawing.Point(0, 32);
            this.darkListView1.Name = "darkListView1";
            this.darkListView1.ShowIcons = true;
            this.darkListView1.Size = new System.Drawing.Size(285, 228);
            this.darkListView1.TabIndex = 2;
            this.darkListView1.Text = "darkListView1";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(7, 9);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(109, 13);
            this.darkLabel1.TabIndex = 3;
            this.darkLabel1.Text = "User DB (this/device)";
            // 
            // UIAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 210);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.darkListView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UIAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SM:PROTECTOR";
            this.Load += new System.EventHandler(this.UIAccounts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkListView darkListView1;
        private DarkUI.Controls.DarkLabel darkLabel1;
    }
}