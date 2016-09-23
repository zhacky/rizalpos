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
using RizalPOS.Domain.Classes;
using RizalPOS.Domain.Context;

namespace RizalPOS.App.Products
{
    public partial class ProductListDialog : MetroForm
    {
        #region Fields:
        private List<Product> products;
        public Product Product { get; private set; }
        public double Quantity { get; set; }
        #endregion
        
        #region Methods:
        private void InitData()
        {
            
            using (var context = new PosContext())
            {
                products = context.Products.ToList();
                ProductsGrid.DataSource = products;
                //--id field
                var idColumn = ProductsGrid.Columns["Id"];
                if (idColumn != null) idColumn.Visible = false;
                //--barcode field
                var barcodeColumn = ProductsGrid.Columns["Barcode"];
                if (barcodeColumn != null)
                {
                    barcodeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet; 
                    barcodeColumn.DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    barcodeColumn.MinimumWidth = 60;
                }
                //--name field
                var nameColumn = ProductsGrid.Columns["Name"];
                if (nameColumn != null)
                {
                    nameColumn.MinimumWidth = 200;
                    nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                //--unit price field
                var priceColumn = ProductsGrid.Columns["UnitPrice"];
                if (priceColumn != null)
                {
                    priceColumn.HeaderText = "Price";
                    priceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    priceColumn.DefaultCellStyle.Format = "#,##0.00";
                    priceColumn.MinimumWidth = 40;
                    priceColumn.DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleRight;
                }
                //--unit cost field
                var unitCostColumn = ProductsGrid.Columns["UnitCost"];
                if (unitCostColumn != null)
                {
                    unitCostColumn.Visible = false;
                    unitCostColumn.AutoSizeMode=DataGridViewAutoSizeColumnMode.NotSet;
                    unitCostColumn.DefaultCellStyle.Format = "#,##0.00";
                    unitCostColumn.Width = 40;
                    unitCostColumn.MinimumWidth = 40;
                    unitCostColumn.DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleRight;
                }
                //--category field
                var categoryColumn = ProductsGrid.Columns["Category"];
                if (categoryColumn != null)
                {
                    categoryColumn.Visible = false;
                    categoryColumn.AutoSizeMode=DataGridViewAutoSizeColumnMode.NotSet;
                    categoryColumn.MinimumWidth = 80;


                }

                Product = ProductsGrid.SelectedRows[0].DataBoundItem as Product;
                Quantity = 1;
            }
        }

        private void GetSelectedItem()
        {
            Product = ProductsGrid.SelectedRows[0].DataBoundItem as Product;
            double temp;
            if (double.TryParse(QuantityTextBox.Text, out temp))
            {
                Quantity = temp;
            }
            else
            {
                Quantity = 1;
            }
            QuantityTextBox.Focus();
        }

        private void SearchItem()
        {
            string searchString = SearchProductTextBox.Text;
            var filtered_products = MatchCaseCheckBox.Checked ? products.Where(c => c.Name.Contains(searchString) || c.Barcode.Contains(searchString)).ToList() : products.Where(c => c.Name.ToLower().Contains(searchString.ToLower()) || c.Barcode.ToUpper().Contains(searchString.ToUpper())).ToList();
            ProductsGrid.DataSource = filtered_products;
        }
        #endregion

        #region Form Events:
        public ProductListDialog()
        {
            InitializeComponent();
        }
        private void ProductListDialog_Load(object sender, EventArgs e)
        {
            InitData();
            SearchProductTextBox.Select();
        }
        private void OK_Button_Click(object sender, EventArgs e)
        {
            GetSelectedItem();
            DialogResult = DialogResult.OK;
        }
        private void ProductsGrid_DoubleClick(object sender, EventArgs e)
        {
            OK_Button_Click(this,e);
        }
        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (!double.TryParse(QuantityTextBox.Text, out temp))
            {
                QuantityTextBox.Text = QuantityTextBox.Text.Substring(0, QuantityTextBox.Text.Length - 1);
                
            }
        }
      
        private void SearchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchItem();
        }
        #endregion

        private void ProductsSelection_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                var rowIndex = ProductsGrid.SelectedRows[0].Index;
                if (rowIndex > 0)
                {
                    rowIndex--;
                    ProductsGrid.Rows[rowIndex].Selected = true;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                var rowIndex = ProductsGrid.SelectedRows[0].Index;
                if (rowIndex < ProductsGrid.Rows.Count)
                {
                    rowIndex++;
                    ProductsGrid.Rows[rowIndex].Selected = true;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                OK_Button_Click(this, e);
            }
        }

    }
}
