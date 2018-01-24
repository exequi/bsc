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

namespace Bsc
{
    public partial class Main : Form
    {
        Account account;
        public Main()
        {
            InitializeComponent();


        }

        private void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.Setting().ShowDialog();
        }

        private void 主机备份文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.BackFolder().ShowDialog();
        }

        private void 备份机关联ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.Connect().ShowDialog();
        }

        private void 文件对比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.Compare().ShowDialog();
        }

        private void 下载文件对比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.Compare().ShowDialog();
        }
        private void 下载日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.UpDownLog().ShowDialog();
        }

        private void 上传日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.UpDownLog().ShowDialog();
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            account = Account.Load();
            if (account.IsPass())
            {

            }
        }

    }
}
