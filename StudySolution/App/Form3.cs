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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /**
         * 红球区
         * 从1-33生成1个随机数
         * 从1-33中生成1个随机数（不能和第一个数重复）
         * 从1-33中生成1个随机数（不能和前面两个重复）
         * 从1-33中生成1个随机数（不能和前面三个重复）
         * 从1-33中生成1个随机数（不能和前面四个重复）
         * 从1-33中生成1个随机数（不能和前面五个重复）
         * 篮球区
         * 从1-16中生成1个随机数
         * 红球区和篮球区拼接到一起，显示在界面上
         */

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            //红球区
            var red1 = rnd.Next(1, 34);

            var red2 = rnd.Next(1, 34);

            if (red2 == red1)
            {
                for (var i = 0; i < 10000; i++)
                {
                    red2 = rnd.Next(1, 34);

                    if (red2 == red1)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            var red3 = rnd.Next(1, 34);

            if (red3 == red1 || red3 == red2)
            {
                for (var i = 0; i < 10000; i++)
                {
                    red3 = rnd.Next(1, 34);

                    if (red3 == red1 || red3 == red2)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            var red4 = rnd.Next(1, 34);

            if (red4 == red1 || red4 == red2 || red4 == red3)
            {
                for (var i = 0; i < 10000; i++)
                {
                    red4 = rnd.Next(1, 34);

                    if ((red4 == red1 || red4 == red2 || red4 == red3))
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            var red5 = rnd.Next(1, 34);

            if (red5 == red1 || red5 == red2 || red5 == red3 || red5 == red4)
            {
                for (var i = 0; i < 10000; i++)
                {
                    red5 = rnd.Next(1, 34);

                    if (red5 == red1 || red5 == red2 || red5 == red3 || red5 == red4)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            var red6 = rnd.Next(1, 34);

            if (red6 == red1 || red6 == red2 || red6 == red3 || red6 == red4 || red6 == red5)
            {
                for (var i = 0; i < 10000; i++)
                {
                    red6 = rnd.Next(1, 34);

                    if (red6 == red1 || red6 == red2 || red6 == red3 || red6 == red4 || red6 == red5)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //篮球
            var blue1 = rnd.Next(1, 17);

            textBox1.Text = red1.ToString() + " " + red2.ToString()
                + " " + red3.ToString()
                + " " + red4.ToString()
                + " " + red5.ToString()
                + " " + red6.ToString()
                + "    " + blue1;
        }



     
        private int GetNum(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var redArray = new int[6];

            Random rnd = new Random(unchecked((int)DateTime.Now.Ticks));

            for (var i = 0; i < 6; i++ )
            {
                redArray[i] = CreateNewBall(rnd, 34, redArray);
            }

            //篮球
            var blue1 = CreateNewBall(rnd, 17, null);

            //var result = "";

            //for (var i = 0; i < redArray.Length; i++)
            //{
            //    result = result + redArray[i] + " ";
            //}

            textBox1.Text = String.Join(" ", redArray) + "    " + blue1;
        }

        private int CreateNewBall(Random rnd, int max, int[] limit)
        {
            var ball = 0;

            for (var i = 0; i < 10000; i++)
            {
                ball = rnd.Next(1, max);

                if (limit != null)
                {
                    if (!limit.Contains(ball))
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return ball;
        }
    }
}
