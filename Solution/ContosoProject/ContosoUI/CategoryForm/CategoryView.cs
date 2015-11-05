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
using Domain.Entities.Products;

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

            categoryGridControl.DataBindings.Add("DataSource", binding, "Categories", false, DataSourceUpdateMode.OnPropertyChanged);
            //categoryCommentsListBoxControl.DataBindings.Add("DataSource", binding, "Comments", false, DataSourceUpdateMode.OnPropertyChanged);
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
            if (!string.IsNullOrEmpty(addNewCommentTextEdit.Text))
            {
                Comment comment = new Comment() { Author = Program.AuthUser, EntityType = EntityType.Category, Text = addNewCommentTextEdit.Text };
                List<Comment> newComments = presenter.Comments.ToList();
                newComments.Add(comment);
                presenter.Comments = new BindingList<Comment>(newComments);
                presenter.Save();
                addNewCommentTextEdit.Text = string.Empty;
            }
        }

        private void addNewCategorySimpleButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCategoryTextEdit.Text))
            {
                presenter.AddCategoryWithTitle(newCategoryTextEdit.Text);
                newCategoryTextEdit.Text = string.Empty;
                newCategoryPopupControlContainer.HidePopup();
            }
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
            categoryCommentsListBoxControl.DataBindings.Add("DataSource", binding, "Comments", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}