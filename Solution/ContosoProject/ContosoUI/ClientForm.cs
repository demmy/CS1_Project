using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.DummyData;
using Domain.Entities;
using Domain.Entities.Comments;

namespace ContosoUI
{
    public partial class ClientForm : Form
    {
        private static readonly int GENERATED_ID = 5;
        private Client _client;
        private DummyDAOForOrder _orders = new DummyDAOForOrder();
        private DummyDAOForComment _comments = new DummyDAOForComment();
        private DummyDAOForClient _clients = new DummyDAOForClient();
        public ClientForm(Client clientToShow)
        {
            _client = clientToShow;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            FillControls();
        }

        private void FillControls()
        {
            firstNameTextBox.Text = _client.Person.FirstName;
            middleNameTextBox.Text = _client.Person.MiddleName;
            lastNameTextBox.Text = _client.Person.LastName;
            cityTextBox.Text = _client.ClientLocation.City;
            adressRichTextBox.AppendText(_client.ClientLocation.Adress);
            foreach (var telephone in _client.Telephones)
            {
                telephonesRichTextBox.AppendText(telephone);
            }
            ordersGridView.DataSource = _orders.GetByClient(_client);
            //here's will be getting comments for this client and adding it to richtextbox
            isActiveCheckBox.Checked = _client.IsActive;
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(newCommentTextBox.Text))
            _comments.Create(new Comment() { Date = DateTime.Now, EntityType = EntityType.Client, Id = GENERATED_ID, IsActive = true, Text = newCommentTextBox.Text, User = null});
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
