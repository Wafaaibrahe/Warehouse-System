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
    
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            addwarehouse dbox= new addwarehouse();
            DialogResult DResult = dbox.ShowDialog();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedepartment dbox= new updatedepartment();
            DialogResult DResult = dbox.ShowDialog();




        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            addproduct dbox= new addproduct();
            DialogResult DResult = dbox.ShowDialog();
          




        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateproduct dbox=new updateproduct();
            DialogResult DResult = dbox.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addclient dbox=new addclient();
            DialogResult DResult = dbox.ShowDialog();

        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updateclient dbox=new updateclient();
            DialogResult DResult = dbox.ShowDialog();

        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            addsupplier dbox=new addsupplier();
            DialogResult DResult = dbox.ShowDialog();


        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            updatesupplier dbox= new updatesupplier();
            DialogResult DResult = dbox.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           Add_request dbox=new Add_request();
           DialogResult DResult = dbox.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            updaterequest dbox = new updaterequest();
            DialogResult DResult = dbox.ShowDialog();
        }

        

        private void transferProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transferproducts dbox = new transferproducts();
            DialogResult DResult = dbox.ShowDialog();
        }

        private void expiryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expiryreport dbox=new Expiryreport();
            DialogResult DResult = dbox.ShowDialog();
        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productreport dbox=new Productreport();
            DialogResult DResult = dbox.ShowDialog();

        }

        private void productsWarehouseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productwarehousereport dbox=new productwarehousereport();
            DialogResult DResult = dbox.ShowDialog();

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehousereport dbox= new warehousereport();
            DialogResult DResult = dbox.ShowDialog();

        }

        private void transferReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transferreport dbox=new transferreport();
            DialogResult DResult = dbox.ShowDialog();

        }
    }
}
