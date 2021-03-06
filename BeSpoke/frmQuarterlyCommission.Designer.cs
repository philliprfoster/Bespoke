namespace BeSpoke
{
    partial class frmQuarterlyCommission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSalespersonCommissionsList = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuarters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bndCommissionReport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalespersonCommissionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndCommissionReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalespersonCommissionsList
            // 
            this.dgvSalespersonCommissionsList.AllowUserToAddRows = false;
            this.dgvSalespersonCommissionsList.AllowUserToDeleteRows = false;
            this.dgvSalespersonCommissionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalespersonCommissionsList.Location = new System.Drawing.Point(12, 84);
            this.dgvSalespersonCommissionsList.MultiSelect = false;
            this.dgvSalespersonCommissionsList.Name = "dgvSalespersonCommissionsList";
            this.dgvSalespersonCommissionsList.ReadOnly = true;
            this.dgvSalespersonCommissionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalespersonCommissionsList.Size = new System.Drawing.Size(491, 275);
            this.dgvSalespersonCommissionsList.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(182, 380);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 35);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salespersons with Total Commissions for Quarter";
            // 
            // cmbQuarters
            // 
            this.cmbQuarters.FormattingEnabled = true;
            this.cmbQuarters.Location = new System.Drawing.Point(102, 19);
            this.cmbQuarters.Name = "cmbQuarters";
            this.cmbQuarters.Size = new System.Drawing.Size(133, 21);
            this.cmbQuarters.TabIndex = 10;
            this.cmbQuarters.SelectedIndexChanged += new System.EventHandler(this.cmbQuarters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quarter";
            // 
            // frmQuarterlyCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbQuarters);
            this.Controls.Add(this.dgvSalespersonCommissionsList);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Name = "frmQuarterlyCommission";
            this.Text = "Quarterly Salesperson Commission Report";
            this.Load += new System.EventHandler(this.frmQuarterlyCommission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalespersonCommissionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndCommissionReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalespersonCommissionsList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbQuarters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bndCommissionReport;
    }
}