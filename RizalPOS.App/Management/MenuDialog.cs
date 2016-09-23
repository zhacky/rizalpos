using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using RizalPOS.App.Products;
using RizalPOS.App.Transactions;

namespace RizalPOS.App.Management
{
    public partial class MenuDialog : MetroForm
    {
        public MenuDialog()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuDialog_KeyDown(object sender, KeyEventArgs e)
        {
            KeyToCommand(e);
        }

        private void KeyToCommand(KeyEventArgs keyEventArgs)
        {
            switch (keyEventArgs.KeyCode)
            {
                case Keys.NumPad7:
                    break;
                case Keys.NumPad8:

                    break;
                case Keys.NumPad9:

                    break;
                case Keys.NumPad4:

                    break;
                case Keys.NumPad5:

                    break;
                case Keys.NumPad6:

                    break;
                case Keys.NumPad1:

                    break;
                case Keys.NumPad2:

                    break;
                case Keys.NumPad3:

                    break;
                default:
                    break;
            }
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void ShowProducts()
        {
            (new ProductList()).Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
        }

        private void ConfirmLogout()
        {
            var dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                
                
            }
        }

        private void EditSalesButton_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();
            form.ShowDialog(this);
        }
    }
}
