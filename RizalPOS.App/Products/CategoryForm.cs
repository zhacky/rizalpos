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
    public partial class CategoryForm : MetroForm
    {
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                Name = CategoryTextBox.Text,
                ParentCategory = CategoryComboBox.SelectedItem as Category
            };
            Category = category;
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Categories;
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.SelectedIndex = -1;
        }


    }
}
