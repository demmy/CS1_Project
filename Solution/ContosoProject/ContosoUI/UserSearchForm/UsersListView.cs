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
        BindingSource binding = new BindingSource();
         
        public UsersListView()
        {
            InitializeComponent();
            presenter = new UserSearchPresenter(this);
        }

        private void UsersListView_Load(object sender, EventArgs e)
        {
            binding.DataSource = presenter;

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login");
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            usersGridControl.DataBindings.Add("DataSource", binding, "Users");
            usersGridControl.RefreshDataSource();
        }

        private void addUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.AddUser();
        }

        private void searchUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Search();
        }

        private void clearUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.Clear();
        }

        public void RefreshForm()
        {
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

        
        private void userSearchRibbon_Click(object sender, EventArgs e)
        {

        }
    }
}