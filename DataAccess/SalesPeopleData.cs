using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace DataAccess
{
        // Data access class for listing Salespeople, and getting and updating a specific Salesperson, as well as listing salesperson commissions

        // This class is for listing salesperson commissions
    public class SalespeopleWithCommissions
    {
        public string Salesperson { get; set; }
        public string Manager { get; set; }
        public string Active { get; set; }
        public decimal totalCommission;
        public string TotalCommission
        {
            get
            {
                return string.Format("{0:0.00}", totalCommission);
            }
        }
    }
    public static class SalesPeopleData
    {
        public static List<Salesperson> List_Salespeople()
        {
            List<Salesperson> salesPeopleList = new List<Salesperson>();
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    salesPeopleList = bespoke.Salespersons.OrderBy(x => x.LastName).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesPeopleList;
        }

        public static Salesperson GetSalesperson(string firstName, string lastName)
        {
            Salesperson salesperson = null;
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    salesperson = bespoke.Salespersons.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesperson;
        }

        public static Salesperson GetSalesperson(int salespersonID)
        {
            Salesperson salesperson = null;
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    salesperson = bespoke.Salespersons.Where(x => x.SalespersonID == salespersonID).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesperson;
        }

        public static void UpdateSalesperon(Salesperson salespersonToUpdate)
        {
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    var updateSalesperson = bespoke.Salespersons.Where(x => x.SalespersonID == salespersonToUpdate.SalespersonID).FirstOrDefault();
                    updateSalesperson.FirstName = salespersonToUpdate.FirstName;
                    updateSalesperson.LastName = salespersonToUpdate.LastName;
                    updateSalesperson.Address = salespersonToUpdate.Address;
                    updateSalesperson.Phone = salespersonToUpdate.Phone;
                    updateSalesperson.StartDate = salespersonToUpdate.StartDate;
                    updateSalesperson.TerminationDate = salespersonToUpdate.TerminationDate;
                    updateSalesperson.Manager = salespersonToUpdate.Manager;
                    bespoke.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            // This gets a list of all the salespeople with their total sales commissions for a given date range
        public static List<SalespeopleWithCommissions> SalespeopleCommissionsList(DateTime startDate, DateTime endDate)
        {
            List<SalespeopleWithCommissions> spcList = new List<SalespeopleWithCommissions>();
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    List<SalesInfo> salesForDateRange = SalesData.List_Sales(startDate, endDate);
                    List<Salesperson> salespeople = SalesPeopleData.List_Salespeople();
                    spcList = (from a in salesForDateRange
                               from b in salespeople.Where(x => x.SalespersonID == a.salespersonID)
                               group new
                               {
                                   Salesperson = b.FirstName.Trim() + " " + b.LastName.Trim(),
                                   Manager = b.Manager,
                                   Active = (b.TerminationDate == null ? "Yes" : "No"),
                                   SalesCommission = a.salespersonCommission()
                               }
                               by new
                               {
                                   Salesperson = b.FirstName.Trim() + " " + b.LastName.Trim(),
                                   Manager = b.Manager,
                                   Active = (b.TerminationDate == null ? "Yes" : "No"),
                               }
                               into c
                               select new SalespeopleWithCommissions
                               {
                                   Salesperson = c.Key.Salesperson,
                                   Manager = c.Key.Manager,
                                   Active = c.Key.Active,
                                   totalCommission = c.Sum(x => x.SalesCommission)
                               }).ToList();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return spcList;
        }
    }
}
