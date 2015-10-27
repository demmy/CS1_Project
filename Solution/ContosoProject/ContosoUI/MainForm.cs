using System;
using ContosoUI.ClientForm;
using ContosoUI.OrderForm;
using ContosoUI.ProductForm;
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
            var form = new UserForm.UserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
           IOrderView orderView = new OrderForm.OrderForm(1) { MdiParent = this};
            orderView.ShowView();
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
            IProductView productView = new ProductView(1) {MdiParent = this};
            productView.ShowView();
        }
    }
}
