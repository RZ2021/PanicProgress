using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace Panic_Progress
{
    public partial class NewFile : Form
    {
        private int ranNum, count, wgChecked, stChecked, erChecked, disChecked, goals,
            mins, maxs, eraser;
        private double goal, words;
        private string initialText, erase, level;
        public NewFile()
        {
            InitializeComponent();
            label6.Text = "";
            modeNotes.Text = "Click HERE for more details \nabout each writing mode";
            wgChecked = 0;
            stChecked = 0;
            erChecked = 0;
            disChecked = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                //A while loop that makes sure the user inputs correct settings before calling the methods
                //Uses a list to gather correctly done settings from the user
                List<int> modes = new List<int>();
                bool check = true;
                while (check)
                {
                    //Word goal mode
                    if (wordGoalCB.Checked)
                    {
                        string temp = wordGoalTB.Text;
                        if (temp == null || temp == " ")
                        {
                            MessageBox.Show("Please fill out all applicable settings");
                            break;
                        }
                        else
                        {
                            bool isNumeric = int.TryParse(temp, out goals);
                            if (isNumeric)
                            {
                                modes.Add(1);
                            }
                            else
                            {
                                MessageBox.Show("Please enter numbers only for your word goal");
                                break;
                            }
                        }

                    }

                    //Surprise timer mode
                    if (surpriseCB.Checked)
                    {
                        string min = minTB.Text;
                        string max = maxTB.Text;
                        if (min == null || min == " " || max == null || max == " ")
                        {
                            MessageBox.Show("Please fill out all applicable settings");
                        }
                        else
                        {
                            bool isNumeric = int.TryParse(min, out mins);
                            bool isNumeric2 = int.TryParse(max, out maxs);
                            if (isNumeric && isNumeric2)
                            {
                                modes.Add(2);
                            }
                            else if (mins > maxs)
                            {
                                MessageBox.Show("Make sure your max time is higher than your min time");
                            }
                            else
                            {
                                MessageBox.Show("Please enter only numbers for min and max");
                                break;
                            }
                        }

                    }

                    //Eraser mode
                    if (eraserCB.Checked)
                    {
                        erase = eraserTB.Text;
                        if (erase == null || erase == " ")
                        {
                            MessageBox.Show("Please enter in all applicable settings");
                            break;
                        }
                        else
                        {
                            bool isNumeric = int.TryParse(erase, out eraser);
                            if (isNumeric)
                            {
                                modes.Add(3);
                            }
                            else
                            {
                                MessageBox.Show("Please enter only numbers for the eraser");
                                break;
                            }
                        }

                    }

                    //Distrations mode
                    if (distractCB.Checked)
                    {
                        level = distractTB.Text;
                        if (level == null || level == " ")
                        {
                            MessageBox.Show("Please enter in all applicable settings");
                        }
                        else
                        {
                            level = level.ToLower();
                            if (level == "easy" || level == "medium" || level == "hard")
                            {
                                modes.Add(4);
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid level");
                                break;
                            }
                        }
                    }

                    //If settings were correctly inputted, a code gets put into the list which is then checked, 
                    //Before calling the correct mode(s)
                    if (ghostCB.Checked)
                    {
                        GhostMode();
                    }

                    if (modes.Contains(1))
                    {
                        WordGoal(goals);
                    }

                    if (modes.Contains(2))
                    {
                        SurpriseTimer(mins, maxs);
                    }

                    if (modes.Contains(3))
                    {
                        EraserMode(eraser);
                    }

                    if (modes.Contains(4))
                    {
                        Distractions(level);
                    }

                    //Main textbox is enabled and the settings are not
                    mainTB.Enabled = true;
                    modesPanel.Enabled = false;
                    instructionsLabel.Visible = false;
                    settingsPanel.Enabled = false;
                    SaveTimer.Enabled = true;
                    SaveTimer.Interval = 3000;
                    wordGoalTB.Text = "";
                    minTB.Text = "";
                    maxTB.Text = "";
                    eraserTB.Text = "";
                    distractTB.Text = "";
                    break;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again");
            }

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            //Turns off all timers
            surpriseTimer.Enabled = false;
            SaveTimer.Enabled = false;
            pbValues.Enabled = false;
            progressBar.Enabled = false;
            eraserTimer.Enabled = false;
            mediumdTimer.Enabled = false;
            easydTimer.Enabled = false;
            hardTimer.Enabled = false;
            ghostTimer.Enabled = false;

            //Resets the interface incase distraction mode was chosen
            mainTB.Location = new Point(333, 94);
            mainTB.Size = new Size(750, 650);
            mainTB.Font = new Font("Moonbeam", 14);
            mainTB.ForeColor = Color.Black;
            titleLabel.ForeColor = Color.Black;
            startButton.BackColor = Color.Gainsboro;
            saveButton.BackColor = Color.Gainsboro;
            restartButton.BackColor = Color.Gainsboro;
            PB1.Visible = false;
            PB2.Visible = false;
            PB3.Visible = false;
            this.BackColor = Color.White;


            //Unchecks all the checkboxes
            wordGoalCB.Checked = false;
            surpriseCB.Checked = false;
            eraserCB.Checked = false;
            distractCB.Checked = false;
            ghostCB.Checked = false;

            //Allows the users to access the panels again
            modesPanel.Enabled = true;
            settingsPanel.Enabled = true;

            //Sets the progressbar to 0 again
            progressBar.Value = 0;

            //Asks the user if they want to clear the textbox as well
            DialogResult dr = MessageBox.Show("Do you want to clear your text as well?", "Clear Text", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                mainTB.Text = "";
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Save file dialog for the user to choose a name and location for their new text file
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string t1 = mainTB.Text;
                File.WriteAllText(path, t1);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modeNotes_Click(object sender, EventArgs e)
        {
            //Reveals detailed descriptions of each mode
            instructionsLabel.Visible = true;
            instructionsLabel.Text = "Word Goal: Set a word count \ngoal for you to hit \nSurprise Timer: Write to a random \ntimer" +
                " within a range of minutes \nEraser Mode: For every twenty \nseconds you don't write, a number \nof words will disappear \nDistractions" +
                " Mode: Try to write as \neverything around you changes \nGhost Mode: Write while your \nwords flicker " +
                "in and out like a ghost";
        }

        private void WordGoal(int wordGoal)
        {
            progressBar.Enabled = true;
            progressBar.Visible = true;
            //Sets the progress bar timer to update every five seconds
            pbValues.Interval = 3000;
            pbValues.Enabled = true;

            goal = wordGoal;

        }

        private void SurpriseTimer(int min, int max)
        {
            //Gets a random number to set the timer to make it a surprise for the user
            min = min * 60 * 1000;
            max = max * 60 * 1000;
            Random rnd = new Random();
            ranNum = rnd.Next(min, max);

            //Starts the timer
            surpriseTimer.Interval = ranNum;
            surpriseTimer.Enabled = true;
        }

       

        private void EraserMode(int wordEraser)
        {
            //Sets the timer to a certain time depending on the level of difficulty
            eraserTimer.Interval = 20000;
            eraserTimer.Enabled = true;

            //At each timer tick, if certain conditions are met, a certain number of words will disappear
            words = wordEraser;
        }

        public void Distractions(string difficulty)
        {
            //Depending on the difficulty, a certain timer is started that will have distractions going off each tick
            if (difficulty == "easy")
            {
                easydTimer.Enabled = true;
                easydTimer.Interval = 15000;
            }
            else if (difficulty == "medium")
            {
                easydTimer.Enabled = true;
                easydTimer.Interval = 15000;

                mediumdTimer.Enabled = true;
                mediumdTimer.Interval = 10000;
            }
            else if (difficulty == "hard")
            {
                easydTimer.Enabled = true;
                easydTimer.Interval = 15000;

                mediumdTimer.Enabled = true;
                mediumdTimer.Interval = 10000;

                hardTimer.Enabled = true;
                hardTimer.Interval = 5000;

            }
        }
        private void GhostMode()
        {
            //Enables the timer that will made the words in the textbox go invisible
            ghostTimer.Enabled = true;
            ghostTimer.Interval = 3000;

            Ghost2Timer.Enabled = true;
            Ghost2Timer.Interval = 5000;
        }

        private void Ghost2Timer_Tick(object sender, EventArgs e)
        {
            //Sets the text to black so the user can see their words for a couple seconds
            mainTB.ForeColor = Color.Black;
        }

        private void surpriseTimer_Tick(object sender, EventArgs e)
        {
            //Alerts the user to the end of the random timer and turns them off
            int timerSecs = ranNum / 1000;
            MessageBox.Show("Times up! You wrote for " + timerSecs + " seconds." );
            surpriseTimer.Enabled = false;
            SaveTimer.Enabled = false;
        }


        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            //Saves a draft of the users text to the desktop
            string path = "C:/Users/royet/Desktop/draft.txt";
            string t1 = mainTB.Text;
            File.WriteAllText(path, t1);
            
        }

        private void eraserTimer_Tick(object sender, EventArgs e)
        {
            //If the user hasn't written anything during the length of the timer tick, a certain amount of words
            //are deleted as punishment
            string currentText = mainTB.Text;

            if (String.Equals(currentText, initialText))
            {
                int length = mainTB.TextLength;

                string newText = currentText.Remove(length - (int)words);
                mainTB.Text = newText;

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
                mainTB.Font = new Font("Parry Hotter", 18);
                titleLabel.ForeColor = Color.Red;

            }
            else if (fontNum == 2)
            {
                this.BackColor = Color.Purple;
                mainTB.Font = new Font("STCaiyun", 14);
                titleLabel.ForeColor = Color.Yellow;
            }
            else if (fontNum == 3)
            {
                this.BackColor = Color.Black;
                mainTB.Font = new Font("Cracked Johnnie", 16);
                titleLabel.ForeColor = Color.Orange;
            }
            else if (fontNum == 4)
            {
                this.BackColor = Color.Yellow;
                mainTB.Font = new Font("Distant Galaxy", 12);
                titleLabel.ForeColor = Color.Brown;
            }
            else if (fontNum == 5)
            {
                this.BackColor = Color.CornflowerBlue;
                mainTB.Font = new Font("fingerpop", 22);
                titleLabel.ForeColor = Color.Green;
            }
            else if (fontNum == 6)
            {
                this.BackColor = Color.Red;
                mainTB.Font = new Font("Freestyle script", 26);
                titleLabel.ForeColor = Color.Purple;
            }
        }

        private void mediumdTimer_Tick(object sender, EventArgs e)
        {
            //Gets a random number that changes various parts of the interface as a distraction
            PB1.Visible = true;
            PB2.Visible = true;
            PB3.Visible = true;

            Random rand = new Random();
            int num = rand.Next(1, 4);
            int tbSize = rand.Next(51, 751);

            if (num == 1)
            {
                PB1.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster2.png");
                mainTB.Size = new Size(719, tbSize);
                startButton.BackColor = Color.Red;
                saveButton.BackColor = Color.MediumPurple;
                restartButton.BackColor = Color.Gold;


            }
            else if (num == 2)
            {
                PB3.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster3.png");
                PB2.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster4.png");
                mainTB.Size = new Size(719, tbSize);
                startButton.BackColor = Color.Blue;
                saveButton.BackColor = Color.GreenYellow;
                restartButton.BackColor = Color.DarkGray;

            }
            else if (num == 3)
            {
                PB1.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster4.png");
                PB2.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster3.png");
                PB3.Image = Image.FromFile("C:/Users/royet/source/repos/Panic Progress/Images/Monster2.png");
                mainTB.Size = new Size(719, tbSize);
                startButton.BackColor = Color.Orange;
                saveButton.BackColor = Color.DarkKhaki;
                restartButton.BackColor = Color.Black;

            }
        }

        private void hardTimer_Tick(object sender, EventArgs e)
        {
            //Gets random numbers that changes various parts of the interface as a distraction
            Random rand = new Random();
            int num = rand.Next(1, 5);
            int xNum = rand.Next(50, 400);
            int yNum = rand.Next(50, 800);

            if (num == 1)
            {
                mainTB.Location = new Point(xNum, yNum);
                mainTB.ForeColor = Color.Purple;
                MessageBox.Show("Are you finished with your writing yet?");
            }
            else if (num == 2)
            {
                mainTB.Location = new Point(xNum, yNum);
                mainTB.ForeColor = Color.White;

            }
            else if (num == 3)
            {
                mainTB.Location = new Point(xNum, yNum);
                mainTB.ForeColor = Color.Brown;

            }
            else if (num == 4)
            {
                mainTB.Location = new Point(xNum, yNum);
                mainTB.ForeColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Are you distracted yet?");
            }
        }

        private void ghostTimer_Tick(object sender, EventArgs e)
        {
            //Turns the text the same color as the background so that the user can't see it 
            mainTB.ForeColor = Color.MistyRose;
        }

        private void pbValues_Tick(object sender, EventArgs e)
        {
            try
            {
                //Updates the progress bar (when applicable) based on the level's goal and the users current word count
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;

                string words = mainTB.Text;
                count = words.Split(' ').Length;

                if (progressBar.Value >= 100)
                {
                    progressBar.Enabled = false;
                    pbValues.Enabled = false;
                }
                else
                {
                    double pbValue = count / goal * 100;

                    if (pbValue > 100)
                    {
                        progressBar.Value = 100;
                    }
                    else
                    {
                        progressBar.Value = (int)pbValue;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again");
            }
            
        }

        private void surpriseCB_CheckedChanged(object sender, EventArgs e)
        {
            //If the user selects this mode the correct textbox is enabled to allow them to choose settings

            if (stChecked == 0)
            {
                minTB.Enabled = true;
                maxTB.Enabled = true;
                stChecked = 1;
                minTB.Text = "";
                maxTB.Text = "";
            }
            else
            {
                minTB.Enabled = false;
                maxTB.Enabled = false;
                stChecked = 0;
                minTB.Text = "";
                maxTB.Text = "";
            }
        }

        private void eraserCB_CheckedChanged(object sender, EventArgs e)
        {
            //If the user selects this mode the correct textbox is enabled to allow them to choose settings

            if (erChecked == 0)
            {
                eraserTB.Enabled = true;
                erChecked = 1;
                eraserTB.Text = "";
            }
            else
            {
                eraserTB.Enabled = false;
                erChecked = 0;
                eraserTB.Text = "";

            }
        }

        private void distractCB_CheckedChanged(object sender, EventArgs e)
        {
            //If the user selects this mode the correct textbox is enabled to allow them to choose settings
            if (disChecked == 0)
            {
                distractTB.Enabled = true;
                disChecked = 1;
                distractTB.Text = "";
            }
            else
            {
                distractTB.Enabled = false;
                disChecked = 0;
                distractTB.Text = "";

            }
        }

        private void wordGoalCB_CheckedChanged(object sender, EventArgs e)
        {
            //If the user selects this mode the correct textbox is enabled to allow them to choose settings
            if (wgChecked == 0)
            {
                wordGoalTB.Enabled = true;
                wgChecked = 1;
            }
            else
            {
                wordGoalTB.Enabled = false;
                wgChecked = 0;
            }
        }
    }
    
}
