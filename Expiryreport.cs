
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
    public partial class Expiryreport : Form
    {
        Model1 ent = new Model1();
        public Expiryreport()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            string str2 = textBox1.Text;
            sqlConnection1.Open();
            SqlDataReader dreader;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }

            this.sqlCommand1.CommandText = "SELECT Product.* FROM Product WHERE Expiredate >GETDATE()  and DATEDIFF(day, GETDATE(), Expiredate) <"+str2;
            dreader = sqlCommand1.ExecuteReader();
            while (dreader.Read())
            {

                string str = ((int)dreader[0]).ToString() + "\t" + dreader[1].ToString() + "/t" + dreader[4].ToString();
                listBox1.Items.Add(str);

            }
            dreader.Close();
            sqlConnection1.Close();





        }
    }
}
