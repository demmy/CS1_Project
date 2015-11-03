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
using DevExpress.XtraGrid.Views.Grid;
using Domain.Entities.Comments;

namespace ContosoUI.CategoryForm
{
    public partial class CategoryView : DevExpress.XtraBars.Ribbon.RibbonForm, ICategoryView
    {
        private CategoryPresenter presenter;
        private BindingSource binding = new BindingSource();

        public CategoryView()
        {
            InitializeComponent();
            presenter = new CategoryPresenter(this, new CategoryModel());
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            binding.DataSource = presenter;

            categoryGridControl.DataBindings.Add("DataSource", binding, "Categories");
            categoryCommentsListBoxControl.DataBindings.Add("DataSource", binding, "CategoryComments");
        }

        private void saveBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Save();
        }

        private void saveAndNewBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.SaveAndNew();
        }

        private void newBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.New();
        }

        private void addNewCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addNewCommentTextEdit.Text) && presenter.CategoryComments.Count != 0)
            {
                Comment comment = new Comment() { Author = null, EntityType = EntityType.Category, Text = addNewCommentTextEdit.Text };
                List<Comment> newComments = presenter.CategoryComments.ToList();
                newComments.Add(comment);
                presenter.CategoryComments = new BindingList<Comment>(newComments);
                presenter.Save();
                addNewCommentTextEdit.Text = string.Empty;
            }
        }

        private void addNewCategorySimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void addNewCommentTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                addNewCommentButton_Click(this, e);
            }
        }

        private void categoryGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            categoryCommentsListBoxControl.DataBindings.Clear();
            GridView view = (GridView)sender;

            int id = (int)view.GetRowCellValue(e.FocusedRowHandle, "Id");
            presenter.UseCategoryWithID(id);
            categoryCommentsListBoxControl.DataBindings.Add("DataSource", binding, "CategoryComments");
        }
    }
}