using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Form7 : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
   
        public Form7()
        {
            InitializeComponent();

        }
        List<Commodity> commodities = new List<Commodity>();
        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
            this.textBox1.Text = this.openFileDialog.FileName;
            StreamReader fileStream = new StreamReader(this.openFileDialog.FileName, Encoding.UTF8);
            var fileData = fileStream.ReadToEnd();
            fileStream.Close();
            var fileLines = fileData.Split(new char[2]{'\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var line in fileLines)
            {
                var items = line.Split(',');

                Commodity model = new Commodity(
                     items[0],
                     items[1],
                     items[4],
                     int.Parse(items[2]),
                     items[3]
                    );

                commodities.Add(model);

            }
 
      
            dataGridView1.DataSource = commodities;
        }
        
    
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            List<Commodity> searchContent = new List<Commodity>();
              
            foreach (var product in commodities)
            {
                var validateOk = true;
               
                if (string.IsNullOrEmpty(txtDesc.Text) == false)
                {
                    validateOk = product.ProductDescription.Contains(txtDesc.Text);
                }

                if (validateOk == true)
                {
                    if (string.IsNullOrEmpty(txtPriceMin.Text) == false)
                    {
                        validateOk = product.Commodityprice >= int.Parse(txtPriceMin.Text);
                    }
                }

                if (validateOk == true)
                {
                    if (string.IsNullOrEmpty(txtPriceMax.Text) == false)
                    {
                        validateOk = product.Commodityprice <= int.Parse(txtPriceMax.Text);
                    }
                }
                
                if (validateOk == true)
                {
                    searchContent.Add(product);
           
                }
               

                
     

                txtCount.Text = searchContent.Count().ToString();

                //方法二
                //if (string.IsNullOrEmpty(txtDesc.Text) == false)
                //{
                //    if (product.ProductDescription.Contains(txtDesc.Text) == false)
                //    {
                //        continue;
                //    }
                //}


                //if (string.IsNullOrEmpty(txtPriceMin.Text) == false)
                //{
                //    if (product.Commodityprice < int.Parse(txtPriceMin.Text))
                //    {
                //        continue;
                //    }
                //}


                //if (string.IsNullOrEmpty(txtPriceMax.Text) == false)
                //{
                //    if (product.Commodityprice > int.Parse(txtPriceMax.Text))
                //    {
                //        continue;
                //    }
                //}
               
                //searchContent.Add(product);
                
            }
     
            dataGridView1.DataSource = searchContent;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDesc.Text = " ";
            txtPriceMax.Text = " ";
            txtPriceMin.Text =  " ";
            txtCount.Text = "";
            dataGridView1.DataSource = commodities;
        }
    }
}





