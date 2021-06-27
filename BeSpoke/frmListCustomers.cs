using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataModel;

namespace BeSpoke
{
    // This form lists all the customers
    public partial class frmListCustomers : Form
    {
        private List<Customer> customers;
        public Customer selectedCustomer;
        public frmListCustomers(List<Customer> customerList)
        {
            customers = customerList;
            InitializeComponent();
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                bndCustomers.DataSource = customers;
                dgvCustomers.DataSource = bndCustomers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
                selectedCustomer = customers.Where(x => x.CustomerID == selectedID).First();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
