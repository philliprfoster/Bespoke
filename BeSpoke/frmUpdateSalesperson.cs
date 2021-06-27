using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using DataAccess;

namespace BeSpoke
{
        // Form to update the currently selected Salesperson
    public partial class frmUpdateSalesperson : Form
    {
        public Salesperson salespersonUpdating = null;
        
        public frmUpdateSalesperson(Salesperson salespersonToUpdate)
        {
            salespersonUpdating = salespersonToUpdate;
            InitializeComponent();
        }

        private void frmUpdateSalesperson_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtAddress.Text = salespersonUpdating.Address;
                this.txtLastName.Text = salespersonUpdating.LastName;
                this.txtManager.Text = salespersonUpdating.Manager;
                this.txtFirstName.Text = salespersonUpdating.FirstName;
                this.txtPhone.Text = salespersonUpdating.Phone;
                this.txtStartDate.Text = string.Format("{0:MM/dd/yyyy}", salespersonUpdating.StartDate);
                this.chkTerminated.Checked = salespersonUpdating.TerminationDate != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTerminated_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                    // The Terminated checkbox allows for a null Termination_Date for the salesperson (they are still employed)
                lblTermDate.Enabled = chkTerminated.Checked;
                txtTermDate.Enabled = chkTerminated.Checked;
                txtTermDate.Text = (chkTerminated.Checked ? string.Format("{0:MM/dd/yyyy}", salespersonUpdating.TerminationDate) : "");
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
                    // Duplicate salespeople not allowed
                if (SalespersonIsDupe())
                {
                    MessageBox.Show("Another salesperson with this name already exists", "Duplicate Salesperson", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                    // Error check input data
                DateTime startDate;
                DateTime termDate = DateTime.Now;
                if (!DateTime.TryParse(txtStartDate.Text, out startDate))
                {
                    MessageBox.Show("Invalid Start Date", "Invalid Date", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (chkTerminated.Checked)
                {
                    if (!DateTime.TryParse(txtTermDate.Text, out termDate))
                    {
                        MessageBox.Show("Invalid Termination Date", "Invalid Date", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                salespersonUpdating.FirstName = txtFirstName.Text;
                salespersonUpdating.LastName = txtLastName.Text;
                salespersonUpdating.Address = txtAddress.Text;
                salespersonUpdating.Phone = txtPhone.Text;
                salespersonUpdating.StartDate = startDate;
                salespersonUpdating.TerminationDate = (chkTerminated.Checked ? (DateTime?) termDate : null);
                salespersonUpdating.Manager = txtManager.Text;
                SalesPeopleData.UpdateSalesperon(salespersonUpdating);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            // Check for dupe salesperson with same first and last name
        private bool SalespersonIsDupe()
        {
            bool isDupe = false;
            try
            {
                Salesperson salesperson = SalesPeopleData.GetSalesperson(txtFirstName.Text, txtLastName.Text);
                isDupe = (salesperson != null && salesperson.SalespersonID != salespersonUpdating.SalespersonID);
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
    }
}
