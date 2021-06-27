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
        // Form to update the currently selected product
    public partial class frmUpdateProduct : Form
    {
        public Product productUpdating = null;
        public frmUpdateProduct(Product productToUpdate)
        {
            productUpdating = productToUpdate;
            InitializeComponent();
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtName.Text = productUpdating.Name;
                this.txtMfg.Text = productUpdating.Manufacturer;
                this.txtStyle.Text = productUpdating.Style;
                this.txtPurchasePrice.Text = productUpdating.PurchasePrice.ToString();
                this.txtSalePrice.Text = productUpdating.SalePrice.ToString();
                this.txtQtyOnHand.Text = productUpdating.QtyOnHand.ToString();
                this.txtCommissionPct.Text = productUpdating.CommissionPercentage.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            // Check for product with same Name - dupes not allowed
        private bool ProductIsDupe()
        {
            bool isDupe = false;
            try
            {
                Product product = ProductsData.GetProduct(txtName.Text);
                isDupe = (product != null && product.ProductID != productUpdating.ProductID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isDupe;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                    // Duplicate products not allowed
                if (ProductIsDupe())
                {
                    MessageBox.Show("Another product with this name already exists", "Duplicate Product", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                    // Error check all the input data
                decimal purchasePrice;
                decimal salePrice;
                int qtyOnHand;
                decimal commissionPct;
                if (!decimal.TryParse(txtPurchasePrice.Text, out purchasePrice))
                {
                    MessageBox.Show("Invalid Purchase Price", "Invalid Purchase Price", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtSalePrice.Text, out salePrice))
                {
                    MessageBox.Show("Invalid Sale Price", "Invalid Sale Price", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtQtyOnHand.Text, out qtyOnHand))
                {
                    MessageBox.Show("Invalid Qty On Hand", "Invalid Quantity", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtCommissionPct.Text, out commissionPct))
                {
                    MessageBox.Show("Invalid Commission Pct", "Invalid Commission Pct", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                productUpdating.Name = txtName.Text;
                productUpdating.Manufacturer = txtMfg.Text;
                productUpdating.Style = txtStyle.Text;
                productUpdating.PurchasePrice = purchasePrice;
                productUpdating.SalePrice = salePrice;
                productUpdating.QtyOnHand = qtyOnHand;
                productUpdating.CommissionPercentage = commissionPct;

                ProductsData.UpdateProduct(productUpdating);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
