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
    public partial class frmCustomerSearch : Form
    {
        PizzaContext _context = new PizzaContext();
        public frmCustomerSearch()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
            dgResults.DataSource = Customer.FindCustomers(txtName.Text, txtAddress.Text, txtPhoneNumber.Text);
        }

        private void BtbSelectCustomer_Click(object sender, EventArgs e)
        {
            if(dgResults.SelectedRows.Count == 0)
            {
                return;
            }

            Customer selectedCustomer = (Customer) dgResults.SelectedRows[0].DataBoundItem;
            ((frmOrder)Owner).OrderCustomer = selectedCustomer;
            Close();
        }

       
    }
}
