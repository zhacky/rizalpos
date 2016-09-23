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
namespace RizalPOS.App.Sales
{
    public partial class PaymentForm : MetroForm
    {
        #region Fields:
        public double Payment { get; set; }
        public double TotalAmount { get; set; }
        #endregion
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            double temp;
            if (double.TryParse(CashTextBox.Text, out temp))
            {
                Payment = double.Parse(CashTextBox.Text);
                if (Payment >= TotalAmount)
                {
                   
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    CashTextBox.Focus();
                    CashTextBox.BackColor = Color.DeepPink;
                }
            }
            else
            {
                Payment = 0;
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            CashTextBox.Focus();
            CashTextBox.Select();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
