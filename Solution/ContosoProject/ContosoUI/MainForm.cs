using System;
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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new UserSearchForm.UsersListView();
            form.MdiParent = this;
            form.Show();
        }
    }
}
