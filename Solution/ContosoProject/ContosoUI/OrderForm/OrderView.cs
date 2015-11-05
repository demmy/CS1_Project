using DevExpress.XtraGrid.Views.Grid;
using Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Images;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Domain.Entities.Comments;
using Domain.Entities.Products;

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
            _presenter.UseOrderWithID(id);
        }

        private void OrderViewList_Load(object sender, EventArgs e)
        {
            repositoryQuantitySpinEdit.Validating += RepositoryQuantitySpinEditOnValidating;
            binding = new BindingSource {DataSource = _presenter};

            clientLookUpEdit.Properties.DataSource = _presenter.ClientList;
            orderStatusLookUpEdit.Properties.DataSource = _presenter.StatusEnum;
            orderNumberTextEdit.DataBindings.Add("EditValue", binding, "OrderNumber");

            orderDateEdit.DataBindings.Add("EditValue", binding, "Date");
            orderGridControl.DataBindings.Add("DataSource", binding, "OrderItems");
            commentsListBox.DataBindings.Add("DataSource", binding, "Comments");

            orderRepositoryProductLookUpEdit.DataSource = _presenter.Products;
            SetStateButtonState();

            SetActivityOfComments();
        }

        private void RepositoryQuantitySpinEditOnValidating(object sender, CancelEventArgs e)
        {

        }

        private void SetActivityOfComments()
        {
            if (orderNumberTextEdit.Text == string.Empty)
            {
                commentsListBox.Enabled = false;
                newCommentTextBox.Enabled = false;
                addCommentButton.Enabled = false;
            }
            else
            {
                commentsListBox.Enabled = true;
                newCommentTextBox.Enabled = true;
                addCommentButton.Enabled = true;
            }
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
            _presenter.New();
        }

        public void ShowView()
        {
            Show();
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCommentTextBox.Text))
            {
                Comment comment = new Comment() {Author = Program.AuthUser, EntityType = EntityType.Order, Text = newCommentTextBox.Text};
                _presenter.Comments.Add(comment);
                newCommentTextBox.Text = string.Empty;
                _presenter.Save();
            }
        }

        private void orderNumberTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetActivityOfComments();
        }

        private void orderGridControl_Click(object sender, EventArgs e)
        {

        }

        private void orderGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
        }

        private void barStateButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.State = !_presenter.State;
            SetStateButtonState();
        }

        private void SetStateButtonState()
        {
            if (_presenter.State)
            {
                barStateButton.Caption = "Remove";
                barStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png");
            }
            else
            {
                barStateButton.Caption = "Activate";
                barStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
            }
        }

        private void addOrderItemButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.OrderItems.Add(new OrderItem(new Product() {Title = "Chose product"}, 0, 0));

        }

        private void orderGridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void orderGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var view = sender as GridView;
            if (e.Column == colQuantity || e.Column == colProduct)
            {
                var product = (view.GetRowCellValue(e.RowHandle, "Product") as Product);
                if (product != null)
                {
                    repositoryQuantitySpinEdit.MaxValue = product.Quantity;
                }
            }
        }
    }
}