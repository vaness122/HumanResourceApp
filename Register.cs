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
    public partial class Register : Form
    {

    private readonly IUserRepository _userRepository;

        public Register(IUserRepository userRepository)
            {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void Reg_ToLogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login(_userRepository);
            log.Show();
        }

        private void X_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reg_Btn_Click(object sender, EventArgs e)
        {
            string Username = User_RegTxt.Text;
            string Password = Password_RegTxt.Text;

            try
            {
                _userRepository.AddUser(Username, Password);
                MessageBox.Show("User registered successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ ex.Message);
            }



        }
    }
}
