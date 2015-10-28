using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Domain.Entities.Comments;

namespace ContosoUI.UserForm
{
    public partial class UserForm : RibbonForm, IUserView
    {
        private readonly UserPresenter _presenter;
        BindingSource binding = new BindingSource();

        public UserForm()
        {
            InitializeComponent();
            _presenter = new UserPresenter(this, new UserModel());
        }

        public UserForm(int id)
        {
            InitializeComponent();
            _presenter = new UserPresenter(this, new UserModel());
            _presenter.GetUser(id);
            stateButtonText();
        }      
  
        private void UserForm_Load(object sender, EventArgs e)
        { 
            binding.DataSource = _presenter;

            roleLookUpEdit.Properties.DataSource = _presenter.RoleList;
            roleLookUpEdit.Properties.ValueMember = "Id";
            roleLookUpEdit.Properties.DisplayMember = "Title";

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login");
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            middleNameTextEdit.DataBindings.Add("EditValue", binding, "MiddleName");
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            passwordTextEdit.DataBindings.Add("EditValue", binding, "Password");
            roleLookUpEdit.DataBindings.Add("EditValue", binding, "RoleID");
            permissionListBoxControl.DataBindings.Add("DataSource", binding, "Permissions");
        }

        public void RefreshForm()
        {
            stateButtonText();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            _presenter.New();
        }

        private void stateButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.State = !_presenter.State;
        }

        private void stateButtonText()
        {
            if (_presenter.State)
                stateButton.Caption = "Remove";
            else
                stateButton.Caption = "Revert";
        }

        private void barSaveButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.Save();
        }

        private void barSaveAndNewButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.SaveAndNew();
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newCommentTextBox.Text))
            {
                _presenter.Comments.Add(new Comment() {Author = null, EntityType = EntityType.User, Text = newCommentTextBox.Text});
                newCommentTextBox.Text = string.Empty;
            }
        }

        private void newCommentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                addCommentButton_Click(this, e);
            }
        }     
    }
}