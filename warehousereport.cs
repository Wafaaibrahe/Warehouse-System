using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEFullstacl
{
    public partial class warehousereport : Form
    {
         Model1 ent=new Model1();
        public warehousereport()
        {
            InitializeComponent();
        }

        private void warehousereport_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Warehouses)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str2 = comboBox1.Text;
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;


            sqlConnection1.Open();
            SqlDataReader dreader;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }

            this.sqlCommand1.CommandText = "select Warehouse.* ,Product.Name ,Product.Entrydate\r\nfrom Warehouse inner join Request\r\non Warehouse.Name=Request.Wname inner join Product\r\non Product.Code=Request.Pcode\r\nwhere Entrydate between '"+d2+"' and '"+d1+"' and Wname='"+str2+"'";
            dreader = sqlCommand1.ExecuteReader();
            while (dreader.Read())
            {

                string str = (dreader[0]).ToString() + "\t" + dreader[1].ToString() + "\t" + dreader[2].ToString() + "\t" + dreader[3].ToString() + dreader[4].ToString()  ;
                listBox1.Items.Add(str);

            }
            dreader.Close();
            sqlConnection1.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
