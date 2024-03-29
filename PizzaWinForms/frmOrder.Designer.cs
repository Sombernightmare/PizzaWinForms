﻿namespace PizzaWinForms
{
    partial class frmOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.dgOrderItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Type";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(42, 103);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(196, 21);
            this.cmbOrderType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(45, 184);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(193, 20);
            this.txtCustomer.TabIndex = 5;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Location = new System.Drawing.Point(264, 184);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(105, 23);
            this.btnCustomerSearch.TabIndex = 6;
            this.btnCustomerSearch.Text = "Customer Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click);
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Location = new System.Drawing.Point(264, 224);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(105, 23);
            this.btnAddOrderItem.TabIndex = 7;
            this.btnAddOrderItem.Text = "Add Order Item";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;
            this.btnAddOrderItem.Click += new System.EventHandler(this.BtnAddOrderItem_Click);
            // 
            // dgOrderItems
            // 
            this.dgOrderItems.AllowUserToAddRows = false;
            this.dgOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderItems.Location = new System.Drawing.Point(42, 288);
            this.dgOrderItems.Name = "dgOrderItems";
            this.dgOrderItems.ReadOnly = true;
            this.dgOrderItems.Size = new System.Drawing.Size(678, 150);
            this.dgOrderItems.TabIndex = 8;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgOrderItems);
            this.Controls.Add(this.btnAddOrderItem);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmOrder";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.DataGridView dgOrderItems;
    }
}

