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
    public partial class NewUser : Form
    {
        private int avatarNum;
        private int n;
        public NewUser()
        {
            InitializeComponent();
            avatarNum = 1;
        }

        private void rightLabel_Click(object sender, EventArgs e)
        {
            //Allows the user to browser avatar options
            if (avatarNum == 1)
            {
                avatarNum = 2;
                avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Ninjas.png");
                avatarPicLabel.Text = "2. Novel Ninja";
            }
            else if (avatarNum == 2)
            {
                avatarNum = 3;
                avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Princesses.png");
                avatarPicLabel.Text = "3. Princess Pages";
            }
            else if(avatarNum == 3)
            {
                avatarNum = 1;
                avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Fighters.png");
                avatarPicLabel.Text = "1. Write Knight";
            }
        }

        private void leftLabel_Click(object sender, EventArgs e)
        {
            //Allows the user to browser avatar options
            if (avatarNum == 1)
            {
                avatarNum = 3;
                avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Princesses.png");
                avatarPicLabel.Text = "3. Princess Pages";
                
            }
            else if (avatarNum == 3)
            {
                avatarNum = 2;
                avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Ninjas.png");
                avatarPicLabel.Text = "2. Novel Ninja";
            }
            else if (avatarNum == 2)
            {
                avatarNum = 1;
                avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Fighters.png");
                avatarPicLabel.Text = "1. Write Knight";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Cancels new user
            DialogResult dr = MessageBox.Show("Are you sure you want to leave?", "Cancel", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifies user input is correct and creates a new user
                string un = unTB.Text;
                string p1 = pass1TB.Text;
                string p2 = pass2TB.Text;
                string av = avatarTB.Text;

                bool check = avatarCheck(av);
                if (check)
                {
                    Users us = new Users(un, p1, p2, n);

                    int result = us.NewUser();
                    if (result == 1)
                    {
                        errorLabel.Text = "This username has been taken";
                    }
                    else if (result == 2)
                    {
                        errorLabel.Text = "Passwords don't match";
                    }
                    else if (result == 3)
                    {
                        DialogResult dr = MessageBox.Show("Your character has been created! Go back to the main menu?", "Character Created", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            MainMenu mm = new MainMenu();
                            mm.Show();
                            this.Close();
                        }
                        else if (dr == DialogResult.No)
                        {
                            unTB.Text = "";
                            pass1TB.Text = "";
                            pass2TB.Text = "";
                            avatarTB.Text = "";
                            errorLabel.Text = "";
                        }

                    }
                }
                else
                {
                    errorLabel.Text = "Please enter a valid number for your avatar";
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Exit and try again.");
            }
            
        }

        private bool avatarCheck(string avatar)
        {
           //Checks to make sure user inputs a valid avatar number
            bool isNumeric = int.TryParse(avatar, out n);
            if(isNumeric)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit button
            this.Close();
        }
    }
}
