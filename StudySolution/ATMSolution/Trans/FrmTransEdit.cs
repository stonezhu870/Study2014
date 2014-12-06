using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATMSolution.Model;

namespace ATMSolution.UserInfo
{
    public partial class FrmTransEdit : Form
    {
        //是否保存成功了
        private bool Success = false;

        public FrmTransEdit(TranType type)
        {
            InitializeComponent();

            cbxTransType.SelectedItem = type == TranType.Out ? "支出" : "存入";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确定要关闭吗？", "提示", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TransInfo transInfo = new TransInfo();

            transInfo.TransDate = dtTransDate.Value;
            transInfo.CardNo = txtCardNo.Text;
            transInfo.TransType = Convert.ToString(cbxTransType.SelectedItem);
            transInfo.Remark = txtRemark.Text;
            transInfo.Money = nudMoney.Value;

            if (Check(transInfo) == false)
                return;

            var list = FileHelper.GetTransList();

            transInfo.Id = list.Count() + 1;

            //所有数据监测合格，写入到文件中
            var data = transInfo.SelfToString();

            FileHelper.AppendTransInfo(transInfo.Id, data);

            MessageBox.Show("交易成功");

            Success = true;

            this.Close();
        }

        public bool GetSuccess()
        {
            return Success;
        }

        private bool Check(TransInfo info)
        {
            if (string.IsNullOrWhiteSpace(info.CardNo))
            {
                MessageBox.Show("请输入卡号");
                txtCardNo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(info.TransType))
            {
                MessageBox.Show("请选择交易类型");
                cbxTransType.Focus();
                return false;
            }

            if (info.Money == 0)
            {
                MessageBox.Show("请设置交易金额");
                nudMoney.Focus();
                return false;
            }

            return true;
        }
    }
}

