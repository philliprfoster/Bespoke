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
        // This form lists all the current sales
    public partial class frmListSales : Form
    {
        private List<SalesInfo> sales;
        private List<SalesInfo> allSales;
        public frmListSales(List<SalesInfo> salesList)
        {
            allSales = salesList;
            InitializeComponent();
        }

            // Button that user uses to filter sales by startdate and enddate
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? startDate;
                DateTime? endDate;
                DateTime parseDate;
                if (!DateTime.TryParse(txtStartDate.Text, out parseDate))
                {
                    startDate = null;
                    txtStartDate.Text = "";
                }
                else
                    startDate = parseDate;
                if (!DateTime.TryParse(txtEndDate.Text, out parseDate))
                {
                    endDate = null;
                    txtEndDate.Text = "";
                }
                else
                    endDate = parseDate;
                    // It simply filters the allSales List so the sales don't have to be reloaded every time 
                if (startDate != null & endDate != null)
                    sales = allSales.Where(x => x.SalesDate >= startDate && x.SalesDate <= endDate).ToList();
                else
                    sales = allSales;
                bndSales.DataSource = sales;
                dgvSales.DataSource = bndSales;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListSales_Load(object sender, EventArgs e)
        {
            try
            {
                sales = allSales;
                bndSales.DataSource = sales;
                dgvSales.DataSource = bndSales;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            // Clear the date range and list ALL sales
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            { 
                txtStartDate.Text = "";
                txtEndDate.Text = "";
                sales = allSales;
                bndSales.DataSource = sales;
                dgvSales.DataSource = bndSales;
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
