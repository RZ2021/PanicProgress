using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Panic_Progress
{
    public partial class WordPlayMap : Form
    {

        private readonly int index, userLevel;
        private int levelName;
        private readonly string loggedIn;
        
        
        public WordPlayMap(string user, int level, int index)
        {
            InitializeComponent();
            //Gets username, level, and user index
            this.userLevel = level;
            loggedIn = user;
            this.index = index;

        }

        private void ssPenmanShip_Click(object sender, EventArgs e)
        {
            //Opens level 1
            levelName = 1;
            WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
            wpf.Show();
            this.Close();

        }

        private void theVillage_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance
            if (userLevel >= 2)
            {
                levelName = 2;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete level one to advance.");
            }
            
        }

        private void writerBlockBlockade_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance
            if (userLevel >= 3)
            {
                levelName = 3;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
           
        }

        private void hollowHills_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance
            if (userLevel >= 4)
            {
                levelName = 4;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
           
        }

        private void deadwoodForrest_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 5)
            {
                levelName = 5;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        private void writersCabin_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 6)
            {
                levelName = 6;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        private void imaginationTrain_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 7)
            {
                levelName = 7;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        private void inkwellIgloo_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 8)
            {
                levelName = 8;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        private void mountPro_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 9)
            {
                levelName = 9;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        private void theLakes_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 10)
            {
                levelName = 10;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        private void theLibrary_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 11)
            {
                levelName = 11;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit button
            this.Close();
        }

        private void readingRainbow_Click(object sender, EventArgs e)
        {
            //Opens level if player has high enough level to advance

            if (userLevel >= 12)
            {
                levelName = 12;
                WordPlayFight wpf = new WordPlayFight(loggedIn, userLevel, index, levelName);
                wpf.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot go here yet, complete the prior level to advance.");
            }
        }

        
    }
}
