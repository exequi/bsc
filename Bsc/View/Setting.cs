using Bsc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bsc.View
{
    public partial class Setting : Form
    {
        Account account;
        Config config;
        public Setting()
        {
            InitializeComponent();
        }


        private void Setting_Load(object sender, EventArgs e)
        {
            account = Account.Load();
            this.txt_username.Text = account.UserName;
            this.txt_password.Text ="*****";
            if (account.IsPass())
            {
                this.btn_createaccount.Visible = false;
            }

            config = Config.Load();
            this.txt_apiurl.Text = config.ApiHost;
            this.txt_up_interval.Text = config.UpInterval;
            this.txt_down_interval.Text = config.DownInterval;
            this.cb_authup.Checked = config.AutoStart;
            this.cb_up_rightnow.Checked = config.UpRigthNow;
            config.AutoFile.Select((p,i) =>
            {
                this.cb_list_auto.SetItemCheckState(i, p? CheckState.Checked:CheckState.Unchecked);
                return p;
            }).ToArray();
            
        }

        private void btn_createaccount_Click(object sender, EventArgs e)
        {
            account.Register(this.txt_username.Text, this.txt_password.Text);
            this.btn_createaccount.Visible = false;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            config.ApiHost = this.txt_apiurl.Text;
            config.UpInterval =this.txt_up_interval.Text;
            config.DownInterval = this.txt_down_interval.Text;
            config.AutoStart = this.cb_authup.Checked;
            config.UpRigthNow = this.cb_up_rightnow.Checked;
            config.AutoFile = new bool[]{
                cb_list_auto.GetItemChecked(0),
                cb_list_auto.GetItemChecked(1),
                cb_list_auto.GetItemChecked(2)};
            config.Update();
            this.Close();
        }
    }
}
