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
        // This form lists all the salespeople
    public partial class frmListSalespeople : Form
    {
        private List<Salesperson> salespeople;
        public Salesperson selectedSalesperson;
        public frmListSalespeople(List<Salesperson> salespeopleList)
        {
            salespeople = salespeopleList;
            InitializeComponent();
        }

        private void frmListSalespeople_Load(object sender, EventArgs e)
        {
            try
            {
                bndSalespeople.DataSource = salespeople;
                dgvSalespeople.DataSource = bndSalespeople;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwSalespeople_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = Convert.ToInt32(dgvSalespeople.SelectedRows[0].Cells[0].Value);
                selectedSalesperson = salespeople.Where(x => x.SalespersonID == selectedID).First();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
