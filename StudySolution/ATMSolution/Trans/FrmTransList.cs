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
    public partial class FrmTransList : Form
    {
        private List<TransInfo> TransList = new List<TransInfo>();

        public FrmTransList()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            TransList = FileHelper.GetTransList();

            this.dgvData.AutoGenerateColumns = false; //不自动生成列
            this.dgvData.DataSource = TransList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var resultList = new List<TransInfo>();

            var search = txtSearch.Text;

            foreach (var item in TransList)
            {
                if (item.CardNo.Contains(search))
                {
                    resultList.Add(item);
                }

                else if (item.Remark.Contains(search))
                {
                    resultList.Add(item);
                }

                else if (item.TransType.Contains(search))
                {
                    resultList.Add(item);
                }
            }

            this.dgvData.DataSource = null;
            this.dgvData.DataSource = resultList;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
