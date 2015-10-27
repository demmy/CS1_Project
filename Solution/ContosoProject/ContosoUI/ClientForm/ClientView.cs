using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.EditForm.Helpers;

namespace ContosoUI.ClientForm
{
    public partial class ClientView : DevExpress.XtraBars.Ribbon.RibbonForm, IClientView
    {
        private ClientPresenter _presenter;
        private BindingSource binding;
        
        public ClientView()
        {
            InitializeComponent();
            _presenter = new ClientPresenter(this, new ClientModel());
        }

        public ClientView(int id)
        {
            InitializeComponent();
            _presenter = new ClientPresenter(this, new ClientModel());

            _presenter.UseClientWithID(id);
        }

        private void clientViewList_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private void BindControls()
        {
            binding = new BindingSource() { DataSource = _presenter};

            clientFirstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
            сlientMiddleNameTextEdit.DataBindings.Add("EditValue", binding, "MiddleName");
            clientLastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");

            clientCityTextEdit.DataBindings.Add("EditValue", binding, "City");
            clientAddressTextBox.DataBindings.Add("Text", binding, "Address");
            сlientTelephonesListBoxControl.DataBindings.Add("DataSource", binding, "Telephones");

            сlientOrdersGridControl.DataBindings.Add("DataSource", binding, "Orders");
            clientCommentsListBoxControl.DataBindings.Add("DataSource", binding, "Comments");
        }

        public void ShowView()
        {
            Show();
        }

        public void ShowView(ClientPresenter presenter, int id)
        {
            _presenter = presenter;
            _presenter.UseClientWithID(id);
            Show();
        }

        private void clientBarSaveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.Save();
        }

        private void clientBarSaveAndNewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.SaveAndNew();
        }

        private void clientBarClearButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.Clear();
        }
    }
}