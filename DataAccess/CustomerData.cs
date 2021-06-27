using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace DataAccess
{
        // Data access class for listing Customers, and getting and updating a specific Customer
    public static class CustomerData
    {
        public static List<Customer> List_Customers()
        {
            List<Customer> customerList = new List<Customer>();
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    customerList = bespoke.Customers.OrderBy(x => x.LastName).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customerList;
        }

        public static Customer GetCustomer(string firstName, string lastName)
        {
            Customer customer = null;
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    customer = bespoke.Customers.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customer;
        }

        public static Customer GetCustomer(int customerID)
        {
            Customer customer = null;
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    customer = bespoke.Customers.Where(x => x.CustomerID == customerID).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customer;
        }

        public static void UpdateCustomer(Customer customerToUpdate)
        {
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    var updateCustomer = bespoke.Customers.Where(x => x.CustomerID == customerToUpdate.CustomerID).FirstOrDefault();
                    updateCustomer.FirstName = customerToUpdate.FirstName;
                    updateCustomer.LastName = customerToUpdate.LastName;
                    updateCustomer.Address = customerToUpdate.Address;
                    updateCustomer.Phone = customerToUpdate.Phone;
                    updateCustomer.StartDate = customerToUpdate.StartDate;

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
