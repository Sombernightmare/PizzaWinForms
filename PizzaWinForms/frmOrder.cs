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
        public Customer OrderCustomer { get; set; }
        public frmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            PopulateDropdowns();
        }

        private void PopulateDropdowns()
        {
            foreach (OrderType type in Enum.GetValues(typeof(OrderType)))
            {
                cmbOrderType.Items.Add(type);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cmbOrderType.SelectedIndex != -1)
            {
                OrderType selectedType = (OrderType)cmbOrderType.SelectedItem;
            }
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
            addItem.ShowDialog(this);
        }
    }
}
