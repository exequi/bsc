using Bsc.Api;
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
    public partial class BackFolder : Form
    {
        List<Bsc.Model.Folder> masterfloder;
        UserFolder userfolder;
        string defaultPath = "";

        public BackFolder()
        {
            InitializeComponent();
        }

        private void BackFolder_Load(object sender, EventArgs e)
        {
            userfolder = new UserFolder();
            masterfloder = userfolder.GetMasterFolder();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.lb_master.SelectedItem != null)
            {
                string path = this.lb_master.SelectedItem.ToString();
                this.lb_master.Items.Remove(path);
                userfolder.DeleteMasterFolder(path);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择一个文件夹";
            dialog.ShowNewFolderButton = true;
            if (defaultPath != "")
            {
                dialog.SelectedPath = defaultPath;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                defaultPath = dialog.SelectedPath;
            }
            userfolder.AddMasterFolder(defaultPath);
            this.lb_master.Items.Add(defaultPath);

        }

        private void lb_master_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lb_backups.Items.Clear();
            if (this.lb_master.SelectedItem != null)
            {
                string path = this.lb_master.SelectedItem.ToString();
                var l=userfolder.GetSlaveFolder(path);
                l.Select(p => {
                    this.lb_backups.Items.Add(p.ToString());
                    return p; 
                }).FirstOrDefault();
            }
        }
    }
}
