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
    public partial class WordPlayFight : Form
    {
        private double count, goals;
        private int ranNum, words, levelName, index, lvl;
        private bool started;
        private string initialText, loggedIn;


        public WordPlayFight(string user, int level, int index, int levelName)
        {
            InitializeComponent();
            loggedIn = user;
            lvl = level;
            this.index = index;
            this.levelName = levelName;

            //Stops users from cheating by writing before the challenge starts
            mainTextbox.Enabled = false;
            started = false;

            //Sets label to correct instructions based on the level
            GetInstructions(levelName);

            //Sets up user avatar
            PlayerAvatar();
 
        }

        private void PlayerAvatar()
        {
            try
            {
                userNameLabel.Text = loggedIn;

                Users us = new Users(loggedIn);
                int avatar = us.getAvatar(index);

                if (avatar == 2)
                {
                    avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Ninjas.png");
                }
                else if (avatar == 3)
                {
                    avatarPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Princesses.png");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again");
            }
            
        }

        public void GetInstructions(int level)
        {
            //Sets label to correct instructions based on the level

            switch (level)
            {
                case 1:
                    instructionText.Text = "Welcome to the S S Penmanship! Write 500 words within 10 minutes to make it \nto shore alive!";
                    monsterName.Text = "Simile Sirens";
                    break;
                case 2:
                    instructionText.Text = "You've made it to the village in one piece! Write 500 words in 7 minutes " +
                        "to \ndestroy the monster blocking the gates of the village.";
                    monsterName.Text = "Dreadful Demon";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster11.png");
                    break;
                case 3:
                    instructionText.Text = "You try to take a short cut to the castle, but you're blocked by " +
                        "monsters. \nWrite as fast as you can to drive them away with this surprise timer.";
                    monsterName.Text = "Holden Caufield's Ghost";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster3.png");
                    break;
                case 4:
                    instructionText.Text = "You couldn't make it past the blockade, so now you must travel " +
                        "through the\n hollow hills. Write 350 words to fight your way through the hills";
                    monsterName.Text = "Synonym Syndrome";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster2.png");
                    break;
                case 5:
                    instructionText.Text = "You got lost after exiting hollow hills. Try and make your way through " +
                        "the \nDeadwood Forrest by writing through this surprise timer. Write for your life!";
                    monsterName.Text = "He Who Burned The \nLibrary of Alexandria";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster5.png");
                    break;
                case 6:
                    instructionText.Text = "You made it safely to the Writer's Cabin. Take a breather with this ten minute \n" +
                        "free write. But if you don't write 200 words there's a chance a monster could \ndrag you back to the forrest.";
                    monsterName.Text = "Block Bully";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster7.png");
                    break;
                case 7:
                    instructionText.Text = "You hop onto the imagination train, thinking you'd get a peaceful ride " +
                        "but \nmonsters have attacked the train with a few surprises. Write to this surpirse timer \nto defeat them.";
                    monsterName.Text = "Internet Trolls";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster8.png");
                    break;
                case 8:
                    instructionText.Text = "It's snowing so hard you can no longer anything but the last word you wrote, \nwrite 500 " +
                        "words within 7 minutes to get through the storm!";
                    monsterName.Text = "A Publishing Agent";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster6.png");
                    break;
                case 9:
                    instructionText.Text = "Mount Procrastination rumbles under your feet. Write for five minutes " +
                        "to get \npast it. But if you stop writing for more than 20 seconds, your words will start jumping " +
                        "into the volcano!";
                    monsterName.Text = "Verbose Gargoyle";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster4.png");
                    break;
                case 10:
                    instructionText.Text = "Time for an endurance swim across the lake! Write at least 850 in 20 minutes \n" +
                        "to cross the lake safely.";
                    monsterName.Text = "Pretentious Greg from \nCreative Writing class";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster9.png");
                    break;
                case 11:
                    instructionText.Text = "Someone has take over the library and is in the process of destorying it! " +
                        "Write at \nleast 700 in 15 minutes to drive them out of the library!";
                    monsterName.Text = "Mysterious Figure";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster10.png");
                    break;
                case 12:
                    instructionText.Text = "This is the final battle. There's no timer, but you must write " +
                        "1000 words to defeat \nthe boss. If you stop writing for more than ten seconds, the boss " +
                        "will destroy \nsome of your words.";
                    monsterName.Text = "A Blank Page";
                    monsterPB.Image = Image.FromFile(@"C:\Users\royet\source\repos\Panic Progress\Images\Monster12.png");
                    break;
            }
        }

        public void BasicMode(int time, int goal)
        {
            //Sets a time limit based off the level and it's difficulty
            TimeLimitTimer.Enabled = true;
            TimeLimitTimer.Interval = time;

            //Sets the progress bar timer to update every five seconds
            pbValues.Interval = 5000;
            pbValues.Enabled = true;

            goals = goal;

        }

        public void SurpriseTimers()
        {
            //Gets a random number to set the timer to make it a surprise for the user
            Random rnd = new Random();
            ranNum = rnd.Next(300000, 900000);

            //Starts the timer
            surpriseTimer.Interval = ranNum;
            surpriseTimer.Enabled = true;

        }

        public void Eraser(int diffSetting, int wordEraser)
        {
            //Sets the timer to a certain time depending on the level of difficulty
            thanosTimer.Interval = diffSetting;
            thanosTimer.Enabled = true;

            //At each timer tick, if certain conditions are met, a certain number of words will disappear
            words = wordEraser;
            
        }

        public void Distractions(string difficulty, int timeOne, int timeTwo, int timeThree)
        {
            //Depending on the difficulty, a certain timer is started that will have distractions going off each tick
            if (difficulty == "easy")
            {
                easydTimer.Enabled = true;
                easydTimer.Interval = timeOne;
            }
            else if (difficulty == "medium")
            {
                easydTimer.Enabled = true;
                easydTimer.Interval = timeOne;

                mediumdTimer.Enabled = true;
                mediumdTimer.Interval = timeTwo;
            }
            else if (difficulty == "hard")
            {
                easydTimer.Enabled = true;
                easydTimer.Interval = timeOne;

                mediumdTimer.Enabled = true;
                mediumdTimer.Interval = timeTwo;

                harddTimer.Enabled = true;
                harddTimer.Interval = timeThree;

            }
        }

        private void pbValues_Tick(object sender, EventArgs e)
        { 
            try
            {
                //Updates the progress bar (when applicable) based on the level's goal and the users current word count
                myProgressBar1.Minimum = 0;
                myProgressBar1.Maximum = 100;

                string words = mainTextbox.Text;
                count = words.Split(' ').Length;

                if (myProgressBar1.Value >= 100)
                {
                    myProgressBar1.Enabled = false;
                    pbValues.Enabled = false;
                }
                else
                {
                    double pbValue = (count / goals) * 100;

                    if (pbValue > 100)
                    {
                        myProgressBar1.Value = 100;
                    }
                    else
                    {
                        myProgressBar1.Value = (int)pbValue;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again");
            }


        }


        private void TimeLimitTimer_Tick(object sender, EventArgs e)
        {
            //When the time limit is up, the timer is turned off, the textbox is disabled, and the end is called
            //to determine whether the user passes the level or not
            TimeLimitTimer.Enabled = false;
            mainTextbox.Enabled = false;
            TheEnd();
        }

        private void surpriseTimer_Tick(object sender, EventArgs e)
        {
            //Once the surprise timer is done it alerts the user how long they wrote for and calls the end
            int timerSecs = ranNum / 1000;
            MessageBox.Show("Times up! You wrote for " + timerSecs + " seconds.");
            surpriseTimer.Enabled = false;

            TheEnd();
        }

        private void thanosTimer_Tick(object sender, EventArgs e)
        {
            //If the user hasn't written anything during the length of the timer tick, a certain amount of words
            //are deleted as punishment
            string currentText = mainTextbox.Text;

            if (String.Equals(currentText, initialText))
            {
                int length = mainTextbox.TextLength;

                string newText = currentText.Remove(length - words);
                mainTextbox.Text = newText;

                initialText = newText;
            } 
            else
            {
                initialText = currentText;
            }
            
            
        }

        private void easydTimer_Tick(object sender, EventArgs e)
        {
            //Gets a random number that changes various parts of the interface as a distraction
            Random rand = new Random();
            int fontNum = rand.Next(1, 7);

            if (fontNum == 1)
            {
                this.BackColor = Color.Green;
                mainTextbox.Font = new Font("Parry Hotter", 14);
                label1.ForeColor = Color.Red;

            }
            else if (fontNum == 2)
            {
                this.BackColor = Color.Purple;
                mainTextbox.Font = new Font("STCaiyun", 11);
                label1.ForeColor = Color.Yellow;
            }
            else if (fontNum == 3)
            {
                this.BackColor = Color.Black;
                mainTextbox.Font = new Font("Cracked Johnnie", 14);
                label1.ForeColor = Color.Orange;
            }
            else if (fontNum == 4)
            {
                this.BackColor = Color.Yellow;
                mainTextbox.Font = new Font("Distant Galaxy", 9);
                label1.ForeColor = Color.Brown;
            }
            else if (fontNum == 5)
            {
                this.BackColor = Color.CornflowerBlue;
                mainTextbox.Font = new Font("fingerpop", 16);
                label1.ForeColor = Color.Green;
            }
            else if (fontNum == 6)
            {
                this.BackColor = Color.Red;
                mainTextbox.Font = new Font("Freestyle script", 18);
                label1.ForeColor = Color.Purple;
            }
        }

        private void mediumdTimer_Tick(object sender, EventArgs e)
        {
            //Gets a random number that changes various parts of the interface as a distraction

            Random rand = new Random();
            int num = rand.Next(1, 4);
            int tbSize = rand.Next(51, 751);

            if(num == 1)
            {
                pictureBox4.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster2.png");
                mainTextbox.Size = new Size(719, tbSize);
                startButton.BackColor = Color.Red;
                saveButton.BackColor = Color.MediumPurple;
                doneButton.BackColor = Color.Gold;
                

            }
            else if (num == 2)
            {
                pictureBox6.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster3.png");
                pictureBox5.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster4.png");
                mainTextbox.Size = new Size(719, tbSize);
                startButton.BackColor = Color.Blue;
                saveButton.BackColor = Color.GreenYellow;
                doneButton.BackColor = Color.DarkGray;
                
            }
            else if (num == 3)
            {
                pictureBox4.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster4.png");
                pictureBox5.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster3.png");
                pictureBox6.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster2.png");
                mainTextbox.Size = new Size(719, tbSize);
                startButton.BackColor = Color.Orange;
                saveButton.BackColor = Color.DarkKhaki;
                doneButton.BackColor = Color.Black;
                
            }
        }

        private void harddTimer_Tick(object sender, EventArgs e)
        {
            //Gets random numbers that changes various parts of the interface as a distraction
            Random rand = new Random();
            int num = rand.Next(1, 5);
            int xNum = rand.Next(220, 256);
            int yNum = rand.Next(127, 170);

            if( num == 1)
            {
                mainTextbox.Location = new Point(xNum, yNum);
                mainTextbox.ForeColor = Color.Purple;
                MessageBox.Show("Are you finished with your writing yet?");
            } 
            else if (num == 2)
            {
                mainTextbox.Location = new Point(xNum, yNum);
                mainTextbox.ForeColor = Color.White;
                
            }
            else if (num == 3)
            {
                mainTextbox.Location = new Point(xNum, yNum);
                mainTextbox.ForeColor = Color.Brown;
                
            }
            else if (num == 4)
            {
                mainTextbox.Location = new Point(xNum, yNum);
                mainTextbox.ForeColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Are you distracted yet?");
            }
        }

        private void TheEnd()
        {
            try
            {
                //A function that checks whether the user met the level's goal, if so they get to progress to the 
                //next level, also it offers them a chance to save their work

                //Gets the current word count
                string words = mainTextbox.Text;
                count = words.Split(' ').Length;

                //Checks to see if they made their word count goal
                if (levelName == 9)
                {
                    if (TimeLimitTimer.Enabled == true)
                    {
                        Incomplete();
                    }
                    else
                    {
                        Complete();
                    }
                }
                else if (levelName == 3 || levelName == 5 || levelName == 7)
                {
                    if (surpriseTimer.Enabled == true)
                    {
                        Incomplete();
                    }
                    else
                    {
                        Complete();
                    }
                }
                else if (count > goals)
                {
                    Complete();
                }
                else
                {
                    Incomplete();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again");
            }
            
        }

        private void Complete()
        {
            //If so they can continue to the next level, which is updated in the textfile
            if(lvl == levelName)
            {
                lvl += 1;
                Users us = new Users(loggedIn);
                us.LevelUpdate(lvl, index);
            }

            //The user is congratulated and offers to take the user to the map and to save their work
            DialogResult dialogResult = MessageBox.Show("You've defeated the monster! Do you want to go back to the map?", "Leave", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dr = MessageBox.Show("Do you want to save before leaving?", "Save", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    saveText();
                    WordPlayMap wpm = new WordPlayMap(loggedIn, levelName, index);
                    wpm.Show();
                    this.Close();
                }
                else if (dr == DialogResult.No)
                {
                    WordPlayMap wpm = new WordPlayMap(loggedIn, levelName, index);
                    wpm.Show();
                    this.Close();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoSave_Tick(object sender, EventArgs e)
        {
            string path = "C:/Users/royet/Desktop/draft.txt";
            string t1 = mainTextbox.Text;
            File.WriteAllText(path, t1);
        }

        private void Incomplete()
        {
            //If they didn't complete the level, offers the user to save their work and go back to the map
            DialogResult dialogResult = MessageBox.Show("You have not defeated this monster, are you sure you want to leave?", "Leave", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dr = MessageBox.Show("Do you want to save before leaving?", "Save", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    saveText();
                    WordPlayMap wpm = new WordPlayMap(loggedIn, levelName, index);
                    wpm.Show();
                    this.Close();
                }
                else if (dr == DialogResult.No)
                {
                    WordPlayMap wpm = new WordPlayMap(loggedIn, levelName, index);
                    wpm.Show();
                    this.Close();
                }

            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            //The done button is their in case there is no timer in a level, they can hit this button to complete
            //the level

            if(started)
            {
                TheEnd();
            }
            else
            {
                MessageBox.Show("You have to complete the level");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                started = true;
                //Starts the level
                mainTextbox.Enabled = true;

                //Starts autsave timer to save the users work
                AutoSave.Enabled = true;
                AutoSave.Interval = 3000;

                //Sets up the correct level
                switch (levelName)
                {
                    case 1:
                        BasicMode(600000, 400);
                        break;
                    case 2:
                        BasicMode(420000, 300);
                        break;
                    case 3:
                        SurpriseTimers();
                        break;
                    case 4:
                        BasicMode(100000000, 350);
                        break;
                    case 5:
                        SurpriseTimers();
                        break;
                    case 6:
                        BasicMode(600000, 200);
                        break;
                    case 7:
                        SurpriseTimers();
                        Distractions("easy", 10000, 10000, 10000);
                        break;
                    case 8:
                        BasicMode(420000, 500);
                        break;
                    case 9:
                        BasicMode(300000, 0);
                        Eraser(20000, 15);
                        break;
                    case 10:
                        BasicMode(1200000, 850);
                        break;
                    case 11:
                        BasicMode(900000, 700);
                        Distractions("medium", 10000, 9000, 8000);
                        break;
                    case 12:
                        BasicMode(100000000, 1000);
                        Eraser(10000, 25);
                        break;
                    default:
                        MessageBox.Show("Something went wrong");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again");

            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //A manual save button
            saveText();
        }

        private void saveText()
        {
            //Save file dialog for the user to choose a name and location for their new text file
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string t1 = mainTextbox.Text;
                File.WriteAllText(path, t1);
            }
        }
    }
}
