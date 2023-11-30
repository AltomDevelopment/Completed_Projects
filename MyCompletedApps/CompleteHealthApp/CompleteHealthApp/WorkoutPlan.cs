using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteHealthApp
{
    internal class WorkoutPlan
    {
        public class Workout
        {
            public string workoutProgramName { get; set; }
            public string duration { get; set; }
            public string? typeOfPlan { get; set; }
            public string? descriptionOfPlan { get; set; }

            public Workout(string workoutProgramName, string duration, string? typeOfPlan, string? descriptionOfPlan)
            {
                this.workoutProgramName = workoutProgramName;
                this.duration = duration;
                this.typeOfPlan = typeOfPlan;
                this.descriptionOfPlan = descriptionOfPlan;
            }
        }


        public class Exercises
        {
            public string exerciseName { get; set; }
            public int numberOfSets { get; set; }
            public int numberOfReps { get; set; }
            public int duration { get; set; }
            public int restDuration { get; set; }
            public string notes { get; set; }

            public Exercises(string exerciseName, int numberOfSets, int numberOfReps, int duration, int restDuration, string notes)
            {
                this.exerciseName = exerciseName;
                this.numberOfSets = numberOfSets;
                this.numberOfReps = numberOfReps;
                this.duration = duration;
                this.restDuration = restDuration;
                this.notes = notes;
            }

        }
    }
}
