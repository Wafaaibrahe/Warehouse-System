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
    public partial class updatedepartment : Form
    {
        Model1 ent=new Model1();
        public updatedepartment()
        {
            InitializeComponent();
        }
        private void updatedepartment_Load(object sender, EventArgs e)
        {

            foreach (var w in ent.Warehouses)
            {
                comboBox1.Items.Add(w.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Warehouse w = ent.Warehouses.Find(comboBox1.Text);
            if (w != null)
            {
                w.Address = textBox1.Text;
                w.Supervisor = textBox2.Text;
                ent.SaveChanges();
                textBox1.Text = textBox2.Text = "";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warehouse w = ent.Warehouses.Find(comboBox1.Text);
            if (w != null)
            {
                textBox1.Text = w.Address;
                textBox2.Text = w.Supervisor;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
