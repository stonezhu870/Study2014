using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSolution.Model
{
    public class TransInfo
    {
        public int  Id { get; set; }
        public DateTime TransDate { get; set; }
        public string CardNo { get; set; }
        public string TransType { get; set; }
        public decimal Money { get; set; }
        public string Remark { get; set; }

        public string SelfToString()
        {
            //params 用这个声明的数组参数，可以用逗号一个一个的传入方法
            
            //所有数据监测合格，写入到文件中
            return string.Format("{0},{1},{2},{3},{4},{5}",
                              this.Id,
                              this.TransDate,
                              this.CardNo.Replace(",", "$$_$$"),
                              this.TransType.Replace(",", "$$_$$"),
                              this.Money,
                              this.Remark.Replace(",", "$$_$$").Replace("\r\n","$$__$$")
                );
        }

        public TransInfo()
        {
            
        }

        public TransInfo(string data)
        {
            var arr = data.Split(',');

            this.Id = int.Parse(arr[0]);
            this.TransDate = Convert.ToDateTime(arr[1]);
            this.CardNo = arr[2].Replace("$$_$$", ",");
            this.TransType = arr[3].Replace("$$_$$", ",");
            this.Money = Convert.ToDecimal(arr[4]);
            this.Remark = arr[5].Replace("$$_$$", ",").Replace("$$__$$", "\r\n");
        }
    }
}
