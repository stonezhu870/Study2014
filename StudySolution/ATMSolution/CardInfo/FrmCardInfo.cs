using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATMSolution.Model;
using ATMSolution.UserInfo;

namespace ATMSolution.CardInfo
{
    public partial class FrmCardInfo : Form
    {
        private bool Success = false;
        private ATMSolution.Model.UserInfo SelectedUserInfo = null;
        private ATMSolution.Model.CardInfo EditCardInfo = null;

        public FrmCardInfo()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            txtCardNo.Text = NewCardNo();
        }

        private string NewCardNo()
        {
            var sb = new StringBuilder(); //字符串

            var rm = new Random();
            for (var i = 0; i < 12; i++)
            {
                var num = rm.Next(0, 10);

                if (i != 0 && i%4 == 0)
                    sb.Append(" ");

                sb.Append(num);
            }

            return sb.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var frm = new FrmUserInfoList(OperateMode.Select);
            frm.ShowDialog();

            SelectedUserInfo = frm.GetSelectedUserInfo();
            if (SelectedUserInfo != null)
            {
                txtUserInfo.Text = string.Format("{0}({1})", SelectedUserInfo.CustomerName, SelectedUserInfo.Pid);
                txtCardNo.Focus();
            }
        }

        private void btnCardInfoclose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确定要关闭吗？", "提示", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCardInfosave_Click(object sender, EventArgs e)
        {
           
            ATMSolution.Model.CardInfo cardInfo = null;

            if (EditCardInfo == null) //新增
            {
                cardInfo = new ATMSolution.Model.CardInfo();
            }
            else
            {
                cardInfo = EditCardInfo;
            }




           
            cardInfo.CurType = laCurType.Text;
            cardInfo.CardNo = txtCardNo.Text;
            cardInfo.SavingTypr = rbtSavingTyprCurrent.Text;
            cardInfo.Balance = txtBalance.Text;                       
            cardInfo.Pass = txtPass.Text;
            cardInfo.OpenDate = DateTime.Now;
            if (SelectedUserInfo != null)
            { cardInfo.userid = SelectedUserInfo.Id; }

            if (Check(cardInfo) == false)
                return;
         
           
           
            var list = FileHelper.GetCardInfo();

            cardInfo.Id = list.Count() + 1;

            //所有数据监测合格，写入到文件中
            var data = cardInfo.SelfToString();

            FileHelper.AppendCardInfo(cardInfo.Id, data);

            MessageBox.Show("开卡成功");

            Success = true;

            this.Close();

        }
        public bool GetSuccess()
        {
            return Success;
        }

        private bool Check(ATMSolution.Model.CardInfo cardInfo)
        {
            if (txtUserInfo.Text == "")
            {
                MessageBox.Show("请选择用户");
                return false;
                
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("请输入密码");
                txtPass.Focus();
                return false;
            }

            if (rbtSavingTyprCurrent.Checked == false && rbtSavingTyprRegular.Checked == false )
            {
                MessageBox.Show("请选择存款类型");
                return false;
            }
            
            
            
            return true;
        }
       
    }
}
