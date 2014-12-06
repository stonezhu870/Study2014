using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATMSolution.UserInfo;
using ATMSolution.CardInfo;
using ATMSolution.Model;

namespace ATMSolution
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 开户ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmUserInfoEdit();
            form.ShowDialog();
        }

        private void 用户信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmUserInfoList();
            //Show打开新页面后，后面的页面还可以点击
            //ShowDialog打开新页面后，后面的页面不能点击，除非关闭当前弹出页面
            form.ShowDialog();
        }

        private void 开卡ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmCardInfo();
            form.ShowDialog();

        
            
        }

        private void 交易查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTransList();
            frm.ShowDialog();
        }

        private void 支出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTransEdit(TranType.Out);
            frm.ShowDialog();
        }

        private void 存入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTransEdit(TranType.In);
            frm.ShowDialog();
        }
    }
}
