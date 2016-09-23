using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using RizalPOS.App.Properties;
using RizalPOS.Domain.Classes;
using RizalPOS.Domain.Context;

namespace RizalPOS.App.Products
{
    public partial class ProductList : MetroForm
    {
        #region Fields:

        public bool IsEditing { get; set; }
        private PosContext _context;
        private Product _product;
        private BindingSource _productBindingSource;
        public string CurrentBarcode { get; set; }

        #endregion

        #region Methods:
        private void LoadAllProducts()
        {
            _context = new PosContext();
            _productBindingSource = new BindingSource();
            _productBindingSource.DataSource = _context.Products.ToList();
            ProductsGridView.DataSource = _productBindingSource;
            CustomizeProductGridView();
        }
        private void InitAll()
        {
            CategoryComboBox.DataSource = _context.Categories.ToList();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.SelectedIndex = -1;
            Icon = Resources.shopping_cart;
            ProductNameTextBox.Select();
            ProductNameTextBox.Focus();
        }
        private void CustomizeProductGridView()
        {
            //--context menu
            
            //--id field
            if (ProductsGridView.Columns["Id"] != null) ProductsGridView.Columns["Id"].Visible = false;
            //--barcode field
            if (ProductsGridView.Columns["Barcode"] != null)
                ProductsGridView.Columns["Barcode"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            //--name field
            if (ProductsGridView.Columns["Name"] != null) ProductsGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //--unit price field
            if (ProductsGridView.Columns["UnitPrice"] != null)
            {
                ProductsGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "#,##0.00";
                ProductsGridView.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            //--unit cost field
            if (ProductsGridView.Columns["UnitCost"] != null)
            {
                ProductsGridView.Columns["UnitCost"].DefaultCellStyle.Format = "#,##0.00";
                ProductsGridView.Columns["UnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            //--category field
            var categoryColumn = ProductsGridView.Columns["Category"];
            if (categoryColumn != null)
            {
                categoryColumn.Visible = false;
                //var catColumn = new DataGridViewComboBoxColumn();
                //catColumn.HeaderText = "Category";
                //catColumn.DataPropertyName = "Category";
                //catColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                //catColumn.Name = "CategoryComboBox";
                //catColumn.DataSource = context.Products.ToList();
                //catColumn.DisplayMember = "Category";
                //ProductsGridView.Columns.Add(catColumn);
            }


        }
        private void SearchItem()
        {
            var searchString = SearchTextBox.Text;
   
            var products =
                _context.Products.Where(c => c.Name.Contains(searchString) || c.Barcode.Contains(searchString)).ToList();
            _productBindingSource.DataSource = products;
            SearchLabel.Text = "Search Filter (" + products.Count + ")";
            CustomizeProductGridView();
        }
        private void DisplaySelectedItem(DataGridViewCellEventArgs e)
        {
            if (!IsEditing) return;
            _product = ProductsGridView.Rows[e.RowIndex].DataBoundItem as Product;
            if (_product != null)
            {
                CurrentBarcode = _product.Barcode;
                ProductNameTextBox.Text = _product.Name;
                ProductBarcodeTextBox.Text = _product.Barcode;
                UnitPriceTextBox.Text = DisplayCurrencyAsText(_product.UnitPrice);
                UnitCostTextBox.Text = DisplayCurrencyAsText(_product.UnitCost);
                CategoryComboBox.SelectedItem = _product.Category;
                var diff = _product.UnitPrice - _product.UnitCost;
                var percent = diff / _product.UnitPrice;
                MarginTextBox.Text = DisplayCurrencyAsText(diff);
                PercentMarginTextBox.Text = percent.ToString("P1");

            }

        }
        private void ChangeEditingStatus()
        {
            _product = new Product();
            ClearProductInputBoxes();
            SaveButton.Visible = IsEditing;
            AddingRadioButton.Visible = IsEditing;
            EditingRadioButton.Visible = !IsEditing;
            AddProductButton.Visible = !IsEditing;
            SearchLabel.Visible = IsEditing;
            SearchTextBox.Visible = IsEditing;

            if (IsEditing) // -----when editing----
            {
                ProductsGridView.Visible = true;
                SearchTextBox.Select();
                AcceptButton = SaveButton;
                AddingRadioButton.Checked = false;
            }
            else // ----when adding----
            {
                ProductsGridView.Visible = false;
                ProductNameTextBox.Select();
                AcceptButton = AddProductButton;
                AddingRadioButton.Checked = true;
            }
        }
        private void AddNewProduct()
        {
            var prod = new Product
            {
                Barcode = ProductBarcodeTextBox.Text,
                Category = CategoryComboBox.SelectedItem as Category,
                Name = ProductNameTextBox.Text,
                UnitCost = double.Parse(UnitCostTextBox.Text),
                UnitPrice = double.Parse(UnitPriceTextBox.Text)

            };
            if (_context.Products.Where(c => c.Barcode == prod.Barcode).ToList().Count > 0)
            {
                MessageBox.Show("Barcode already exists");
            }
            else
            {
                _context.Products.Add(prod);
                _context.SaveChanges();
                MessageBox.Show("Successfully added " + prod.Name);
                ClearProductInputBoxes();
            }

        }
        private bool ValidateInputBoxes()
        {
            //--check product name
            if (!CheckStringTextBox(ProductNameTextBox)) return false;
            //--check barcode
            if (!CheckStringTextBox(ProductBarcodeTextBox)) return false;
            //--check unit price
            if (String.IsNullOrEmpty(UnitPriceTextBox.Text)) UnitPriceTextBox.Text = "0.00";
            if (!TestNumeric(UnitPriceTextBox)) return false;
            //--check unit cost
            if (String.IsNullOrEmpty(UnitCostTextBox.Text)) UnitCostTextBox.Text = "0.00";
            if (!TestNumeric(UnitCostTextBox)) return false;
            //--generate margin
            MarginTextBox.Text = (double.Parse(UnitPriceTextBox.Text) - double.Parse(UnitCostTextBox.Text)).ToString("#,##0.00");
            //


            return true;
        }
        #endregion

        #region Helpers:
        private string DisplayCurrencyAsText(double unitPrice)
        {

            return unitPrice.ToString("#,##0.00");

        }
        private void ClearProductInputBoxes()
        {
            ProductNameTextBox.Clear();
            ProductBarcodeTextBox.Clear();
            MarginTextBox.Clear();
            PercentMarginTextBox.Clear();
            UnitPriceTextBox.Clear();
            UnitCostTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
        }

        private bool CheckStringTextBox(MetroTextBox stringTextBox)
        {
            if (stringTextBox.Text.Length < 2)
            {
                stringTextBox.Focus();
                stringTextBox.WithError = true;
                return false;
            }
            else
            {
                stringTextBox.WithError = false;
            }
            return true;
        }

        private bool TestNumeric(MetroTextBox numericTextBox)
        {
            double temp;
            if (!double.TryParse(numericTextBox.Text, out temp))
            {
                numericTextBox.Focus();
                numericTextBox.WithError = true;
                return false;
            }
            else
            {
                numericTextBox.WithError = false;
                return true;
            }
        }

        #endregion

        #region FormEventHandlers:
        public ProductList()
        {
           
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            InitAll();
            ChangeEditingStatus();

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _product.Category = CategoryComboBox.SelectedItem as Category;
                if ((ProductNameTextBox.Text.Length > 2) && ProductNameTextBox.Text != _product.Name)
                {
                    _product.Name = ProductNameTextBox.Text;
                }
                if ((ProductBarcodeTextBox.Text.Length > 1) && ProductBarcodeTextBox.Text != _product.Barcode)
                {
                    _product.Barcode = ProductBarcodeTextBox.Text;
                }
                double cost;
                if (double.TryParse(UnitCostTextBox.Text, out cost))
                {
                    _product.UnitCost = cost;
                }
                double price;
                if (double.TryParse(UnitPriceTextBox.Text, out price))
                {
                    _product.UnitPrice = price;
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputBoxes()) AddNewProduct();
        }
        private void ProductList_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

                SearchItem();


        }
        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsGridView.SelectedRows.Count == 1 && e.RowIndex != -1)
            {
                DisplaySelectedItem(e);
            }
        }
        private void EditingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IsEditing = EditingRadioButton.Checked;
            ChangeEditingStatus();

        }
        private void AddingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IsEditing = !AddingRadioButton.Checked;
            ChangeEditingStatus();
        }
        private void PercentMarginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PercentMarginTextBox.Text == "Infinity") PercentMarginTextBox.Text = "0.00";
        }
        private void EditCategoryButton_Click(object sender, EventArgs e)
        {
            var categoryForm = new CategoryForm();
            categoryForm.Categories = _context.Categories.ToList();
            var dialog_result = categoryForm.ShowDialog(this);
            if (dialog_result == DialogResult.OK)
            {
                _context.Categories.Add(categoryForm.Category);
                _context.SaveChanges();
                CategoryComboBox.DataSource = _context.Categories.ToList();
                CategoryComboBox.SelectedIndex = -1;
            }
            
        }
        #endregion



        #region Error Handling:
        /**
        private void ProductsGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error:\n " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }

        }
         * 
         */
        #endregion


        
    }
}
