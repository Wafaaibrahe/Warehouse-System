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
   
    public partial class transferreport : Form
    {
        Model1 ent = new Model1();
        public transferreport()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = comboBox1.Text;
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            sqlConnection1.Open();
            SqlDataReader dreader;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            this.sqlCommand1.CommandText = "select Request.*\r\nfrom Request\r\nwhere type='transfer' and Request_date between '" + d2 + "' and '" + d1 + "' and Wname= '" + str1 + "'";

            dreader = sqlCommand1.ExecuteReader();
            while (dreader.Read())
            {
                string str = ((int)dreader[0]).ToString() + "\t" + dreader[1].ToString() + "\t" + ((int)dreader[2]).ToString() + "\t" + dreader[3].ToString() + "\t" + ((int)dreader[4]).ToString() + "\t" + dreader[5].ToString() + "\t" + dreader[6].ToString() + "\t";

                listBox1.Items.Add(str);
            }
            dreader.Close();
            sqlConnection1.Close();









        }

        private void transferreport_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Warehouses)
            {
                comboBox1.Items.Add(item.Name);
            }
        }
    }
}
