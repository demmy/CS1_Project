using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.UserSearchForm
{
    public partial class UserSearchForm : Form, IUserView
    {
        private readonly UserPresenter presenter;

        public UserSearchForm()
        {
            InitializeComponent();
            presenter = new UserPresenter(this, new UserModel());
            UsersGridControl.DataSource = Data.StoreData.Storage.Users;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            presenter.AddUser();
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            presenter.Cancel();
        }

        public string Login
        {
            get { return LoginTextEdit.Text; }
            set { LoginTextEdit.Text = value; }
        }

        public string FirstName
        {
            get { return FirstNameTextEdit.Text; }
            set { FirstNameTextEdit.Text = value; }
        }

        public string LastName
        {
            get { return LastNameTextEdit.Text; }
            set { LastNameTextEdit.Text = value; }
        }

        public ICollection<Domain.Entities.Users.User> UserGrid
        {
            get { return (ICollection<Domain.Entities.Users.User>)UsersGridControl.DataSource; }
            set { UsersGridControl.DataSource = value; }
        }
    }
}
