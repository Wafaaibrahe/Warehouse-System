using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEFullstacl
{
    public partial class addproduct : Form
    {
        Model1 ent=new Model1();
        public addproduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Product prod=new Product();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && dateTimePicker1.Text != "12/31/9998" && dateTimePicker2.Text != "12/31/9998" && dateTimePicker3.Text != "12/31/9998")
            {
                Product p = ent.Products.Find(int.Parse(textBox1.Text));
                if (p== null)
                {
                    prod.Code = int.Parse(textBox1.Text);
                    prod.Name = textBox2.Text;
                    prod.Measure_unit = textBox3.Text;
                    prod.Productiondate = dateTimePicker1.Value;
                    prod.Expiredate= dateTimePicker2.Value;
                    prod.Entrydate = dateTimePicker3.Value;
                    ent.Products.Add(prod);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                    dateTimePicker1.Text = dateTimePicker2.Text = "12/31/9998";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("sorry! avalible products");
                }
            }
            else
            {
                MessageBox.Show("there is an empty data !");
            }

           
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
