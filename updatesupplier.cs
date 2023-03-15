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
    public partial class updatesupplier : Form
    {
        Model1 ent = new Model1();
        public updatesupplier()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier sup= ent.Suppliers.Find(comboBox1.Text);
            if (sup != null)
            {
                
                textBox1.Text = sup.Mobile.ToString();
                textBox2.Text = sup.Fax.ToString();
                textBox3.Text = sup.Email;
                textBox4.Text = sup.Website;

            }
        }

        private void updatesupplier_Load(object sender, EventArgs e)
        {
            foreach (var s in ent.Suppliers)
            {
                comboBox1.Items.Add(s.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Supplier sup=ent.Suppliers.Find(comboBox1.Text);
            if (sup != null)
            {
               
                sup.Mobile = int.Parse(textBox1.Text);
                sup.Fax = int.Parse(textBox2.Text);
                sup.Email = textBox3.Text;
                sup.Website = textBox4.Text;
                ent.SaveChanges();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }
    }
}
