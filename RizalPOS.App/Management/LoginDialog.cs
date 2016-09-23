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
using RizalPOS.App.Sales;
using RizalPOS.Domain.Classes;
using RizalPOS.Domain.Context;

namespace RizalPOS.App.Management
{
    public partial class LoginDialog : MetroForm
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
            
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            using (var context = new PosContext())
            {
                string userInput = UsernameTextBox.Text;
                string passwordInput = PasswordTextBox.Text;
                //default password
                string decryptedPassword = "backfire@123";
                Encryption encryptor = new Encryption();
                var user =
                    context.Users.SingleOrDefault(
                        u => u.Username == userInput);
                if (user != null)
                {
                    decryptedPassword = encryptor.GetDecrypted(user.Password);
                }
                if (decryptedPassword == passwordInput)
                {
                    DialogResult = DialogResult.OK;
                    PasswordTextBox.Clear();
                    UsernameTextBox.WithError = false;

                    PasswordTextBox.WithError = false;
                    
                }
                else
                {
                    UsernameTextBox.WithError = true;
                    
                    PasswordTextBox.WithError = true;
                    
                }
            }
            
        }
            

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            InitAll();
        }

        private void InitAll()
        {
            Activate();
            UsernameTextBox.Select();
        }
    }
}
