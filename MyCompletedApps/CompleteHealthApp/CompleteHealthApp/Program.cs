using CompleteHealthApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthandFitnessFeatures
{
    class Program
    {
        static void Main(string[] args)

        {
            GatherData data = new GatherData();
            WorkingData workingData = new WorkingData();
            DisplayData displayData = new DisplayData();
            workingData.LoginMenu();
            //displayData.DisplayHomeScreen();
            //data.GatherRoutineData();
            //data.GatherRoutineTaskData();
            //data.DisplayRoutine();
            //data.GatherWorkoutPlanData();
            //data.DisplayWorkoutPlanData();
            //data.GatherExerciseData();
            //data.DisplayExerciseData();
            //data.DisplayRoutine();
            //data.DisplayWorkoutPlanData();
            //data.DisplayExerciseData();

        }
    }
}
