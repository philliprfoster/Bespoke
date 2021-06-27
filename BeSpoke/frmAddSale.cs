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
    //  This form allows you to add a new Sale record.  It uses the List screens for salesperson, customer, and product to select them.
    public partial class frmAddSale : Form
    {
        Customer selectedCustomer = null;
        Salesperson selectedSalesperson = null;
        Product selectedProduct = null;
        public frmAddSale()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            try
            {
                frmListProducts listProducts = new frmListProducts(ProductsData.List_Products());
                listProducts.ShowDialog();
                selectedProduct = listProducts.selectedProduct;
                txtProduct.Text = selectedProduct.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectSalesperson_Click(object sender, EventArgs e)
        {
            try
            {
                frmListSalespeople listSalespeople = new frmListSalespeople(SalesPeopleData.List_Salespeople());
                listSalespeople.ShowDialog();
                selectedSalesperson = listSalespeople.selectedSalesperson;
                txtSalesperson.Text = selectedSalesperson.FirstName + " " + selectedSalesperson.LastName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmListCustomers listCustomers = new frmListCustomers(CustomerData.List_Customers());
                listCustomers.ShowDialog();
                selectedCustomer = listCustomers.selectedCustomer;
                txtCustomer.Text = selectedCustomer.FirstName + " " + selectedCustomer.LastName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct == null)
                {
                    MessageBox.Show("You must select a Product", "Product not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (selectedSalesperson == null)
                {
                    MessageBox.Show("You must select a Salesperson", "Salesperson not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (selectedCustomer == null)
                {
                    MessageBox.Show("You must select a Customer", "Customer not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime salesDate;
                if (!DateTime.TryParse(txtSalesDate.Text, out salesDate))
                {
                    MessageBox.Show("Invalid Sales Date", "Invalid Date", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                SalesData.AddSale(selectedProduct.ProductID, selectedCustomer.CustomerID, selectedSalesperson.SalespersonID, salesDate);
                MessageBox.Show("Sale entry successfully added!", "Sale added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
