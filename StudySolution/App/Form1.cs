using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace App
{
    //此代理只能代理只有一个字符串参数和int返回值的方法
    //public delegate int MyDelegate(string s);

    public delegate void MyDelegate();

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<TranType> types = new List<TranType>();
            types.Add(new TranType(1, "支出"));
            types.Add(new TranType(2, "存入"));
            types.Add(new TranType(3, "开户"));
            types.Add(new TranType(4, "转账"));

            cbxTranType.DataSource = types;
            cbxTranType.ValueMember = "Id";
            cbxTranType.DisplayMember = "Name";

            dataGridView1.DataSource = types;

            //取值，selectedItem取出来的时候也是TranType对象
            //as 类型转换和括号转换的区别，as 转换失败时，返回值为null，括号强制转换转换失败时候会抛出异常
            var selectedItem = cbxTranType.SelectedItem as TranType;
            if (selectedItem != null)
            {
            }
        }

        public void ShowText()
        {
            textBox1.Text = "设置值";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var del = new MyDelegate(ShowText);

            var frm = new Form2(del);
            frm.Notice += frm_Notice;
            //frm.Notice -= frm_Notice1;

            frm.Show();
        }

        void frm_Notice(string message)
        {
            //\r\n回车换行符
            textBox1.Text = textBox1.Text + "\r\n" + message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                MessageBox.Show(item.ToString());
            }

            return;

            ThreadStart childref = new ThreadStart(Test3);
            Thread childThread = new Thread(childref);
            childThread.Start();

            //有参数的多线程
            ParameterizedThreadStart childref1 = new ParameterizedThreadStart(Test3);
            Thread childThread1 = new Thread(childref1);
            childThread1.Start();
        }

        private void Test3()
        {
            Thread.Sleep(1000 * 5);
        }

        private void Test3(object name)
        {
            Thread.Sleep(1000 * 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("asdf");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "\r\n" + "Resize";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADF");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var r = fontDialog1.ShowDialog();

            if (r == DialogResult.OK)
            {
                textBox1.Text = fontDialog1.Font.FontFamily.Name;
            }

            //var r = openFileDialog1.ShowDialog();

            //if (r == DialogResult.OK)
            //{
            //    textBox1.Text = openFileDialog1.FileName;
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    class TranType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TranType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
