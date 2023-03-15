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
    public partial class addclient : Form
    {
        Model1 ent = new Model1();
        public addclient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Client cl=new Client();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text !="" && textBox4.Text!="" &&textBox5.Text!="" && textBox6.Text!="")
            {
                Client c = ent.Clients.Find(int.Parse(textBox1.Text));
                if (c == null)
                {
                    cl.Id = int.Parse(textBox1.Text);
                    cl.Name = textBox2.Text;
                    cl.Mobile = int.Parse(textBox3.Text);
                    cl.Fax= int.Parse(textBox4.Text);
                    cl.Email = textBox5.Text;
                    cl.Website=textBox6.Text;
                    ent.Clients.Add(cl);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = textBox3.Text =textBox4.Text=textBox5.Text=textBox6.Text= "";
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
                MessageBox.Show("empty data!");
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
