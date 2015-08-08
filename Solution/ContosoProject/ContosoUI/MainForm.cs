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
using System.Linq;

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
            ShowDependentOnRole(LoginForm.CurrentUser.Role);
        }

        private void ShowDependentOnRole (Role role)
        {
            if (!role.Permissions.Where(x => x.Title == "Add User").Any()) 
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

        private void exitMenuBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Environment.Exit(0);
        }

        private void barUserButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new UserForm.UserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderPresenter presenter = new OrderPresenter(new OrderModel(), new OrderForm.OrderForm() { MdiParent = this}, Storage.Orders[2]);
            presenter.ShowView(presenter);
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
            ClientPresenter presenter = new ClientPresenter(new ClientView() { MdiParent = this }, new ClientModel());
            presenter.ShowView(presenter, 1);
        }

        private void ProductBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductPresenter presenter = new ProductPresenter(new ProductView() { MdiParent = this}, new ProductModel() );
            presenter.ShowView(presenter, 4);
        }
    }
}
