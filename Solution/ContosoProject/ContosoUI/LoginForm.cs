using Data.DummyData;
using Domain.DAO;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IUserRepository userRepo = new DummyDAOForUser();
            IList<User> users = userRepo.GetAll().ToList();

            if (users.Where(x => x.Login == loginTextEdit.Text && x.Password == passwordTextEdit.Text).Any())
            {
                MainForm main = Program.MainForm;
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalide login or password", "Warning!");
            }

                   
        }
    }
}
