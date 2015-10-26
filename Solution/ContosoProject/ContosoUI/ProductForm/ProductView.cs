using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Domain.Entities.Comments;
using Domain.Entities.Products;

namespace ContosoUI.ProductForm
{
    public partial class ProductView : DevExpress.XtraBars.Ribbon.RibbonForm, IProductView
    {
        private ProductPresenter _presenter;
        private BindingSource _binding;

        public ProductView()
        {
            InitializeComponent();
        }

        public ProductView(int id)
        {
            InitializeComponent();
            ShowView(new ProductPresenter(this, new ProductModel()), id);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void ProductAddView_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private void BindControls()
        {
            _binding = new BindingSource() { DataSource = _presenter};

            productSKUTextEdit.DataBindings.Add("EditValue", _binding, "SKU");
            productTitleTextEdit.DataBindings.Add("EditValue", _binding, "Title");
            productQuantitySpinEdit.DataBindings.Add("Value", _binding, "Quantity");
            productPriceTextEdit.DataBindings.Add("EditValue", _binding, "Price");
            
            categoryLookUpEdit.Properties.DataSource = _presenter.Categories;
            categoryLookUpEdit.DataBindings.Add("EditValue", _binding, "Category");
            categorySearchControl.DataBindings.Add("EditValue", _binding, "SearchTitleCategory");
            productCommentsListBoxControl.DataBindings.Add("DataSource", _binding, "ProductComments");
            categoryGridControl.DataBindings.Add("DataSource", _binding, "Categories");
        }

        public void ShowView()
        {
            _presenter = new ProductPresenter(this, new ProductModel());
            Show();
        }

        public void ShowView(ProductPresenter presenter, int id)
        {
            _presenter = presenter;
            _presenter.UseProductWithID(id);
            Show();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");               
            }
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCommentTextBox.Text))
            {
                Comment comment = new Comment() { Author = null, EntityType = EntityType.Product, Text = newCommentTextBox.Text };
                _presenter.ProductComments.Add(comment);
            }
        }

        private void addCategoryCommetSimpleButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(categoryNewCommentTextBox.Text) && _presenter.CategoryComments.Count!=0)
            {
                Comment comment = new Comment() { Author = null, EntityType = EntityType.Category, Text = newCommentTextBox.Text };
                _presenter.CategoryComments.Add(comment);
            }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            categoryCommentsListBoxControl.DataBindings.Clear();
            
            if (e.HitInfo.InRow || e.HitInfo.InColumn)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                _presenter.UseCategoryCommentsByID(id);
                categoryCommentsListBoxControl.DataBindings.Add("DataSource", _binding, "CategoryComments");
            }
        }

        private void categorySearchControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            _binding.EndEdit();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrWhiteSpace(categorySearchControl.Text))
                    _presenter.Search();
                else
                {
                    _presenter.ViewAllCategories();
                }
            }
        }

        private void barRemoveRevertCategoryButton_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void simpleAddTitleButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCategoryTitletextEdit.Text))
            {
                _presenter.AddCategoryWithTitle(newCategoryTitletextEdit.Text);
                categoryGridView.Focus();
                popupControlContainer1.HidePopup();
                _presenter.SaveCategories();
            }
        }

        private void popupControlContainer1_CloseUp(object sender, EventArgs e)
        {
            newCategoryTitletextEdit.Text = string.Empty;
        }

        private void barSaveProductButton_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void newCategoryTitletextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                simpleAddTitleButton_Click(this, e);
            }
        }

        private void categoryGridControl_Leave(object sender, EventArgs e)
        {
            //if(_presenter.)
            //var messageResult = MessageBox.Show("Changes hasn't been saved. Save category changes?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (messageResult == DialogResult.Yes)
            //{
            //    SaveCategories();
            //    _presenter.ViewAllCategories();
            //}
        }

        private void SaveCategories()
        {
            _presenter.SaveCategories();
        }
    }
}