using System;
using System.Windows.Forms;
using ContosoUI.UserForm;
using Domain.Entities.Users;
using DevExpress.XtraBars;
using System.Linq;

namespace ContosoUI.UserForm
{
    public partial class UserForm : DevExpress.XtraBars.Ribbon.RibbonForm, IUserView
    {
        private readonly UserPresenter presenter;
        BindingSource binding = new BindingSource();

        public UserForm()
        {
            InitializeComponent();
            presenter = new UserPresenter(this, new UserModel());
        }

        public UserForm(int id)
        {
            InitializeComponent();
            presenter = new UserPresenter(this, new UserModel()); 
            presenter.GetUser(id);
            stateButtonText();
        }

        private void ShowDependentOnRole(Role role)
        {
            if (!role.Permissions.Where(x => x.Title == "Edit User").Any())
            {
                barSaveButton.Visibility = BarItemVisibility.Never;
                barSaveAndNewButton.Visibility = BarItemVisibility.Never;
                barClearButton.Visibility = BarItemVisibility.Never;
                stateButton.Visibility = BarItemVisibility.Never;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowDependentOnRole(LoginForm.CurrentUser.Role);

            binding.DataSource = presenter;

            roleLookUpEdit.Properties.DataSource = presenter.RoleList;
            roleLookUpEdit.Properties.ValueMember = "Id";
            roleLookUpEdit.Properties.DisplayMember = "Title";

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login");
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            middleNameTextEdit.DataBindings.Add("EditValue", binding, "MiddleName");
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            passwordTextEdit.DataBindings.Add("EditValue", binding, "Password");
            roleLookUpEdit.DataBindings.Add("EditValue", binding, "RoleID");
        }

        public void RefreshForm()
        {
            stateButtonText();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            presenter.Clear();
        }

        private void stateButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.State = !presenter.State;
        }

        private void stateButtonText()
        {
            if (presenter.State)
                stateButton.Caption = "Remove";
            else
                stateButton.Caption = "Revert";
        }

        private void barSaveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Save();
        }

        private void barSaveAndNewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.SaveAndNew();
        }     
    }
}