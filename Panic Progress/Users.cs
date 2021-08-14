using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Panic_Progress
{
    class Users
    {
        string userName, passwordOne, passwordTwo;
        public string loggedIn;
        readonly int avatar;
        List<string> data = new List<string>();

        public Users(string user, string passOne, string PassTwo, int avatar)
        {
            //Constructor for new user
            userName = user;
            passwordOne = passOne;
            passwordTwo = PassTwo;
            this.avatar = avatar;
            GetUsers();
        }

        public Users(string user, string pass)
        {
            //Consturctor for logging in
            userName = user;
            passwordOne = pass;
            GetUsers();

        }

        public Users(string user)
        {
            //Constructor for getting user data
            userName = user;
            GetUsers();
        }

        private void GetUsers()
        {
            //Gets user info from textfile and puts it into list Data
            string[] lines = File.ReadAllLines(@"C:\Users\royet\source\repos\Panic Progress\users.txt");
            foreach (string line in lines)
            {
                data.Add(line);
            }
        }

        public bool Login()
        {
            //Verifies login credentials username and password
            int index = data.IndexOf(userName);
            if (index == -1)
            {
                return false;
            }
            else if (data[index + 1] != passwordOne)
            {
                return false;
            }
            else if (data[index+1] == passwordOne)
            {
                loggedIn = userName;
                int ind = data.IndexOf(loggedIn);
                int level = Convert.ToInt32(data[ind + 2]);
                loggedIn = userName + "," + index.ToString();

                MainMenu mm = new MainMenu();
                mm.GetData(loggedIn, level);
                mm.Show();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LevelUpdate(int newLevel, int index)
        {
            //Updates the users level if they beat a new level
            if(index >= 0)
            {
                data.RemoveAt(index + 2);
                data.Insert(index + 2, newLevel.ToString());
                File.WriteAllLines(@"C:\Users\royet\source\repos\Panic Progress\users.txt", data);
            }
            
        }

        public int getAvatar(int index)
        {
            //Gets the users chosen avatar 
            int avatar = Convert.ToInt32(data[index + 3]);
            return avatar;
        }

        public int NewUser()
        {  
            //Creates a new user and updates user textfile
            bool result = data.Contains(userName);
            string startingLevel = "1";

            if (result)
            {
                return 1;
            }
            else if (passwordOne != passwordTwo)
            {
                return 2;
            }
            else
            {
                string[] newUser = { userName, passwordOne, startingLevel, avatar.ToString() };
                File.AppendAllLines(@"C:\Users\royet\source\repos\Panic Progress\users.txt", newUser);
                return 3;
            }
        }
    }
}
 
