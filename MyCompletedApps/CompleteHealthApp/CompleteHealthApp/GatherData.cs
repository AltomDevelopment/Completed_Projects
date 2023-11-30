using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CompleteHealthApp.WorkoutPlan;

namespace CompleteHealthApp
{
    internal class GatherData
    {
        //Should be able to make use of garbage collection here, these variables are here to hold temporary data so the objects can be created
        //
        public List<ApplicationUser> users = new List<ApplicationUser>();
        public string routineName;
        public DateTime routineStartTime;
        public DateTime routineEndTime;
        public List<Routine> routineList = new List<Routine>();
        public List<RoutineTask> routineTaskList = new List<RoutineTask>();
        public List<List<RoutineTask>> routineTasksPerList = new List<List<RoutineTask>>();
        public List<Workout> workoutPlanList = new List<Workout>();
        public List<Exercises>? exerciseList = new List<Exercises>();
        public List<List<Exercises>>? exercisesPerWorkoutList = new List<List<Exercises>>();  
        public string businessName;
        public string businessIndustry;
        public DateTime businessHoursOfOperation;
        public string businessAddress;
        public string businessPhoneNumber;
        public string businessLogo;//use the path to the image file
        public int businessTaxIdNumber;
        public Business business;
        public string customerName;
        public string customerAddress;
        public string customerPhoneNumber;
        public string customerEmailAddress;
        public List<Customers> customerList;
        public string employeeName;
        public string employeeAddress;
        public string employeePhoneNumber;
        public string employeeEmailAddress;
        public int employeeSalary;
        public int employeeTimeWithCompany;
        public List<Employees> employeeList;
        public int invoiceID;
        public int invoiceSubtotal;
        public int invoiceTotal;
        public int invoiceAmountPaid;
        public List<Invoices> invoiceList;

        public void GatherSignUpInformation()
        {
            //Adds a sample user and gathers the new users information for the application
            
            Console.WriteLine("Welcome to the app, please sign up\n \n");
            Console.WriteLine("Enter a username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter a first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter a last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter a email: ");
            string email = Console.ReadLine();

            foreach (ApplicationUser person in users)
            {
                if (person.userName == username)
                {
                    Console.WriteLine("This username is taken already");
                }
                else if (person.eMail == email)
                {
                    Console.WriteLine("There is already an account for this user");
                }
                else
                {
                    ApplicationUser newUser = new ApplicationUser(username, password, firstName, lastName, email);
                    users.Add(newUser);
                }
            }
        }
        public void GatherRoutineData()
        {
            Console.WriteLine("Here you can setup a routine for whatever you might need a routine for.\n" +
                "Wether it's a set of tasks that you typically go through everymorning\n" +
                "a list of exercises that you complete every warmup before playing guitar,\n" +
                "or something else that you may need a structured list with the ability to\n" +
                "add timers to, to help you achieve your goals. Lets get started. Press Enter to Continue");
            Console.ReadLine();
            Console.WriteLine("Enter the name of your Routine: \"Example:Morning Routine\"");
            routineName = Console.ReadLine();
            Console.WriteLine("Enter the time your routine will start: Example: 10:00 AM (Make sure the formatting is correct)");
            routineStartTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the time your routine will end: Example: 12:00 pm (Make sure the formatting is correct)");
            routineEndTime = Convert.ToDateTime(Console.ReadLine());
            Routine routine = new Routine(routineName, routineStartTime, routineEndTime);
            routineList.Add(routine);
            Console.WriteLine("Enter all of the tasks you want to add to the Routine. when you are finished type Done");


        }

        public void GatherRoutineTaskData()
        {
            string task = Console.ReadLine();
            try
            {
                if (task.Equals("Done") != true)
                {
                    RoutineTask routineTask = new RoutineTask(task);
                    routineTaskList.Add(routineTask);
                    GatherRoutineTaskData();
                }
                else if (task.Equals("Done") == true)
                {
                    routineTasksPerList.Add(routineTaskList);
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DisplayRoutine()
        {
            //Console.Clear();
            Routine routine = routineList.Last<Routine>();
            Console.WriteLine("Here's the Routine you created.\n" + "");
            Console.WriteLine("Routine Name: " + routine.routineName);
            Console.WriteLine("Start Time: " + routine.routineStartTime);
            Console.WriteLine("End Time: " + routine.routineEndTime);

            foreach (RoutineTask tasks in routineTaskList)
            {
                Console.WriteLine(tasks.taskName);
            }
            Console.WriteLine("Hit enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void GatherWorkoutPlanData()
        {
            Console.WriteLine("Here you can setup a complete workout plan. We'll start by gathering details about your"
                + "\noverall workout plan and then allow you to add in exercises to the plan. Press Enter to Continue.");
            Console.ReadLine();
            Console.WriteLine("Enter the name of your Workout Program: Example: 12 Month Strength Training");
            string workoutProgramName = Console.ReadLine();
            Console.WriteLine("Enter how long the program will be for: Example: 4 Months");
            string workoutLength = Console.ReadLine();
            Console.WriteLine("Enter the plan type: Example: Strength");
            string workoutTypeOfPlan = Console.ReadLine();
            Console.WriteLine("Enter a description for your plan: Example: This program is meant to add strength to....");
            string workoutDescriptionOfPlan = Console.ReadLine();
            Workout workout = new Workout(workoutProgramName, workoutLength, workoutTypeOfPlan, workoutDescriptionOfPlan);
            workoutPlanList.Add(workout);
            Console.Clear();
            
        }

        public void DisplayWorkoutPlanData()
        {
            Workout workout = workoutPlanList.Last<Workout>();
            Console.WriteLine("Workout Program Name: " + workout.workoutProgramName);
            Console.WriteLine("Program Duration: " + workout.duration);
            Console.WriteLine("Type of Plan: " + workout.typeOfPlan);
            Console.WriteLine("Workout Plan Description: " + workout.descriptionOfPlan);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public void GatherExerciseData()
        {
            Console.WriteLine("Now that we have the main details for your workout program, \n" +
                "we'll start filling in the exercises for your program. Press Enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Enter the Name of your exercise: ");
            string exerciseName = Console.ReadLine();
            Console.WriteLine("Enter how many sets you'll perform");
            int exerciseNumberOfSets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many reps you'll perform");
            int exerciseNumberOfReps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how long you think it will take to complete all sets");
            int exerciseDuration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how long your rest between sets will be");
            int exerciseRestDuration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any notes you may have for your exercise");
            string exerciseNotes = Console.ReadLine();
            Exercises exercises = new Exercises(exerciseName, exerciseNumberOfSets, exerciseNumberOfReps, 
                exerciseDuration, exerciseRestDuration, exerciseNotes);
            exerciseList.Add(exercises);
            exercisesPerWorkoutList.Add(exerciseList);

            Console.Clear();

            

        }

        public void DisplayExerciseData()
        {
            Exercises workout = exerciseList.Last<Exercises>();

            Console.WriteLine("Name of Exercise: " + workout.exerciseName);
            Console.WriteLine("# of Sets: " + workout.numberOfSets);
            Console.WriteLine("# of Reps: " + workout.numberOfReps);
            Console.WriteLine("Estimated Duration: " + workout.duration);
            Console.WriteLine("Rest Duration: " + workout.restDuration);
            Console.WriteLine("Notes: " + workout.notes);
            Console.ReadLine();
        }


        public void GatherBusinessData()
        {
            Console.WriteLine("This feature has not been implemented yet");
        }

        
    }
}
