﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var form = new Form2(null);

            Application.Run(new Form7());
        }
    }
}
