using System;
using ContosoUI.ClientForm;
using ContosoUI.OrderForm;
using ContosoUI.ProductForm;
using Data.StoreData;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Domain.Entities.Users;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace ContosoUI
{
    public partial class MainForm : RibbonForm
    {         
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("ua-UA");
            ShowDependentOnRole(Program.AuthUser.Role);
        }

        private void ShowDependentOnRole (Role role)
        {
            if (!role.Permissions.Any(x => x.Title != "Add User")) 
                UserBarButton.Visibility = BarItemVisibility.Never;
        }

        private void clientsMenuBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new ClientSearchForm.ClientListView();
            form.MdiParent = this;
            form.Show();
        }

        private void ordersMenuBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new OrderSearchForm.OrderListView();
            form.MdiParent = this;
            form.Show();
        }

        private void barUserButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new UserForm.UserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new OrderForm.OrderForm();
            form.MdiParent = this;
            form.Show();
        }

        private void UsersListBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new UserSearchForm.UsersListView();
            form.MdiParent = this;
            form.Show();
        }

        private void ProductsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new ProductSearchForm.ProductListView();
            form.MdiParent = this;
            form.Show();
        }

        private void ClientBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new ClientForm.ClientView();
            form.MdiParent = this;
            form.Show();
        }

        private void ProductBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new ProductForm.ProductView();
            form.MdiParent = this;
            form.Show();
        }

        private void ExitBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void CategoriesBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new CategoryForm.CategoryView();
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            bgPictureEdit.Visible = false;
        }

        private void RolesBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var form = new RoleForm.RoleView();
            //form.MdiParent = this;
            //form.Show();
        }
    }
}
