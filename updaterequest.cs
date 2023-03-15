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
    public partial class updaterequest : Form
    {
        Model1 ent = new Model1();
        public updaterequest()
        {
            InitializeComponent();
        }

        private void updaterequest_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Requests)
            {
                comboBox4.Items.Add(item.Request_no);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
           Request r = ent.Requests.Find(int.Parse(comboBox4.Text));
            if (r != null)
            {
                r.Quantity =int.Parse( textBox1.Text);
                r.Request_date = dateTimePicker1.Value;
                r.Pcode =int.Parse( comboBox1.Text);
                r.Wname = comboBox2.Text;
                r.Sname= comboBox3.Text;
                ent.SaveChanges();
                textBox1.Text = "";
                dateTimePicker1.Text  = "12 / 31 / 9998";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Request r = ent.Requests.Find(int.Parse(comboBox4.Text));
            if (r != null)
            {
              
                if (r.Type == "import")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                textBox1.Text = r.Quantity.ToString();
                dateTimePicker1.Value = (DateTime)r.Request_date;
                comboBox1.Text = r.Pcode.ToString();
                comboBox2.Text = r.Wname;
                comboBox3.Text = r.Sname;
            }
        }













    }
}
