using Data.DummyData;
using Domain.DAO;
using Data.EFRepository;
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

#if DEBUG
            loginTextEdit.Text = "Admin";
            passwordTextEdit.Text = "queryadmin";
#endif
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IUserRepository userRepo = new EFUserDAO();
            var hashedPass = Hashing.CreateHash(passwordTextEdit.Text);
            var user = userRepo.GetAll().FirstOrDefault(x => x.Login.Equals(loginTextEdit.Text) && x.Password.Equals(hashedPass));
            if (user != null)
            {
                Program.AuthUser = user;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
        }

        private void passwordTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                okButton_Click(sender, e);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
