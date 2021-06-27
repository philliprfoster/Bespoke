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
    public partial class frmMain : Form
    {
        Salesperson currentSalesperson = null;
        Product currentProduct = null;
        Customer currentCustomer = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmSalespeopleList_Click(object sender, EventArgs e)
        {
            try
            {
                List<Salesperson> salespeople = SalesPeopleData.List_Salespeople();
                frmListSalespeople frmListSalespeople = new frmListSalespeople(salespeople);
                frmListSalespeople.ShowDialog();
                currentSalesperson = frmListSalespeople.selectedSalesperson;
                if (currentSalesperson != null)
                    txtCurrentSalesman.Text = currentSalesperson.FirstName.Trim() + " " + currentSalesperson.LastName.Trim();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmUpdateSelectedSalesperson_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSalesperson == null)
                {
                    MessageBox.Show("Select a salesperson from the Salespeople->List option first", "No salesperson selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                frmUpdateSalesperson updateSalesperson = new frmUpdateSalesperson(currentSalesperson);
                updateSalesperson.ShowDialog();
                currentSalesperson = updateSalesperson.salespersonUpdating;
                txtCurrentSalesman.Text = currentSalesperson.FirstName.Trim() + " " + currentSalesperson.LastName.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmUpdateSelectedProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProduct == null)
                {
                    MessageBox.Show("Select a product from the Products->List option first", "No product selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                frmUpdateProduct updateProduct = new frmUpdateProduct(currentProduct);
                updateProduct.ShowDialog();
                currentProduct = updateProduct.productUpdating;
                txtCurrentProduct.Text = currentProduct.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmProductsList_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = ProductsData.List_Products();
                frmListProducts listProducts = new frmListProducts(products);
                listProducts.ShowDialog();
                currentProduct = listProducts.selectedProduct;
                if (currentProduct != null)
                    txtCurrentProduct.Text = currentProduct.Name;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmCustomersList_Click(object sender, EventArgs e)
        {
            try
            {
                List<Customer> customers = CustomerData.List_Customers();
                frmListCustomers listCustomers = new frmListCustomers(customers);
                listCustomers.ShowDialog();
                currentCustomer = listCustomers.selectedCustomer;
                if (currentCustomer != null)
                    txtCurrentCustomer.Text = currentCustomer.FirstName.Trim() + " " + currentCustomer.LastName.Trim();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmSalesList_Click(object sender, EventArgs e)
        {
            try
            {
                List<SalesInfo> sales = SalesData.List_Sales();
                frmListSales listSales = new frmListSales(sales);
                listSales.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddSale addSale = new frmAddSale();
                addSale.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmQuarterlyCommissionReport_Click(object sender, EventArgs e)
        {
            try
            {
                frmQuarterlyCommission quarterlyCommission = new frmQuarterlyCommission();
                quarterlyCommission.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
