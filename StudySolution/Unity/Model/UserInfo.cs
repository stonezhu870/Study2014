using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSolution.Model
{
    public class UserInfo
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string Pid { get; set; }

        public string TelPhone { get; set; }

        public string Address { get; set; }

        public DateTime CreateTime { get; set; }

        public string SelfToString()
        {
            //params 用这个声明的数组参数，可以用逗号一个一个的传入方法
            
            //所有数据监测合格，写入到文件中
            return string.Format("{0},{1},{2},{3},{4},{5}",
                              this.Id,
                              this.CustomerName.Replace(",", "$$_$$"),
                              this.Pid.Replace(",", "$$_$$"),
                              this.TelPhone.Replace(",", "$$_$$"),
                              this.Address.Replace(",", "$$_$$").Replace("\r\n","$$__$$"),
                              this.CreateTime
                );
        }

        public UserInfo()
        {
            
        }

        public UserInfo(string data)
        {
            var arr = data.Split(',');

            this.Id = int.Parse(arr[0]);
            this.CustomerName = arr[1].Replace("$$_$$", ",");
            this.Pid = arr[2].Replace("$$_$$", ",");
            this.TelPhone = arr[3].Replace("$$_$$", ",");
            this.Address = arr[4].Replace("$$_$$", ",").Replace("$$__$$", "\r\n");
            this.CreateTime = Convert.ToDateTime(arr[5]);
        }
    }
}
