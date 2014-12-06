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
    public partial class FrmUserInfoList : Form
    {
        private List<ATMSolution.Model.UserInfo> UserInfoList = new List<ATMSolution.Model.UserInfo>();

        private OperateMode Mode = OperateMode.Normal;

        private ATMSolution.Model.UserInfo SelectedUserInfo = null;

        //参数上直接写等于，表示参数有默认值，可以不传
        public FrmUserInfoList(OperateMode operateMode = OperateMode.Normal)
        {
            InitializeComponent();

            Mode = operateMode;

            Init();
        }

        private void Init()
        {
            UserInfoList = FileHelper.GetUserInfos();

            this.dgvData.AutoGenerateColumns = false; //不自动生成列
            this.dgvData.DataSource = UserInfoList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var resultList = new List<ATMSolution.Model.UserInfo>();

            var search = txtSearch.Text;

            foreach (var userInfo in UserInfoList)
            {
                if (userInfo.CustomerName.Contains(search))
                {
                    resultList.Add(userInfo);
                }

                else if (userInfo.Pid.Contains(search))
                {
                    resultList.Add(userInfo);
                }

                else if (userInfo.TelPhone.Contains(search))
                {
                    resultList.Add(userInfo);
                }

                else if (userInfo.Address.Contains(search))
                {
                    resultList.Add(userInfo);
                }
            }

            this.dgvData.DataSource = null;
            this.dgvData.DataSource = resultList;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取点击行的ID列
            var id = Convert.ToInt32(this.dgvData.Rows[e.RowIndex].Cells["Id"].Value);

            ATMSolution.Model.UserInfo userInfo = null;

            foreach (var temp in UserInfoList)
            {
                if (temp.Id == id)
                {
                    userInfo = temp;
                    break;
                }
            }

            if (Mode == OperateMode.Normal)
            {
                var form = new FrmUserInfoEdit(userInfo);

                form.ShowDialog();

                if (form.GetSuccess())
                {
                    Init();
                }
            }
            else
            {
                SelectedUserInfo = userInfo;
                this.Close();
            }
        }

        public ATMSolution.Model.UserInfo GetSelectedUserInfo()
        {
            return SelectedUserInfo;
        }
    }
}
