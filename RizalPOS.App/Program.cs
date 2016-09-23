using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RizalPOS.App.Management;
using RizalPOS.App.Products;
using RizalPOS.App.Reports;
using RizalPOS.App.Sales;
using RizalPOS.App.Transactions;
using RizalPOS.Domain.Context;

namespace RizalPOS.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using (var context = new PosContext())
                {
                    var products = context.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                string msg = "";
                if (ex.InnerException != null)
                {
                    msg = ex.InnerException.Message;
                }
                else
                {
                    msg = ex.Message;
                }
                MessageBox.Show(String.Format("Error: Please check database connection.{0}{0}{1}", Environment.NewLine, msg));
                return;
            }
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var loginForm = new LoginDialog();
                var form = new SalesForm();
                //var form = new ReportsMainForm();
                //var form = new UserManagementDialog();
                var result = loginForm.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                Application.Run(form);
                }
                
                
                // -- for editing various forms
                //var form = new TransactionsForm();
                //var form = new ReportsMainForm();
                
                // -- -------------------------//
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: Please check application startup.{0}{0}{1}", Environment.NewLine, ex.Message));
                return;
                
            }
           
        }
    }
}
