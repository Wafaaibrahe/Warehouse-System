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
    public partial class addwarehouse : Form
    {
        public Model1 ent = new Model1();

        public addwarehouse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Warehouse ware = new Warehouse();
            if (textBox1.Text!="" &&textBox2.Text!=""&& textBox3.Text!="")
            {
                Warehouse w = ent.Warehouses.Find(textBox1.Text);
                if (w==null)
                {
                    ware.Name = textBox1.Text;
                    ware.Address = textBox2.Text;
                    ware.Supervisor = textBox3.Text;
                    ent.Warehouses.Add(ware);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("sorry! avalible warehouse");
                }
            }
            else
              {
                MessageBox.Show("there is an empty data !");
              }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }





    }
}
