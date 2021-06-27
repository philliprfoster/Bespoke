using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataModel;

namespace BeSpoke
{
        // This class holds all the data for a given report quarter
    public class Quarters
    {
        public int ID { get; set; }
        public string Designation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

        // This class calculates the different quarters for all sales data
    public static class SalesQuarters
    {
        public static List<Quarters> GetQuartersFromSales()
        {
            List<Quarters> quarters = new List<Quarters>();
            try
            {
                int quarterCnt = 0;
                List<SalesInfo> allSales = SalesData.List_Sales();
                foreach (SalesInfo sales in allSales)
                {
                    DateTime startDate;
                    DateTime endDate;
                    DetermineQuarterDateRange(sales.SalesDate, out startDate, out endDate);
                    string designation = DetermineQuarterDesignation(startDate);
                    Quarters quarter = quarters.Where(x => x.Designation == designation).FirstOrDefault();
                    if (quarter == null)
                    {
                        quarterCnt++;
                        quarters.Add(new Quarters { ID = quarterCnt, StartDate = startDate, EndDate = endDate, Designation = designation });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return quarters;
        }

        private static string DetermineQuarterDesignation(DateTime startDate)
        {
            string designation = "";
            try
            {
                int startMonth = startDate.Month;
                int startYear = startDate.Year;
                switch (startMonth)
                {
                    case 1:
                    {
                        designation = "Q1";
                        break;
                    }
                    case 4:
                    {
                        designation = "Q2";
                        break;
                    }
                    case 7:
                    {
                        designation = "Q3";
                        break;
                    }
                    case 10:
                    {
                        designation = "Q4";
                        break;
                    }
                }
                designation += startYear.ToString().Substring(2, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return designation;
        }

        private static void DetermineQuarterDateRange(DateTime date, out DateTime startDate, out DateTime endDate)
        {
            startDate = DateTime.Now;
            endDate = DateTime.Now;
            try
            {
                int month = date.Month;
                int year = date.Year;
                if (month >= 1 && month <= 3)
                {
                    startDate = Convert.ToDateTime("01/01/" + year.ToString());
                    endDate = Convert.ToDateTime("03/31/" + year.ToString());
                }
                if (month >= 4 && month <= 6)
                {
                    startDate = Convert.ToDateTime("04/01/" + year.ToString());
                    endDate = Convert.ToDateTime("06/30/" + year.ToString());
                }
                if (month >= 7 && month <= 9)
                {
                    startDate = Convert.ToDateTime("07/01/" + year.ToString());
                    endDate = Convert.ToDateTime("09/30/" + year.ToString());
                }
                if (month >= 10 && month <= 12)
                {
                    startDate = Convert.ToDateTime("10/01/" + year.ToString());
                    endDate = Convert.ToDateTime("12/31/" + year.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
