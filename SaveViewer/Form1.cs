using SaveViewerProtector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveViewer
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        SMAPI.SManager Utility = new SMAPI.SManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using my SaveProtector utility stay safe! ");
            try
            {
                id.Text = AccountApi.GetElement("g_id", "tankid_name");


                darkListView1.Items.Add(id);
                rid.Text = AccountApi.GetElement("rid", "rid");
                darkListView1.Items.Add(rid);
                name.Text = AccountApi.GetElement("name", "name");
                darkListView1.Items.Add(name);
                string d_meta = Encoding.BigEndianUnicode.GetString(Array.ConvertAll(Regex.Unescape(AccountApi.GetElement("", "meta")).ToCharArray(), c => (byte)c));
                meta.Text = "meta " + d_meta + " (buggy)";
                darkListView1.Items.Add(meta);
                try
                {
                    lastworld.Text = AccountApi.GetElement("world", "lastworld");
                    darkListView1.Items.Add(lastworld);
                }
                catch
                {

                }
            }
            catch
            {

            }
           
        }
        SMAPI.SManager AccountApi = new SMAPI.SManager();
        DarkUI.Controls.DarkListItem id = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem rid = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem name = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem meta = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem lastworld = new DarkUI.Controls.DarkListItem();
        private void darkStatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        UIAccounts View_1 = new UIAccounts();
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            View_1.ShowDialog();
        }

        private void secureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.ProtectData("auto","auto");
            liveCheck.Start();
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
            toolStripStatusLabel1.Text = "Protection Status: Secure";
        }

        private void unsecureToolStripMenuItem_Click(object sender, EventArgs e)
        {
           darkTextBox1.AppendText(Utility.UnsecureData("auto", "auto"));
            toolStripStatusLabel1.Text = "Protection Status: Insecure";
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            
                //if the form is minimized  
                //hide it from the task bar  
                //and show the system tray icon (represented by the NotifyIcon control)  
                if (this.WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    notifyIcon1.Visible = true;
                }
            }
        bool msgboxshown = false;
        private void liveCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("Growtopia")[0].Id > 0)
                {
                    System.Diagnostics.Debug.WriteLine("gt running");
                    if (msgboxshown == false)
                    {
                        msgboxshown = true;
                      
                        if (MessageBox.Show(this, "GT looks like started! wanna disable the protection and keep playing? you are going to be insecure while you are in play mode", "SaveViewerProtector - GT 4", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process.GetProcessesByName("Growtopia")[0].Kill();
                            darkTextBox1.AppendText(Utility.UnsecureData("auto", "auto"));
                        }
                        liveCheck.Stop();
                    }
                    
                    
                }
            }
            catch
            {

            }
            
        }
    }
    }

