using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeSpoke
{
        // Form for the quarterly salesperson commissions report
    public partial class frmQuarterlyCommission : Form
    {
        List<Quarters> rptQuarters;
        public frmQuarterlyCommission()
        {
            InitializeComponent();
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

        private void frmQuarterlyCommission_Load(object sender, EventArgs e)
        {
            try
            {
                rptQuarters = SalesQuarters.GetQuartersFromSales();
                cmbQuarters.DataSource = rptQuarters;
                cmbQuarters.DisplayMember = "Designation";
                cmbQuarters.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbQuarters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Quarters quarter = rptQuarters[cmbQuarters.SelectedIndex];
                List<SalespeopleWithCommissions> salespeopleWithCommissions =
                    SalesPeopleData.SalespeopleCommissionsList(quarter.StartDate, quarter.EndDate);
                bndCommissionReport.DataSource = salespeopleWithCommissions;
                dgvSalespersonCommissionsList.DataSource = bndCommissionReport;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
