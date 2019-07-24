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
         List<Customer> customers = _context.Customers.Where(c => txtName.Text != "" && (c.FirstName.Contains(txtName.Text) || c.LastName.Contains(txtName.Text))).ToList(); ;

            dgResults.DataSource = customers;
        }
    }
}
