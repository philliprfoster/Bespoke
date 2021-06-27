using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace DataAccess
{
        // Data access classes for listing Sales, and adding a new Sale

        // This class is for the Sales Listing, since it only lists some of the fields from the Sales table, and it also has derived properties that
        // are listed
    public class SalesInfo
    {
        public int salesID;
        public int productID;
        public decimal salesPrice;
        public decimal commmissionPercentage;
        public int salespersonID;
        public string Product { get; set; }
        public string Salesperson { get; set; }
        public string Customer { get; set; }
        public DateTime SalesDate { get; set; }

            // Price is a string so it will be correctly formatted in the sales listing
        public string Price
        {
            get
            {
                return string.Format("{0:0.00}", CalculatePrice());
            }
        }

        private decimal CalculatePrice()
        {
            decimal price = 0.0m;
            try
            {
                price = salesPrice;
                // Check and see if there are any current Discounts running for this product, and adjust the sales price accordingly
                Discount discount = DiscountData.List_Discounts().Where(x => x.BeginDate <= this.SalesDate && x.EndDate >= this.SalesDate
                    && x.ProductID == productID).FirstOrDefault();
                if (discount != null)
                    price *= 1.0m - ((decimal)(discount.DiscountPct) / 100.0m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return price;
        }

        public decimal salespersonCommission()
        {
            decimal salespersonCommission = 0.0m;
            try
            {
                decimal price = this.CalculatePrice();
                decimal commission = ((decimal)(commmissionPercentage) / 100.0m);
                salespersonCommission = price * commission;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salespersonCommission;
        }

        // SalespersonCommission is a string so it will be correctly formatted in the sales listing
        public string SalespersonCommission
        {
            get
            {

                return string.Format("{0:0.00}", salespersonCommission());
            }
        }
    }
    public static class SalesData
    {
            // Sales list can be filtered by start date and end date
        public static List<SalesInfo> List_Sales(DateTime? startDate = null, DateTime? endDate = null)
        {
            List<SalesInfo> salesList = new List<SalesInfo>();
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    salesList = (from a in bespoke.Sales
                                from b in bespoke.Products.Where(x => x.ProductID == a.ProductID)
                                from c in bespoke.Salespersons.Where(x => x.SalespersonID == a.SalespersonID)
                                from d in bespoke.Customers.Where(x => x.CustomerID == a.CustomerID)
                                orderby a.SalesDate 
                                select new SalesInfo
                                {
                                    salesID = a.SalesID,
                                    Product = b.Name,
                                    productID = b.ProductID,
                                    Salesperson = c.FirstName.Trim() + " " + c.LastName.Trim(),
                                    salespersonID = c.SalespersonID,
                                    Customer = d.FirstName.Trim() + " " + d.LastName.Trim(),
                                    SalesDate = (DateTime)a.SalesDate,
                                    salesPrice = (decimal)b.SalePrice,
                                    commmissionPercentage = (decimal)b.CommissionPercentage
                                }).ToList();
                    if (startDate != null && endDate != null)
                        salesList = salesList.Where(x => x.SalesDate >= startDate && x.SalesDate <= endDate).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesList;
        }

        public static Sale AddSale(int productID, int salespersonID, int customerID, DateTime salesDate)
        {
            Sale newSale = null;
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    newSale = new Sale();
                    newSale.ProductID = productID;
                    newSale.SalespersonID = salespersonID;
                    newSale.CustomerID = customerID;
                    newSale.SalesDate = salesDate;
                    bespoke.Sales.Add(newSale);
                    bespoke.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return newSale;
        }
    }
}
