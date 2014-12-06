using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace ATMSolution.Model
{
    public class FileHelper
    {
        public static string RootPath
        {
            get
            {
                if (HttpContext.Current == null) //不是网页
                {
                    return RootPath;
                }
                else
                {
                    return HttpRuntime.AppDomainAppPath.ToString();
                }
            }
        }


        public static List<ATMSolution.Model.UserInfo> GetUserInfos()
        {
            var filePath = RootPath + "//Data//UserInfo//";

            var userInfos = new List<ATMSolution.Model.UserInfo>();

            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

            var files = directoryInfo.GetFiles("*.d");

            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                   var fileContent = File.ReadAllText(file.FullName);

                   var userinfo = new ATMSolution.Model.UserInfo(fileContent);

                   userInfos.Add(userinfo);
                }
            }

            return userInfos;
        }

        public static void AppendUserInfo(int userId, string data)
        {
            var filePath = RootPath + "//Data//UserInfo//" + userId + ".d";

            //写入到文件
            File.WriteAllText(filePath, data);
        }

        public static List<TransInfo> GetTransList()
        {
            var filePath = RootPath + "//Data//TransInfo//";
            
            var list = new List<TransInfo>();

            if (!Directory.Exists(filePath))
                return list;

            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

            var files = directoryInfo.GetFiles("*.d");

            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    var fileContent = File.ReadAllText(file.FullName);

                    var userinfo = new TransInfo(fileContent);

                    list.Add(userinfo);
                }
            }

            return list;
        }

        public static void AppendTransInfo(int id, string data)
        {
            var dir = RootPath + "//Data//TransInfo//";

            var filePath = dir + id + ".d";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            //写入到文件
            File.WriteAllText(filePath, data);
        }

        public static List<CardInfo> GetCardInfo()
        {
            var filePath = RootPath + "//Data//CardInfo//";

            var list = new List<CardInfo>();

            if (!Directory.Exists(filePath))
                return list;

            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

            var files = directoryInfo.GetFiles("*.d");

            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    var fileContent = File.ReadAllText(file.FullName);

                    var userinfo = new CardInfo(fileContent);

                    list.Add(userinfo);
                }
            }

            return list;
        }

        public static void AppendCardInfo(int id, string data)
        {
            var dir = RootPath + "//Data//CardInfo//";

            var filePath = dir + id + ".d";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            //写入到文件
            File.WriteAllText(filePath, data);
        }
    }
}
