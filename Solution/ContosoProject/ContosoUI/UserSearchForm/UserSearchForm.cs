using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ContosoUI.UserSearchForm
{
    public partial class UserSearchForm : Form, IUserSearchView
    {
        private readonly UserSearchPresenter presenter;

        public UserSearchForm()
        {
            InitializeComponent();
            presenter = new UserSearchPresenter(this, new UserSearchModel(), new UserForm.UserForm());
            UsersGridControl.DataSource = Data.StoreData.Storage.Users;
            Domain.Entities.Users.User user = new Domain.Entities.Users.User();
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
            UserGridView.RefreshData();
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

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            // funktioniert schlecht ...

            GridView view = UserGridView;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.EditUser(id);
            }
        }

        private void UserGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.EditUser(id);
            }
        }
    }
}
