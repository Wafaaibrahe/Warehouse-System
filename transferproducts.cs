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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace projectEFullstacl
{
    public partial class transferproducts : Form
    {
        Model1 ent = new Model1();
        public transferproducts()
        {
            InitializeComponent();
        }

        private void transferproducts_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Products)
            {
                comboBox1.Items.Add(item.Code);
            }
            foreach (var item in ent.Warehouses)
            {
                comboBox3.Items.Add(item.Name);
            }
            foreach (var item in ent.Suppliers)
            {
                comboBox4.Items.Add(item.Name);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            Product prod = ent.Products.Find(int.Parse(comboBox1.Text));
            if (prod != null)
            {

                dateTimePicker1.Value = (DateTime)prod.Productiondate;
                dateTimePicker2.Value = (DateTime)prod.Expiredate;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Request req = new Request();
            if (textBox1.Text != "" && textBox2.Text != "" && dateTimePicker1.Text != "12/31/9998" && dateTimePicker2.Text != "12/31/9998" && dateTimePicker3.Text != "12/31/9998")
            {
                var r = ent.Requests.Find(int.Parse(textBox2.Text));
                if (r == null)
                {

                    req.Request_no = int.Parse(textBox2.Text);
                    req.Quantity = int.Parse(textBox1.Text);
                    req.Request_date = dateTimePicker3.Value;
                    req.Pcode = int.Parse(comboBox1.Text);
                    req.Wname = comboBox3.Text;
                    req.Sname = comboBox4.Text;
                    req.Type = "transfer";
                    ent.Requests.Add(req);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = "";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else { MessageBox.Show("this request number avalible !"); }



            }
            else { MessageBox.Show("there is an empty data!"); }
        }
    }
}
