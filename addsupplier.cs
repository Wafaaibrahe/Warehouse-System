using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectEFullstacl
{
    public partial class addsupplier : Form
    {
        Model1 ent = new Model1();
        public addsupplier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier sup=new Supplier();
           
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != ""  )
            {
                Supplier s = ent.Suppliers.Find(textBox1.Text);
                if (s == null)
                {
                 
                    sup.Name = textBox1.Text;
                    sup.Mobile = int.Parse(textBox2.Text);
                    sup.Fax = int.Parse(textBox3.Text);
                    sup.Email = textBox4.Text;
                    sup.Website = textBox5.Text;
                    ent.Suppliers.Add(sup);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
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
                MessageBox.Show("the name and the mobile is required!");
            }









        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
