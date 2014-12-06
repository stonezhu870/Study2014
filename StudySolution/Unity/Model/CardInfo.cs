using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSolution.Model
{
    public class CardInfo
    {
        public int Id { get; set; }
        public string CurType { get; set; }
        public string CardNo { get; set; }
        public string SavingTypr { get; set; }
        public string Balance { get; set; }
        public string Pass { get; set; }
        public DateTime OpenDate { get; set; }
        public int userid { get; set; }
        public string SelfToString()
        {
            //params 用这个声明的数组参数，可以用逗号一个一个的传入方法

            //所有数据监测合格，写入到文件中
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                              this.Id,
                              this.CurType,
                              this.CardNo.Replace(",", "$$_$$"),
                              this.SavingTypr.Replace(",", "$$_$$"),
                              this.Balance,
                              this.Pass.Replace(",", "$$_$$").Replace("\r\n", "$$__$$"),
                              this.OpenDate,
                              this.userid
                              
                );
        }
        public CardInfo()
        {
            
        }

        public CardInfo(string data)
        {
            var arr = data.Split(',');

            this.Id = int.Parse(arr[0]);
            this.CurType = Convert.ToString(arr[1]);
            this.CardNo = arr[2].Replace("$$_$$", ",");
            this.SavingTypr = arr[3].Replace("$$_$$", ",");
            this.Balance = arr[4];
            this.Pass = arr[5].Replace("$$_$$", ",").Replace("$$__$$", "\r\n");
            this.OpenDate = Convert.ToDateTime(arr[6]);
            if (arr.Length > 7)
            { this.userid = int.Parse(arr[7]); }
            
        }
    }
}
