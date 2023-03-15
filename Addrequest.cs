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
    public partial class Add_request : Form
    {
        Model1 ent = new Model1();
        public Add_request()
        {
            InitializeComponent();
        }

        private void Add_request_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Products)
            {
                comboBox1.Items.Add(item.Code);
            }
            foreach (var item in ent.Warehouses)
            {
                comboBox2.Items.Add(item.Name);
            }
            foreach (var item in ent.Suppliers)
            {
                comboBox3.Items.Add(item.Name);
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Request req=new Request();
            if (textBox1.Text != "" && textBox2.Text != "" &&dateTimePicker1.Text != "12/31/9998")
            {
                var r = ent.Requests.Find(int.Parse(textBox1.Text));
                if (r == null)
                {
                    if (radioButton1.Checked==true )
                    {
                        req.Type = radioButton1.Text;
                    }
                    else
                    {
                        req.Type = radioButton2.Text;
                    }
                 req.Request_no = int.Parse(textBox1.Text);
                 req.Quantity= int.Parse(textBox2.Text);
                 req.Request_date = dateTimePicker1.Value;
                 req.Pcode = int.Parse(comboBox1.Text);
                 req.Wname = comboBox2.Text;
                 req.Sname=comboBox3.Text;
                    ent.Requests.Add(req);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = "";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("sorry! avalible request!");
                }
            }
            else
            {
                MessageBox.Show("empty data!");
            }













        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
