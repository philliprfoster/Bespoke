namespace BeSpoke
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.salespeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalespeopleList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateSelectedSalesperson = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductsList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateSelectedProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomersList = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalesList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSale = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentSalesman = new System.Windows.Forms.TextBox();
            this.txtCurrentProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tsmQuarterlyCommissionReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.salespeopleToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmQuit
            // 
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(97, 22);
            this.tsmQuit.Text = "Quit";
            this.tsmQuit.Click += new System.EventHandler(this.tsmQuit_Click);
            // 
            // salespeopleToolStripMenuItem
            // 
            this.salespeopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSalespeopleList,
            this.tsmUpdateSelectedSalesperson,
            this.tsmQuarterlyCommissionReport});
            this.salespeopleToolStripMenuItem.Name = "salespeopleToolStripMenuItem";
            this.salespeopleToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.salespeopleToolStripMenuItem.Text = "Salespeople";
            // 
            // tsmSalespeopleList
            // 
            this.tsmSalespeopleList.Name = "tsmSalespeopleList";
            this.tsmSalespeopleList.Size = new System.Drawing.Size(231, 22);
            this.tsmSalespeopleList.Text = "List";
            this.tsmSalespeopleList.Click += new System.EventHandler(this.tsmSalespeopleList_Click);
            // 
            // tsmUpdateSelectedSalesperson
            // 
            this.tsmUpdateSelectedSalesperson.Name = "tsmUpdateSelectedSalesperson";
            this.tsmUpdateSelectedSalesperson.Size = new System.Drawing.Size(231, 22);
            this.tsmUpdateSelectedSalesperson.Text = "Update Selected";
            this.tsmUpdateSelectedSalesperson.Click += new System.EventHandler(this.tsmUpdateSelectedSalesperson_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProductsList,
            this.tsmUpdateSelectedProduct});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // tsmProductsList
            // 
            this.tsmProductsList.Name = "tsmProductsList";
            this.tsmProductsList.Size = new System.Drawing.Size(159, 22);
            this.tsmProductsList.Text = "List";
            this.tsmProductsList.Click += new System.EventHandler(this.tsmProductsList_Click);
            // 
            // tsmUpdateSelectedProduct
            // 
            this.tsmUpdateSelectedProduct.Name = "tsmUpdateSelectedProduct";
            this.tsmUpdateSelectedProduct.Size = new System.Drawing.Size(159, 22);
            this.tsmUpdateSelectedProduct.Text = "Update Selected";
            this.tsmUpdateSelectedProduct.Click += new System.EventHandler(this.tsmUpdateSelectedProduct_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomersList});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // tsmCustomersList
            // 
            this.tsmCustomersList.Name = "tsmCustomersList";
            this.tsmCustomersList.Size = new System.Drawing.Size(92, 22);
            this.tsmCustomersList.Text = "List";
            this.tsmCustomersList.Click += new System.EventHandler(this.tsmCustomersList_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSalesList,
            this.tsmAddSale});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // tsmSalesList
            // 
            this.tsmSalesList.Name = "tsmSalesList";
            this.tsmSalesList.Size = new System.Drawing.Size(96, 22);
            this.tsmSalesList.Text = "List";
            this.tsmSalesList.Click += new System.EventHandler(this.tsmSalesList_Click);
            // 
            // tsmAddSale
            // 
            this.tsmAddSale.Name = "tsmAddSale";
            this.tsmAddSale.Size = new System.Drawing.Size(96, 22);
            this.tsmAddSale.Text = "Add";
            this.tsmAddSale.Click += new System.EventHandler(this.tsmAddSale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Salesperson:";
            // 
            // txtCurrentSalesman
            // 
            this.txtCurrentSalesman.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentSalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSalesman.Location = new System.Drawing.Point(170, 36);
            this.txtCurrentSalesman.Name = "txtCurrentSalesman";
            this.txtCurrentSalesman.ReadOnly = true;
            this.txtCurrentSalesman.Size = new System.Drawing.Size(199, 22);
            this.txtCurrentSalesman.TabIndex = 3;
            // 
            // txtCurrentProduct
            // 
            this.txtCurrentProduct.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentProduct.Location = new System.Drawing.Point(170, 64);
            this.txtCurrentProduct.Name = "txtCurrentProduct";
            this.txtCurrentProduct.ReadOnly = true;
            this.txtCurrentProduct.Size = new System.Drawing.Size(199, 22);
            this.txtCurrentProduct.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected Product:";
            // 
            // txtCurrentCustomer
            // 
            this.txtCurrentCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentCustomer.Location = new System.Drawing.Point(170, 92);
            this.txtCurrentCustomer.Name = "txtCurrentCustomer";
            this.txtCurrentCustomer.ReadOnly = true;
            this.txtCurrentCustomer.Size = new System.Drawing.Size(199, 22);
            this.txtCurrentCustomer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selected Customer:";
            // 
            // tsmQuarterlyCommissionReport
            // 
            this.tsmQuarterlyCommissionReport.Name = "tsmQuarterlyCommissionReport";
            this.tsmQuarterlyCommissionReport.Size = new System.Drawing.Size(231, 22);
            this.tsmQuarterlyCommissionReport.Text = "Quarterly Commission Report";
            this.tsmQuarterlyCommissionReport.Click += new System.EventHandler(this.tsmQuarterlyCommissionReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 203);
            this.Controls.Add(this.txtCurrentCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentSalesman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeSpoke";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
        private System.Windows.Forms.ToolStripMenuItem salespeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSalespeopleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentSalesman;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateSelectedSalesperson;
        private System.Windows.Forms.TextBox txtCurrentProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmProductsList;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateSelectedProduct;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCurrentCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomersList;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSalesList;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSale;
        private System.Windows.Forms.ToolStripMenuItem tsmQuarterlyCommissionReport;
    }
}

