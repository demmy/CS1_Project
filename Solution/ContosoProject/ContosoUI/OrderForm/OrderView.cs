using System;
using System.Windows.Forms;

namespace ContosoUI.OrderForm
{
    public partial class OrderForm : DevExpress.XtraBars.Ribbon.RibbonForm, IOrderView
    {
        private OrderPresenter _presenter;
        private BindingSource binding;

        public OrderForm()
        {
            InitializeComponent();
            _presenter = new OrderPresenter(new OrderModel(), this);
        }

        public OrderForm(int id)
        {
            InitializeComponent();
            _presenter = new OrderPresenter(new OrderModel(), this);
        }

        private void OrderViewList_Load(object sender, EventArgs e)
        {
            binding = new BindingSource { DataSource = _presenter };

            clientLookUpEdit.Properties.DataSource = _presenter.ClientList;
            orderStatusLookUpEdit.Properties.DataSource = _presenter.StatusEnum;
            orderNumberTextEdit.DataBindings.Add("EditValue", binding, "OrderNumber");
            
            orderDateEdit.DataBindings.Add("EditValue", binding, "Date");
            orderGridControl.DataBindings.Add("DataSource", binding, "OrderItems");
            commentsListBox.DataBindings.Add("DataSource", binding, "Comments");
        }

        private void orderSaveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.Save();
        }

        private void orderSaveAndNewBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.SaveAndNew();
        }

        private void ClearBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.Clear();
        }

        public void ShowView()
        {
            Show();
        }

        public void ShowView(OrderPresenter presenter)
        {
            _presenter = presenter;
            Show();
        }
    }
}