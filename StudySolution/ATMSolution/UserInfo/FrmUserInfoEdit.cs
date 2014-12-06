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
    public partial class FrmUserInfoEdit : Form
    {
        //是否保存成功了
        private bool Success = false;

        //如果当前变量中有值，那么就是修改，如果没有值那么就是新增
        private ATMSolution.Model.UserInfo EditUserInfo = null;

        public FrmUserInfoEdit()
        {
            InitializeComponent();
        }

        public FrmUserInfoEdit(ATMSolution.Model.UserInfo info)
        {
            InitializeComponent();

            EditUserInfo = info;

            EditInit();
        }

        private void EditInit()
        {
            //将用户信息填写到当前页面上
            txtCustomerName.Text = EditUserInfo.CustomerName;
            txtPid.Text = EditUserInfo.Pid;
            txtTelPhone.Text = EditUserInfo.TelPhone;
            txtAddress.Text = EditUserInfo.Address;
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
            ATMSolution.Model.UserInfo userInfo = null;

            if (EditUserInfo == null) //新增
            {
                userInfo = new ATMSolution.Model.UserInfo();
            }
            else
            {
                userInfo = EditUserInfo;
            }

            userInfo.CustomerName = txtCustomerName.Text;
            userInfo.Pid = txtPid.Text;
            userInfo.TelPhone = txtTelPhone.Text;
            userInfo.Address = txtAddress.Text;
            userInfo.CreateTime = DateTime.Now; //取当前的时间

            if (Check(userInfo) == false)
                return;

            //获取所有的用户信息列表
            var userInfoList = FileHelper.GetUserInfos();

            foreach (var temp in userInfoList)
            {
                if (temp.Pid == userInfo.Pid && temp.Id != userInfo.Id)
                {
                    MessageBox.Show("身份证号重复，请重新输入");
                    txtPid.Focus();
                    return;
                }
            }

            if (EditUserInfo == null) //新增时，才生成新ID
            {
                userInfo.Id = userInfoList.Count() + 1;
            }

            //所有数据监测合格，写入到文件中
            var data = userInfo.SelfToString();

            FileHelper.AppendUserInfo(userInfo.Id, data);

            if (EditUserInfo == null) //新增时，才生成新ID
            {
                MessageBox.Show("开户成功");
            }
            else
            {
                MessageBox.Show("修改成功");
            }

            Success = true;

            this.Close();
        }

        public bool GetSuccess()
        {
            return Success;
        }

        private bool Check(ATMSolution.Model.UserInfo userInfo)
        {
            if (string.IsNullOrWhiteSpace(userInfo.CustomerName))
            {
                MessageBox.Show("请输入开户名");
                txtCustomerName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(userInfo.Pid))
            {
                MessageBox.Show("请输入身份证");
                txtPid.Focus();
                return false;
            }

            return true;
        }
    }
}

