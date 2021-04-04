using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMAPI;
namespace SaveViewerProtector
{
    public partial class UIAccounts : DarkUI.Forms.DarkForm
    {
        public UIAccounts()
        {
            InitializeComponent();
        }
        SMAPI.SManager AccountApi = new SMAPI.SManager();
        DarkUI.Controls.DarkListItem id = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem rid = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem name = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem meta = new DarkUI.Controls.DarkListItem();
        DarkUI.Controls.DarkListItem lastworld = new DarkUI.Controls.DarkListItem();
        private void UIAccounts_Load(object sender, EventArgs e)
        {
           
            id.Text =AccountApi.GetElement("g_id", "tankid_name");
            darkListView1.Items.Add(id);
            rid.Text = AccountApi.GetElement("rid", "rid");
            darkListView1.Items.Add(rid);
            name.Text = AccountApi.GetElement("name", "name");
            darkListView1.Items.Add(name);
            string d_meta= Encoding.BigEndianUnicode.GetString(Array.ConvertAll(Regex.Unescape(AccountApi.GetElement("","meta")).ToCharArray(), c => (byte)c));
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

        private void darkButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
