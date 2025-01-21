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
    public partial class UserDashboard : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly string _loggedInUsername;


        public UserDashboard(IUserRepository userRepository, string Username)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _loggedInUsername = Username;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome, {_loggedInUsername}!";
            Username_Label.Text = _loggedInUsername;



            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {

                var HRIUsers = _userRepository.GetAllUser();
                UserDataGridView.DataSource = HRIUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Users: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignOut_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_userRepository);
            login.Show();
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                string oldUsername = UserDataGridView.SelectedRows[0].Cells["Username"].Value.ToString();
                string newUsername = updateUsernameTextBox.Text;
                try
                {
                    _userRepository.UpdateUser(oldUsername, newUsername);
                    MessageBox.Show("User updated Successfully");

                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user" + ex.Message);
                }
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                string username = UserDataGridView.SelectedRows[0].Cells["Username"].Value.ToString();
                try
                {
                    _userRepository.DeleteUser(username);
                    MessageBox.Show("User deleted successfully");
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete");
            }
        }

        private void Profile_ToUserProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            UserProfile profile = new UserProfile(_userRepository, _loggedInUsername);
            profile.Show();
        }
    }

}
