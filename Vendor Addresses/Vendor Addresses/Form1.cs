using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vendor_Addresses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RetrevealBT_Click(object sender, EventArgs e)
        {
            const string connString = @"Server=DTPLAPTOP02;Database=AdventureWorks2012;Trusted_connection=True;";
            try
            {
                SqlConnection sqlConn = new SqlConnection(connString);
                SqlDataAdapter sqlDA = new SqlDataAdapter("VendorAddresses", sqlConn);
                DataTable dtVendor_Addresses = new DataTable();
                sqlDA.Fill(dtVendor_Addresses);
                dgVendorAddresses.DataSource = dtVendor_Addresses;
            }
            catch
            {
                MessageBox.Show("Something Went Horribly Wrong");
            }
        }
    }
}
