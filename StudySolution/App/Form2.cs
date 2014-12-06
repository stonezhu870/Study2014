using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        public event App.Delegates.NoticeHandler Notice;

        private void OnNotice(string message)
        {
            if (Notice != null)
                Notice(message);
        }

        private MyDelegate thisDelegate = null;

        public Form2(MyDelegate mydelegate)
        {
            InitializeComponent();

            thisDelegate = mydelegate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thisDelegate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var num = Convert.ToInt32(textBox1.Text);

            if (num > 100)
                OnNotice("当前数字太大，是" + num);
        }
    }
}
