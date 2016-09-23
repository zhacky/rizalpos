using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using RizalPOS.Domain.Classes;
using RizalPOS.Domain.Context;

namespace RizalPOS.App.Customers
{
    public partial class CustomerDialog : MetroForm
    {
        private PosContext context;
        private BindingSource _customerBindingSource;
        public Customer Customer { get; set; }

        private void InitData()
        {
            _customerBindingSource = new BindingSource {DataSource = context.Customers.ToList()};
            CustomersGrid.DataSource = _customerBindingSource;
            //--customize
            var idColumn = CustomersGrid.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;

            var nameColumn = CustomersGrid.Columns["Name"];
            if (nameColumn != null)
            {
                nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameColumn.MinimumWidth = 80;
            }
            var codeColumn = CustomersGrid.Columns["CustomerCode"];
            if (codeColumn != null)
            {
                codeColumn.Width = 40;
                codeColumn.MinimumWidth = 40;
                codeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                codeColumn.HeaderText = "Code";
            }

            var entryColumn = CustomersGrid.Columns["EntryDate"];
            if (entryColumn != null)
            {
                entryColumn.DefaultCellStyle.Format = "mm/dd/yyyy";
                entryColumn.Width = 20;
                entryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                entryColumn.HeaderText = "Date";
            }
        }
        private void GenerateCustomerCode()
        {
            if (CustomerNameTextBox.Text.Length > 3)
            {
                Random random = new Random();
                string CustomerCode = "";
                string hexa = "abcdefghjkmnpqruvwxyz";
                int a = 1;
                int b = 20;
                int c = 9;
                int d = 99;
                int e = 999;
                CustomerCode += hexa.Substring(random.Next(0, b), 1).ToUpper();
                CustomerCode += (random.Next(a, d)).ToString("0");
                CustomerCode += hexa.Substring(random.Next(0, b), 1).ToUpper();
                CustomerCode += (random.Next(a, e)).ToString("0");
                if (context.Customers.SingleOrDefault(p => p.CustomerCode == CustomerCode) != null)
                    CustomerCode += (random.Next(a, c)).ToString("0");
                CustomerCodeTextBox.Text = CustomerCode;
            }
            else
            {
                CustomerNameTextBox.Select();
            }
        }
        private void AddCustomer()
        {
            if (CustomerNameTextBox.Text.Length > 3 && CustomerCodeTextBox.Text.Length > 3)
            {

                Customer cust = new Customer()
                {
                    CustomerCode = CustomerCodeTextBox.Text,
                    Name = CustomerNameTextBox.Text,
                    EntryDate = DateTime.Now
                };
                if (context.Customers.SingleOrDefault(c => c.CustomerCode == cust.CustomerCode) != null)
                {
                    MessageBox.Show("Cannot create duplicate");
                }
                else
                {
                context.Customers.Add(cust);
                context.SaveChanges();
                }

            }
            else
            {
                CustomerNameTextBox.Select();
            }

        }

        #region Default Form Events:
        public CustomerDialog()
        {
            InitializeComponent();
        }
        private void CustomerDialog_Load(object sender, EventArgs e)
        {
            context = new PosContext();
            Customer = context.Customers.FirstOrDefault();
            InitData();
        }
        private void OK_Button_Click(object sender, EventArgs e)
        {
            Customer = CustomersGrid.SelectedRows[0].DataBoundItem as Customer;
            context.SaveChanges();
            DialogResult = DialogResult.OK;
        }
        private void GenerateCodeButton_Click(object sender, EventArgs evt)
        {
            GenerateCustomerCode();
        }
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        #endregion

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersGrid.SelectedRows.Count ==1)
            {
                var result = MessageBox.Show("Delete customer?", "Confirm delete", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var cust = CustomersGrid.SelectedRows[0].DataBoundItem as Customer;
                    context.Customers.Remove(cust);
                    context.SaveChanges();
                   
                }



            }
        }

        private void SearchCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        private void SearchCustomer()
        {
            var searchString = SearchCustomerTextBox.Text;
            List<Customer> custs = context.Customers.Where(c => c.Name.ToLower().Contains(searchString.ToLower())||c.CustomerCode.Contains(searchString.ToUpper())).ToList();
            CustomersGrid.DataSource = custs;
        }

        private void CustomersGrid_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                var rowIndex = CustomersGrid.SelectedRows[0].Index;
                if (rowIndex > -1)
                {
                    CustomersGrid.Rows[rowIndex].Selected = true;
                    rowIndex--;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                var rowIndex = CustomersGrid.SelectedRows[0].Index;
                if (rowIndex < CustomersGrid.Rows.Count)
                {
                    CustomersGrid.Rows[rowIndex].Selected = true;
                    rowIndex++;
                }
            }
        }
    }
}
