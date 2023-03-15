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
    public partial class updateproduct : Form
    { 
        Model1 ent=new Model1();
        public updateproduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product p = ent.Products.Find(int.Parse(comboBox1.Text));
            if (p != null)
            {
                p.Name = textBox2.Text;
                p.Measure_unit = textBox3.Text;
                p.Productiondate = dateTimePicker1.Value;
                p.Expiredate = dateTimePicker2.Value;
                ent.SaveChanges();
                textBox2.Text = textBox3.Text = "";
                dateTimePicker1.Text = dateTimePicker2.Text = "12 / 31 / 9998";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void updateproduct_Load(object sender, EventArgs e)
        {
            foreach (var p in ent.Products)
            {
                comboBox1.Items.Add(p.Code);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = ent.Products.Find(int.Parse(comboBox1.Text));
            if (p != null)
            {
                textBox2.Text = p.Name;
                textBox3.Text = p.Measure_unit;
                dateTimePicker1.Value = (DateTime)p.Productiondate;
                dateTimePicker2.Value= (DateTime)p.Expiredate;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }
    }

