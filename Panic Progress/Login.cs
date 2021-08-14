using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panic_Progress
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Back to main menu
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void nuButton_Click(object sender, EventArgs e)
        {
            //Opens up new user form
            NewUser nu = new NewUser();
            nu.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Verifies login credientials
            string username = unTB.Text;
            string pass = passTB.Text;

            Users us = new Users(username, pass);
            bool success = us.Login();

            if (success)
            {
                MessageBox.Show("You've logged in successfully!");
                this.Close();
                
            }
            else
            {
                errorLabel.Text = "Username/Password is incorrect";
            }
        }
    }
}
