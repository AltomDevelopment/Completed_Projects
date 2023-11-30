using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteHealthApp
{
    internal class DisplayData
    {

        GatherData gatherData = new GatherData();
        public void HamburgerMenu()
        {
            //Logged into the application after the CheckPasswordLogin method completed. You are now working with one individual user 
            //This menu needs to update based on if the user already has routines, a workoutplan or a business. 
            Console.WriteLine("Welcome to the application " /*+ users.userName*/);
            Console.WriteLine("[1] Add a Routine\n" +
                              "[2] Add a WorkoutPlan\n" +
                              "[3] Add your Business\n" +
                              "[4] Exit \n" +
                              "Type the number corresponding to what you want to do and press\"Enter\"");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    gatherData.GatherRoutineData();
                    gatherData.GatherRoutineTaskData();
                    gatherData.DisplayRoutine();
                    DisplayHomeScreen();
                    break;
                case 2:
                    Console.Clear();
                    gatherData.GatherWorkoutPlanData();
                    gatherData.GatherExerciseData();
                    DisplayHomeScreen();
                    break;
                case 3:
                    Console.Clear();
                    gatherData.GatherBusinessData();
                    DisplayHomeScreen();
                    break;
                case 4:
                    Console.Clear();
                    DisplayHomeScreen();
                    DisplayHomeScreen();
                    break;
            }

        }

        public void DisplayHomeScreen()
        {
            Console.WriteLine("Type 1 for the menu");
            Console.WriteLine("Your objects will be displayed here after they are created\n\n\n ");

            UpdateHomeScreen();
            
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                HamburgerMenu();
            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }
        }

        public void UpdateHomeScreen()
        {
            //Each time you login or come across the home screen it should update with routines, workout etc.
            //You need to check if the lists are empty or not 
            if (gatherData.routineList.Count > 0)
            {
                gatherData.DisplayRoutine();
                Console.WriteLine("Type 1 for the menu");
            }
            if (gatherData.exercisesPerWorkoutList.Count > 0)
            {
                gatherData.DisplayWorkoutPlanData();
            }
            if (gatherData.exercisesPerWorkoutList.Count > 0)
            {
                gatherData.DisplayExerciseData();
            }
            else { Console.WriteLine("You Don't have any tasks to view yet"); }
            


            
            
            
        }
       
    }
}
