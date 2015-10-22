using System;
using System.Windows.Forms;
using ContosoUI.NicksForms.User_form;

namespace ContosoUI.NicksForms.User_form
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

        private void UserForm_Load(object sender, EventArgs e)
        {
            binding.DataSource = presenter; 

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login");
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            middleNameTextEdit.DataBindings.Add("EditValue", binding, "MiddleName");
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            passwordTextEdit.DataBindings.Add("EditValue", binding, "Password");

            roleLookUpEdit.Properties.DataSource = presenter.RoleList;
            roleLookUpEdit.Properties.ValueMember = "Id";
            roleLookUpEdit.Properties.DisplayMember = "Title";

            roleLookUpEdit.DataBindings.Add("EditValue", binding, "RoleID");

            stateButtonText();
        }

        public UserForm(int id)
        {
            InitializeComponent();
            presenter = new UserPresenter(this, new UserModel());
            presenter.GetUser(id);
            stateButtonText();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            presenter.Clear();
        }

        private void stateButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.State = !presenter.State;
            stateButtonText();
        }

        private void stateButtonText()
        {
            if (presenter.State)
            {
                stateButton.Caption = "Remove";
                stateButton.LargeGlyph = (System.Drawing.Image)
            }
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