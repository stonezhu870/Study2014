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
    public partial class Form4 : Form
    {
        int count = 0;
        int countwj = 0;
        int countcp = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //检查用户是否做出了选择
            var result = CheckUserSelected();

            if (result == false)
                return;
                       
            //电脑选择图片
            ComputerSelected();

            //判断玩家胜还是电脑胜
            CompareWin();

            count = count + 1;

            //计算各自的胜率
            CalcWinPercent();
        }

        /// <summary>
        /// 检查用户是否选择了图片
        /// </summary>
        private bool CheckUserSelected()
        {
            if (pictureBox1.BorderStyle != BorderStyle.None &&
                pictureBox2.BorderStyle != BorderStyle.None &&
                pictureBox3.BorderStyle != BorderStyle.None)
            {
                MessageBox.Show("请选择所出图片");
                return false;
            }

            return true;
        }

        private void ComputerSelected()
        {
            Random random = new Random();
            var computerindex = random.Next(1, 4);
            if (computerindex == 1)
            {
                pictureBox4.BorderStyle = BorderStyle.None;
                pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            }
            if (computerindex == 2)
            {
                pictureBox5.BorderStyle = BorderStyle.None;
                pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            }
            if (computerindex == 3)
            {
                pictureBox6.BorderStyle = BorderStyle.None;
                pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void CompareWin()
        {
            textBox1.Text = "";
            //比较
            if (pictureBox1.BorderStyle == BorderStyle.None &&
                pictureBox6.BorderStyle == BorderStyle.None)
            {
                textBox1.Text = "玩家胜";
            }
            if (pictureBox2.BorderStyle == BorderStyle.None &&
                pictureBox4.BorderStyle == BorderStyle.None)
            {
                textBox1.Text = "玩家胜";
            }
            if (pictureBox3.BorderStyle == BorderStyle.None &&
                pictureBox5.BorderStyle == BorderStyle.None)
            {
                textBox1.Text = "玩家胜";
            }
            if (pictureBox1.BorderStyle == BorderStyle.None &&
                pictureBox5.BorderStyle == BorderStyle.None)
            {
                textBox1.Text = "电脑胜";
            }
            if (pictureBox2.BorderStyle == BorderStyle.None &&
                pictureBox6.BorderStyle == BorderStyle.None)
            {
                textBox1.Text = "电脑胜";
            }

            if (pictureBox3.BorderStyle == BorderStyle.None &&
                pictureBox4.BorderStyle == BorderStyle.None)
            {
                textBox1.Text = "电脑胜";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "平局";
            }

            if (textBox1.Text == "玩家胜")
            {
                countwj = countwj + 1;
            }

            if (textBox1.Text == "电脑胜")
            {
                countcp = countcp + 1;
            }
        }

        private void CalcWinPercent()
        {
            textBox2.Text = "玩家胜率：" + Math.Round(((decimal)countwj / count), 3, MidpointRounding.AwayFromZero).ToString();
            
            textBox3.Text = "电脑胜率：" + Math.Round(((decimal)countcp / count), 3, MidpointRounding.AwayFromZero).ToString();
            textBox4.Text = "玩家胜局数：" + countwj.ToString();
            textBox5.Text = "电脑胜局数：" + countcp.ToString();
            textBox6.Text = "平局数：" + (count - countcp - countwj).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetUserSelectedImage(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetUserSelectedImage(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetUserSelectedImage(pictureBox3);
        }

        private void SetUserSelectedImage(PictureBox pictureBox)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;

            pictureBox.BorderStyle = BorderStyle.None;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = CheckUserSelected();

            if (result == false)
                return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ComputerSelected();
        }
    }
}
