namespace PizzaWinForms
{
    partial class frmAddOrderItem
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
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbDetailType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDetailItems = new System.Windows.Forms.ComboBox();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(54, 104);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(196, 21);
            this.cmbItemType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDetailItems);
            this.groupBox1.Controls.Add(this.lblDetailName);
            this.groupBox1.Controls.Add(this.cmbDetailType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 280);
            this.dataGridView1.TabIndex = 6;
            // 
            // cmbDetailType
            // 
            this.cmbDetailType.FormattingEnabled = true;
            this.cmbDetailType.Location = new System.Drawing.Point(9, 52);
            this.cmbDetailType.Name = "cmbDetailType";
            this.cmbDetailType.Size = new System.Drawing.Size(196, 21);
            this.cmbDetailType.TabIndex = 8;
            this.cmbDetailType.SelectedValueChanged += new System.EventHandler(this.CmbDetailType_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Detail Type";
            // 
            // cmbDetailItems
            // 
            this.cmbDetailItems.FormattingEnabled = true;
            this.cmbDetailItems.Location = new System.Drawing.Point(9, 130);
            this.cmbDetailItems.Name = "cmbDetailItems";
            this.cmbDetailItems.Size = new System.Drawing.Size(196, 21);
            this.cmbDetailItems.TabIndex = 10;
            this.cmbDetailItems.Visible = false;
            // 
            // lblDetailName
            // 
            this.lblDetailName.AutoSize = true;
            this.lblDetailName.Location = new System.Drawing.Point(6, 103);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(61, 13);
            this.lblDetailName.TabIndex = 9;
            this.lblDetailName.Text = "Detail Type";
            this.lblDetailName.Visible = false;
            // 
            // frmAddOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.label2);
            this.Name = "frmAddOrderItem";
            this.Text = "Add Order Item";
            this.Load += new System.EventHandler(this.AddOrderItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDetailType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDetailItems;
        private System.Windows.Forms.Label lblDetailName;
    }
}