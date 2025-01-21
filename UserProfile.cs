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
    public partial class UserProfile : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly string _loggedInUsername;



        public UserProfile(IUserRepository userRepository, string Username)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _loggedInUsername = Username;
        }

        public IUserRepository UserRepository { get; }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"$Welcome , {_loggedInUsername}";
            Username_Label.Text = _loggedInUsername;

        }

        private void List_Users_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard dashboard = new UserDashboard(_userRepository, _loggedInUsername);
            dashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_User_Btn_Click(object sender, EventArgs e)
        {
                string newUsername = updateUsernameTextBox.Text;
                string newPassword = updatePassword_Btn.Text;

            if(string.IsNullOrWhiteSpace(newUsername)||string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill in both fields");
                return;
            }

            if(_loggedInUsername != newUsername)
            {
                _userRepository.UpdateUser(_loggedInUsername, newUsername);

            }

            _userRepository.UpdateUserPassword(newUsername,newPassword);

           
           
            MessageBox.Show("User info updated");

            



        }
    }
}
