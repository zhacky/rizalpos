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
    public partial class ReturnChangeForm : MetroForm
    {
        public double Change { get; set; }
        public ReturnChangeForm()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ReturnChangeForm_Load(object sender, EventArgs e)
        {
            ChangeTextBox.Text = Change.ToString("#,##0.00");
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
