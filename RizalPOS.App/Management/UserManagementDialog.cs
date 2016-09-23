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

namespace RizalPOS.App.Management
{
    public partial class UserManagementDialog : MetroForm
    {
        private PosContext context;
        private BindingSource userBindingSource;
        private Encryption encryptor;
        private bool isEditing;

        public UserManagementDialog()
        {
            InitializeComponent();
        }

        private void UserManagementDialog_Load(object sender, EventArgs e)
        {
            encryptor = new Encryption();
            CustomizeComboBox();
            ReloadUsers();
            CustomizeGrid();
        }

        private void CustomizeComboBox()
        {
            RoleComboBox.DataSource = Enum.GetValues(typeof(Role));
        }

        private void CustomizeGrid()
        {
            var idColumn = UsersGrid.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
            var userColumn = UsersGrid.Columns["Username"];
            //if(userColumn != null) userColumn
            var pwColumn = UsersGrid.Columns["Password"];
            if (pwColumn != null) pwColumn.Visible = false;





        }

        private void ReloadUsers()
        {
            context = new PosContext();
            userBindingSource = new BindingSource();
            userBindingSource.DataSource = context.Users.ToList();
            UsersGrid.DataSource = userBindingSource;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UsersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentUser(e.RowIndex);
        }

        private void SelectCurrentUser(int rowIndex)
        {
            var user = userBindingSource.Current as User;
            if (user != null)
            {
                UsernameTextBox.Text = user.Username;
                if(!string.IsNullOrEmpty(user.Password))
                PasswordTextBox.Text = encryptor.GetDecrypted(user.Password);
                RoleComboBox.SelectedItem = user.Role;
                UpdateButton.Enabled = true;
            }
            if (rowIndex < 0)
            {
                UpdateButton.Enabled = false;
                isEditing = false;
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ActivateUpdate();
        }

        private void ActivateUpdate()
        {
            EditUser(true);
            isEditing = true;

        }

        private void EditUser(bool editing)
        {

            UsernameTextBox.Enabled = editing;
            PasswordTextBox.Enabled = editing;
            RoleComboBox.Enabled = editing;
            SaveButton.Enabled = editing;
            AddUserButton.Enabled = !editing;
            UpdateButton.Enabled = !editing;


        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            EditUser(true);
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void SaveUser()
        {
            if (isEditing)
            {
                var currentUser = userBindingSource.Current as User;
                if (currentUser != null)
                {
                    currentUser.Username = UsernameTextBox.Text;
                    currentUser.Password = encryptor.GetEncrypted(PasswordTextBox.Text);
                    currentUser.Role = (Role) RoleComboBox.SelectedItem;
                }
            }
            else
            {
             var user = new User
            {
                Username = UsernameTextBox.Text,
                Password = encryptor.GetEncrypted(PasswordTextBox.Text),
                Role = (Role) RoleComboBox.SelectedItem
            };
                context.Users.Add(user);
            }
            context.SaveChanges(); 
            EditUser(false);
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();


        }
    }
}
