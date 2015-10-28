﻿using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.EditForm.Helpers;
using Domain.Entities.Comments;

namespace ContosoUI.ClientForm
{
    public partial class ClientView : DevExpress.XtraBars.Ribbon.RibbonForm, IClientView
    {
        private ClientPresenter _presenter;
        private BindingSource _binding;
        
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
            _binding = new BindingSource() { DataSource = _presenter};

            clientFirstNameTextEdit.DataBindings.Add("EditValue", _binding, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
            сlientMiddleNameTextEdit.DataBindings.Add("EditValue", _binding, "MiddleName");
            clientLastNameTextEdit.DataBindings.Add("EditValue", _binding, "LastName");

            clientCityTextEdit.DataBindings.Add("EditValue", _binding, "City");
            clientAddressTextBox.DataBindings.Add("Text", _binding, "Address");
            сlientTelephonesListBoxControl.DataBindings.Add("DataSource", _binding, "Telephones");

            сlientOrdersGridControl.DataBindings.Add("DataSource", _binding, "Orders");
            clientCommentsListBoxControl.DataBindings.Add("DataSource", _binding, "Comments");
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
            _binding.EndEdit();
            _presenter.Save();
        }

        private void clientBarSaveAndNewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _binding.EndEdit();
            _presenter.SaveAndNew();
        }

        private void clientBarClearButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _binding.EndEdit();
            _presenter.Clear();
        }

        private void buttonAddNewTelephoneEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!string.IsNullOrEmpty(buttonAddNewTelephoneEdit.EditValue.ToString()))
            {
                _presenter.Telephones.Add(buttonAddNewTelephoneEdit.EditValue.ToString());
                buttonAddNewTelephoneEdit.EditValue = string.Empty;
            }
        }

        private void сlientAddCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(сlientNewCommentTextBox.Text))
            {
                _presenter.Comments.Add(new Comment() {Text =  сlientNewCommentTextBox.Text, EntityType = EntityType.Client, Author = null });
                сlientNewCommentTextBox.Text = string.Empty;
            }
        }
    }
}