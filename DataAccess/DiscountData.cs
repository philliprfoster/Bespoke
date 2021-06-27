using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace DataAccess
{
        //  Data access class for getting Discount records
    public static class DiscountData
    {
        public static List<Discount> List_Discounts()
        {
            List<Discount> discounts = new List<Discount>();
            try
            {
                using (BespokeEntities bespoke = new BespokeEntities())
                {
                    discounts = bespoke.Discounts.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return discounts;
        }
    }
}
