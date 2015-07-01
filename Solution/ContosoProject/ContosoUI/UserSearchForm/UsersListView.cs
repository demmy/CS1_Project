using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Domain.Entities.Users;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ContosoUI.UserSearchForm
{
    public partial class UsersListView : DevExpress.XtraBars.Ribbon.RibbonForm, IUserSearchView
    {
        private readonly UserSearchPresenter presenter;

        public UsersListView()
        {
            InitializeComponent();
            presenter = new UserSearchPresenter(this, new UserSearchModel());
            usersGridControl.DataSource = presenter.Users;
            User user = new User();

            BindingSource binding = new BindingSource();
            binding.DataSource = presenter;

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login");
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            usersGridControl.DataBindings.Add("DataSource", binding, "Users");
        }

        private void addUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.AddUser();
        }

        private void searchUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.Search();
            RefreshForm();
        }

        private void clearUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.Cancel();
            RefreshForm();
        }

        public void RefreshForm()
        {
            loginTextEdit.Text = presenter.Login;
            firstNameTextEdit.Text = presenter.FirstName;
            lastNameTextEdit.Text = presenter.LastName;
            usersGridControl.DataSource = presenter.Users; // spike            
            //usersGridControl.RefreshDataSource();
            //usersGridControl.Refresh();
        }

        private void usersGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.EditUser(id);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            presenter.Search();
            RefreshForm();
        }


    }
}