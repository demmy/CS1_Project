using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.UserForm
{
    public partial class UserForm : Form, IUserView
    {
        private readonly UserPresenter presenter;

        public UserForm()
        {
            InitializeComponent();
            presenter = new UserPresenter(this);
        }

        public UserForm(int id)
        {
            InitializeComponent();
            presenter = new UserPresenter(this);
            presenter.GetUser(id);
        }

        public string Login
        {
            get { return loginTextEdit.Text; }
            set { loginTextEdit.Text = value; }
        }

        public string FirstName
        {
            get { return firstNameTextEdit.Text; }
            set { firstNameTextEdit.Text = value; }
        }
        
        public string MiddleName
        {
            get { return middleNameTextEdit.Text; }
            set { middleNameTextEdit.Text = value; }
        }
        
        public string LastName
        {
            get { return lastNameTextEdit.Text; }
            set { lastNameTextEdit.Text = value; }
        }

        public string Password
        {
            get { return passwordTextEdit.Text; }
            set { passwordTextEdit.Text = value; }
        }

        public string Role
        {
            get { return roleComboBoxEdit.Text; }
            set { roleComboBoxEdit.Text = value; }
        }

        public bool Active
        {
            get { return isActiveCheckEdit.Checked; }
            set { isActiveCheckEdit.Checked = value; }
        }

        public string Comments
        {
            get { return commentsRichTextBox.Text; }
            set { commentsRichTextBox.Text = value; }
        }
    }
}
