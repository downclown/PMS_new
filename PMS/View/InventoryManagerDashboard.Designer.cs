namespace PMS.View
{
    partial class InventoryManagerDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStockValidity = new System.Windows.Forms.Button();
            this.btnStockManagement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblTotalMedicine = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStockValidity);
            this.panel1.Controls.Add(this.btnStockManagement);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 713);
            this.panel1.TabIndex = 8;
            // 
            // btnStockValidity
            // 
            this.btnStockValidity.BackColor = System.Drawing.Color.Black;
            this.btnStockValidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockValidity.FlatAppearance.BorderSize = 0;
            this.btnStockValidity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockValidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockValidity.ForeColor = System.Drawing.Color.Cyan;
            this.btnStockValidity.Location = new System.Drawing.Point(4, 375);
            this.btnStockValidity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStockValidity.Name = "btnStockValidity";
            this.btnStockValidity.Size = new System.Drawing.Size(232, 80);
            this.btnStockValidity.TabIndex = 2;
            this.btnStockValidity.Text = "Stock Validity";
            this.btnStockValidity.UseVisualStyleBackColor = false;
            this.btnStockValidity.Click += new System.EventHandler(this.btnStockValidity_Click_1);
            // 
            // btnStockManagement
            // 
            this.btnStockManagement.BackColor = System.Drawing.Color.Black;
            this.btnStockManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockManagement.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnStockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockManagement.ForeColor = System.Drawing.Color.Cyan;
            this.btnStockManagement.Location = new System.Drawing.Point(4, 242);
            this.btnStockManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStockManagement.Name = "btnStockManagement";
            this.btnStockManagement.Size = new System.Drawing.Size(232, 80);
            this.btnStockManagement.TabIndex = 1;
            this.btnStockManagement.Text = "Stock Management";
            this.btnStockManagement.UseVisualStyleBackColor = false;
            this.btnStockManagement.Click += new System.EventHandler(this.btnStockManagement_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Out of Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Low Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Medicine in Inventory";
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.Location = new System.Drawing.Point(387, 212);
            this.lblOutOfStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(26, 29);
            this.lblOutOfStock.TabIndex = 3;
            this.lblOutOfStock.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(387, 134);
            this.lblLowStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(26, 29);
            this.lblLowStock.TabIndex = 2;
            this.lblLowStock.Text = "0";
            // 
            // lblTotalMedicine
            // 
            this.lblTotalMedicine.AutoSize = true;
            this.lblTotalMedicine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMedicine.Location = new System.Drawing.Point(387, 52);
            this.lblTotalMedicine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMedicine.Name = "lblTotalMedicine";
            this.lblTotalMedicine.Size = new System.Drawing.Size(26, 29);
            this.lblTotalMedicine.TabIndex = 1;
            this.lblTotalMedicine.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblOutOfStock);
            this.panel2.Controls.Add(this.lblLowStock);
            this.panel2.Controls.Add(this.lblTotalMedicine);
            this.panel2.Location = new System.Drawing.Point(416, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 309);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // InventoryManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagerDashboard";
            this.Load += new System.EventHandler(this.InventoryManagerDashboard_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockValidity;
        private System.Windows.Forms.Button btnStockManagement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblTotalMedicine;
        private System.Windows.Forms.Panel panel2;
    }
}