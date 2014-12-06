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
    public partial class Form5 : Form
    {
        int count = 0;
        int countwj = 0;
        int countcp = 0;

        private int timerTickCount = 0;

        //用于存放玩家选中的图片号，号码从1开始编, 0表示没有选，1表示选了剪刀，2表示选了石头，3表示选了布
        private Shape userSelectedImageNum = Shape.None;

        private Shape computerSelectedImageNum = Shape.None;

        //普通的边框样式
        private BorderStyle NormalBorderStyle = BorderStyle.None;

        //选中时的边框样式
        private BorderStyle SelectedBorderStyle = BorderStyle.FixedSingle;

        public Form5()
        {
            InitializeComponent();

            pictureBox1.BorderStyle = NormalBorderStyle;
            pictureBox2.BorderStyle = NormalBorderStyle;
            pictureBox3.BorderStyle = NormalBorderStyle;
            pictureBox4.BorderStyle = NormalBorderStyle;
            pictureBox5.BorderStyle = NormalBorderStyle;
            pictureBox6.BorderStyle = NormalBorderStyle;
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

            timer1.Start();
        }

        /// <summary>
        /// 检查用户是否选择了图片
        /// </summary>
        private bool CheckUserSelected()
        {
            if (userSelectedImageNum == Shape.None)
            {
                MessageBox.Show("请选择所出图片");
                return false;
            }
;
            return true;
        }

        private void ComputerSelected()
        {
            Random random = new Random();

            var computerindex = random.Next(1, 4);

            pictureBox4.BorderStyle = NormalBorderStyle;
            pictureBox5.BorderStyle = NormalBorderStyle;
            pictureBox6.BorderStyle = NormalBorderStyle;

            computerSelectedImageNum = (Shape)computerindex;

            if (computerindex == 1)
            {
                pictureBox4.BorderStyle = SelectedBorderStyle;
            }
            if (computerindex == 2)
            {
                pictureBox5.BorderStyle = SelectedBorderStyle;
            }
            if (computerindex == 3)
            {
                pictureBox6.BorderStyle = SelectedBorderStyle;
            }
        }

        private void CompareWin()
        {
            textBox1.Text = "";

            //判断谁赢或者平
            int result = CompareWin(userSelectedImageNum, computerSelectedImageNum);

            if(result == 1)
            {
                textBox1.Text = "玩家胜";
                countwj = countwj + 1;
            }
            else if(result == 0)
            {
                textBox1.Text = "平局";
            }
            else
            {
                textBox1.Text = "电脑胜";
                countcp = countcp + 1;
            }
        }

        /// <summary>
        /// 判断传入的图形哪边赢，如果返回1，那么a赢，0平，-1b赢
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private int CompareWin(Shape a, Shape b)
        {
            if (a == b)
                return 0;

            if(a == Shape.JianDao && b == Shape.Bu)
            {
                return 1;
            }

            if (a == Shape.ShiTou && b == Shape.JianDao)
            {
                return 1;
            }

            if (a == Shape.Bu && b == Shape.ShiTou)
            {
                return 1;
            }

            return -1;
        }

        private void CalcWinPercent()
        {
            textBox2.Text = "胜率：" + (Math.Round(((decimal)countwj / count), 2, MidpointRounding.AwayFromZero) * 100) + "%";

            textBox3.Text = "胜率：" + (Math.Round(((decimal)countcp / count), 2, MidpointRounding.AwayFromZero) * 100) + "%";
            
            textBox4.Text = "胜局数：" + countwj.ToString();

            textBox5.Text = "胜局数：" + countcp.ToString();

            textBox6.Text = "平局数：" + (count - countcp - countwj) + " / " + count;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userSelectedImageNum = Shape.JianDao;
            SetUserSelectedImage(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userSelectedImageNum = Shape.ShiTou;
            SetUserSelectedImage(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            userSelectedImageNum = Shape.Bu;
            SetUserSelectedImage(pictureBox3);
        }

        private void SetUserSelectedImage(PictureBox pictureBox)
        {
            pictureBox1.BorderStyle = NormalBorderStyle;
            pictureBox3.BorderStyle = NormalBorderStyle;
            pictureBox2.BorderStyle = NormalBorderStyle;

            pictureBox.BorderStyle = SelectedBorderStyle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = NormalBorderStyle;
            pictureBox2.BorderStyle = NormalBorderStyle;
            pictureBox3.BorderStyle = NormalBorderStyle;
            pictureBox4.BorderStyle = NormalBorderStyle;
            pictureBox5.BorderStyle = NormalBorderStyle;
            pictureBox6.BorderStyle = NormalBorderStyle;

            userSelectedImageNum = Shape.None;
            computerSelectedImageNum = Shape.None;
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timerTickCount++;

            ComputerSelected();

            if(timerTickCount == 20)
            {
                timerTickCount = 0;

                timer1.Stop();

                //判断玩家胜还是电脑胜
                CompareWin();

                count = count + 1;

                //计算各自的胜率
                CalcWinPercent();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
