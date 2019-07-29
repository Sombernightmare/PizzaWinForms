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
        PizzaContext _context = new PizzaContext();
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
            PopulateDropdowns();
        }

        private void CmbDetailType_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbDetailType.SelectedIndex > -1)
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
    }
}
