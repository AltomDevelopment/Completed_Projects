using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteHealthApp
{
    internal class WorkingData
    {   
        //Class for displaying and working with the data.

        //Work through bug of storing the users credentals after sign up and then logging in. 
        int loginAttemptMax = 5;
        GatherData gatherData = new GatherData();
        public void LoginMenu()
        {
            ApplicationUser applicationUser = new ApplicationUser("sampleuser", "sampleuser", "sampleuser", "sampleuser", "sampleuser");
            gatherData.users.Add(applicationUser);
            Console.WriteLine("Welcome to the application: Type 1 to login, Type 2 to sign up");
            
            string userInput = Console.ReadLine();
            int input = Convert.ToInt32(userInput);
            if (input == 1)
            {
                Console.WriteLine("Enter your UserName");
                string userName = Console.ReadLine();
                CheckUserNameLogin(userName);
            }
            if (input == 2)
            {
                gatherData.GatherSignUpInformation();
            }
            else 
            {
                Console.WriteLine("The vale you entered is not valid");
            }
        }//The logic of going from one method to another should be kept to the program class as much as possible
        //Amethod should do one thing and do it well. 
        public void CheckUserNameLogin(string userName)
        {
            foreach (ApplicationUser user in gatherData.users)//creating multiple applicationuserobjects
            {
                if (user.userName == userName)
                {
                    Console.WriteLine("Enter your PassWord");
                    string password = Console.ReadLine();
                    CheckUserPasswordLogin(password);
                }
                else if (user.userName != userName && loginAttemptMax > 0)
                {
                    loginAttemptMax--;
                    Console.WriteLine("The userName you entered is incorrect\n" +
                        "You have " + Convert.ToString(loginAttemptMax) + "attempts remianing");
                }
                else
                {
                    Console.WriteLine("You have no login attempts remaining.");
                }
            }
        }

        public void CheckUserPasswordLogin(string passWord)
        {
            foreach (ApplicationUser user in gatherData.users)
            {
                if (user.passWord == passWord)
                {
                    DisplayData displayData = new DisplayData();
                    Console.Clear();
                    displayData.DisplayHomeScreen();
                }
                else if (user.passWord != passWord && loginAttemptMax > 0)
                {
                    loginAttemptMax--;
                    Console.WriteLine("The Password you entered is incorrect\n" +
                        "You have " + Convert.ToString(loginAttemptMax) + "attempts remianing");
                }
                else
                {
                    Console.WriteLine("You have no login attempts remaining.");
                }
            }
        }

        
        
    }
}
