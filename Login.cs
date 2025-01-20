using HumanResource.DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceApp
{
   
    public partial class Login : Form
    {

        private readonly IUserRepository _userRepository;
        public Login(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void Log_ToRegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register(_userRepository);
            reg.Show();
        }

        private void X_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            string Username = User_LogTxt.Text;
            string Password = Password_LogTxt.Text;

            try
            {
                bool isAuthenticated = _userRepository.AuthenticUser(Username, Password);
                if (isAuthenticated)
                {
                    MessageBox.Show("Login is Successful");
                    this.Hide();
                    UserDashboard userDashboard = new UserDashboard (_userRepository, Username);
                    userDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }
    }
}

