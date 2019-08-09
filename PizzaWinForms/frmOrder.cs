using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaWinForms
{
    public partial class frmOrder : Form
    {
        private DataTable _orderItems;
        public Customer OrderCustomer { get; set; }

        public frmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            PopulateDropdowns();
            BuildOrderItemsSchema();
            dgOrderItems.DataSource = _orderItems;
            dgOrderItems.Columns["InventoryItems"].Visible = false;
        }

        private void PopulateDropdowns()
        {
            foreach (OrderType type in Enum.GetValues(typeof(OrderType)))
            {
                cmbOrderType.Items.Add(type);
            }
        }

        private void BuildOrderItemsSchema()
        {
            _orderItems = new DataTable();
            _orderItems.Columns.Add("Type", typeof(OrderItemType));
            _orderItems.Columns.Add("Price", typeof(decimal));
            _orderItems.Columns.Add("Details", typeof(string));
            _orderItems.Columns.Add("InventoryItems", typeof(IEnumerable<InventoryItem>));
        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            frmCustomerSearch cs = new frmCustomerSearch();
            cs.ShowDialog(this);

            if(OrderCustomer != null)
                txtCustomer.Text = OrderCustomer.FirstName + " " + OrderCustomer.LastName;
        }

        private void BtnAddOrderItem_Click(object sender, EventArgs e)
        {
            frmAddOrderItem addItem = new frmAddOrderItem();

            if (addItem.ShowDialog(this) != DialogResult.OK)
                return;

            DataRow row = _orderItems.NewRow();
            row["Type"] = addItem.Type;
            //row["Price"] = 
            row["Details"] = string.Join(", ", addItem.InventoryItems.Select(i => i.Name));
            row["InventoryItems"] = addItem.InventoryItems;

            _orderItems.Rows.Add(row);
        }
    }
}
