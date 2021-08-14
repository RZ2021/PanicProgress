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
    public partial class MainMenu : Form
    {
        public string loggedIn;
        private int level, index;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PPButton_Click(object sender, EventArgs e)
        {
            //Opens up panic progress freewrite
            NewFile pp = new NewFile();
            pp.Show();
        }

        private void wpButton_Click(object sender, EventArgs e)
        {
            //Opens up Word Play if the user is logged in
            if(loggedIn == null)
            {
                MessageBox.Show("Please login to use Word Play!");
            }
            else
            {
                WordPlayMap wpm = new WordPlayMap(loggedIn, level, index);
                wpm.Show();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Shuts down entire program
            Environment.Exit(0);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Opens login form
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        public void GetData(string user, int lvl)
        {
            //Gets user data
            string[] splitting = user.Split(',');
            loggedIn = splitting[0];
            index = Convert.ToInt32(splitting[1]);
            level = lvl;
            userNameLabel.Text = loggedIn;

        }
        
    }
}
