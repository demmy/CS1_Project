using System;
using System.Windows.Forms;

namespace ContosoUI.NicksForms.Order_form
{
    public partial class OrderForm : DevExpress.XtraBars.Ribbon.RibbonForm, IOrderView
    {
        private OrderPresenter presenter;

        public OrderForm()
        {
            InitializeComponent();
            presenter = new OrderPresenter(new OrderModel(), this);
        }

        private void OrderViewList_Load(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource { DataSource = presenter };

            clientLookUpEdit.Properties.DataSource = presenter.ClientList;
            orderStatusLookUpEdit.Properties.DataSource = presenter.StatusEnum;

            orderNumberTextEdit.DataBindings.Add("EditValue", binding, "OrderNumber");
            
            orderDateEdit.DataBindings.Add("EditValue", binding, "Date");
            orderGridControl.DataBindings.Add("DataSource", binding, "OrderItems");
            orderGridControl.RefreshDataSource();
            orderGridControl.DataSource = presenter.OrderItems;

            commentsListBox.DataBindings.Add("DataSource", binding, "Comments");            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void orderSaveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Save();
        }

        private void orderSaveAndNewBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.SaveAndNew();
        }

        private void ClearBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Clear();
        }

        public void ShowView()
        {
            Show();
        }
    }
}