using System;
using ContosoUI.NicksForms.Order_form;
using Data.StoreData;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace ContosoUI
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void barUserButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new NicksForms.User_form.UserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderPresenter presenter = new OrderPresenter(new OrderModel(), new OrderForm() { MdiParent = this}, Storage.Orders[2]);
            presenter.ShowView();

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
            //var form = new NicksForms.Client_form.();
            //form.MdiParent = this;
            //form.Show();
        }

        private void ProductBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new NicksForms.Product_form.ProductView();
            form.MdiParent = this;
            form.Show();
        }
    }
}
