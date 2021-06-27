using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataModel;

namespace DataAccess
{
        // Data access class for listing Products, and getting and updating a specific Product
    public static class ProductsData
    {
        public static List<Product> List_Products()
        {
            List<Product> productList = new List<Product>();
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    productList = bespoke.Products.OrderBy(x => x.Name).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return productList;
        }

        public static Product GetProduct(string name)
        {
            Product product = null;
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    product = bespoke.Products.Where(x => x.Name == name).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        public static Product GetProduct(int productID)
        {
            Product product = null;
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    product = bespoke.Products.Where(x => x.ProductID == productID).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        public static void UpdateProduct(Product productToUpdate)
        {
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    var updateProduct = bespoke.Products.Where(x => x.ProductID == productToUpdate.ProductID).FirstOrDefault();
                    updateProduct.Name = productToUpdate.Name;
                    updateProduct.Manufacturer = productToUpdate.Manufacturer;
                    updateProduct.Style = productToUpdate.Style;
                    updateProduct.PurchasePrice = productToUpdate.PurchasePrice;
                    updateProduct.SalePrice = productToUpdate.SalePrice;
                    updateProduct.QtyOnHand = productToUpdate.QtyOnHand;
                    updateProduct.CommissionPercentage = productToUpdate.CommissionPercentage;
                    bespoke.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
