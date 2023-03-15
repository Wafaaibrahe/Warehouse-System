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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectEFullstacl
{
    public partial class productwarehousereport : Form
    {
        Model1 ent=new Model1();
        public productwarehousereport()
        {
            InitializeComponent();
        }

        private void productwarehousereport_Load(object sender, EventArgs e)
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

            this.sqlCommand1.CommandText = "select Pcode, Name  ,wname , entrydate from Request inner join Product \r\non Product.Code=Request.Pcode\r\nwhere Entrydate between '"+d2+"' and '"+d1+"' and Wname='"+str2+"'" ;
            dreader = sqlCommand1.ExecuteReader();
            while (dreader.Read())
            {

                string str = ((int)dreader[0]).ToString() + "\t" + dreader[1].ToString() + "\t" + dreader[2].ToString() + "\t" + dreader[3].ToString() + dreader[3].ToString();
                listBox1.Items.Add(str);

            }
            dreader.Close();
            sqlConnection1.Close();







        }
    }
}
