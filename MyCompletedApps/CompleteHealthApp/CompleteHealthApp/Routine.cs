using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteHealthApp
{

    internal class Routine //Go through and see if you need to make more constructors 
    {
        public string routineName { get; set; }
        public DateTime routineStartTime { get; set; }
        public DateTime routineEndTime { get; set; }
        public Routine(string routineName, DateTime routineStartTime, DateTime routineEndTime)
        {
            this.routineName = routineName;
            this.routineStartTime = routineStartTime;
            this.routineEndTime = routineEndTime;
        }


    }

    public class RoutineTask  
    {

        public string taskName { get; set; }
        public DateTime? taskStart { get; set; }
        public DateTime? taskEnd { get; set; }


        public RoutineTask(string taskName)
        {
            this.taskName = taskName;
        }
        public RoutineTask(string taskName, DateTime? taskStart, DateTime? taskEnd)
        {
            this.taskName = taskName;
            this.taskStart = taskStart;
            this.taskEnd = taskEnd;
        }

        
    }

}

