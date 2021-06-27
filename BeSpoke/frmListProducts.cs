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
    // This form lists all the Products
    public partial class frmListProducts : Form
    {
        private List<Product> products;
        public Product selectedProduct = null;

        public frmListProducts(List<Product> products)
        {
            this.products = products;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value);
                selectedProduct = products.Where(x => x.ProductID == selectedID).First();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            try
            {
                bndProducts.DataSource = products;
                dgvProducts.DataSource = bndProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
