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
        public static User CurrentUser { get; private set; }

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
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IUserRepository userRepo = new EFUserDAO();
            var users = userRepo.GetAll().ToList();
            var user = users.Where(x => Hashing.MatchHash(x.Password, passwordTextEdit.Text));
            if (users.Any())
            {
                CurrentUser = user.First();
                MainForm main = Program.MainForm;
                Program.OpenMainFormOnClose = true;
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
