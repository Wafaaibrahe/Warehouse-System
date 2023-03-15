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
    public partial class updateclient : Form
    {

        Model1 ent = new Model1();
        public updateclient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Client cl=ent.Clients.Find(int.Parse(comboBox1.Text));
            if (cl != null)
            {
                cl.Name = textBox1.Text;
                cl.Mobile =int.Parse( textBox2.Text);
                cl.Fax = int.Parse(textBox3.Text);
                cl.Email=textBox4.Text;
                cl.Website=textBox5.Text;
                ent.SaveChanges();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text =  "";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client cl = ent.Clients.Find(int.Parse(comboBox1.Text));
            if (cl != null)
            {
                textBox1.Text = cl.Name;
                textBox2.Text = cl.Mobile.ToString();
                textBox3.Text = cl.Fax.ToString();
                textBox4.Text = cl.Email;
                textBox5.Text = cl.Website;

            }
        }

        private void updateclient_Load(object sender, EventArgs e)
        {
            foreach (var c in ent.Clients)
            {
                comboBox1.Items.Add(c.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
