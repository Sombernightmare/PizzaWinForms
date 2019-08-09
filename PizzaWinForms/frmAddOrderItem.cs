using PizzaStore.Data;
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
    public partial class frmAddOrderItem : Form
    {
        private PizzaContext _context = new PizzaContext();
        public OrderItemType Type { get; private set; }
        private BindingList<InventoryItem> _inventoryItems;

        public BindingList<InventoryItem> InventoryItems
        {
            get
            {
                if (_inventoryItems == null)
                    _inventoryItems = new BindingList<InventoryItem>();
                return _inventoryItems;
            }
        }
        public frmAddOrderItem()
        {
            InitializeComponent();
        }

        private void PopulateDropdowns()
        {
            foreach (OrderItemType type in Enum.GetValues(typeof(OrderItemType)))
            {
                cmbItemType.Items.Add(type);
            }

            foreach (InventoryItemType type in Enum.GetValues(typeof(InventoryItemType)))
            {
                cmbDetailType.Items.Add(type);
            }
        }

        private void AddOrderItem_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            PopulateDropdowns();
            dgOrderItems.DataSource = InventoryItems;

            foreach (DataGridViewColumn column in dgOrderItems.Columns)
            {
                if (column.Name != "Name" && column.Name != "Type")
                    column.Visible = false;
            }
        }

        private void CmbDetailType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDetailType.SelectedIndex > -1)
            {
                lblDetailName.Visible = true;
                cmbDetailItems.Visible = true;

                lblDetailName.Text = cmbDetailType.SelectedItem.ToString();
                cmbDetailItems.DataSource = _context.InventoryItems.Where(i => i.Type == (InventoryItemType)cmbDetailType.SelectedItem).ToList();
                cmbDetailItems.DisplayMember = "Name";
                cmbDetailItems.ValueMember = "ID";
            }
            else
            {
                lblDetailName.Visible = false;
                cmbDetailItems.Visible = false;

                lblDetailName.Text = string.Empty;
                cmbDetailItems.DataSource = null;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbDetailItems.SelectedIndex == -1)
            {
                MessageBox.Show("Select a detail item");
                return;
            }

            InventoryItem item = _context.InventoryItems.FirstOrDefault(i => i.ID == (int)cmbDetailItems.SelectedValue);

            if (!InventoryItems.Any(i => i.ID == item.ID))
                InventoryItems.Add(item);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItemType.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item Type");
                return;
            }

            if (InventoryItems.Count == 0)
            {
                MessageBox.Show("Add Detail Item");
                return;
            }

            Type = (OrderItemType)cmbItemType.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnClearItems_Click(object sender, EventArgs e)
        {
            dgOrderItems.Rows.Clear();
        }
    }
}
