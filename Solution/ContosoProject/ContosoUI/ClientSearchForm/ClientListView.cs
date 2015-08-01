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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ContosoUI.ClientSearchForm
{
    public partial class ClientListView : DevExpress.XtraBars.Ribbon.RibbonForm, IClientSearchView
    {
        private readonly ClientSearchPresenter presenter;

        public ClientListView()
        {
            InitializeComponent();
            presenter = new ClientSearchPresenter(this, new ClientSearchModel());
            clientsGridControl.DataSource = presenter.Clients;

            BindingSource binding = new BindingSource();
            binding.DataSource = presenter;

            clientCityTextEdit.DataBindings.Add("EditValue", binding, "City");
            clientFirstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            clientLastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            clientsGridControl.DataBindings.Add("DataSource", binding, "Clients");
        }

        private void addClientBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.AddClient();
        }

        private void searchClientBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.Search();
            RefreshForm();
        }

        private void clearClientBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.Clear();
            RefreshForm();
        }

        public void RefreshForm()
        {
            clientCityTextEdit.Text = presenter.City;
            clientFirstNameTextEdit.Text = presenter.FirstName;
            clientLastNameTextEdit.Text = presenter.LastName;
            clientsGridControl.DataSource = presenter.Clients;
        }

        private void clientsGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.EditClient(id);
            }
        }
    }
}