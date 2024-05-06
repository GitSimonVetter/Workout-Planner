using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workout_Planner
{
    public class WorkoutBuilder
    {
        public static Hashtable Workout = new Hashtable();
        public string excerciseFull;
        public string outputAllKeys(ICollection allKeys,Hashtable hashtable)
        {
            string output = null;
            foreach (string key in allKeys)
            {
                 output  = output + key +","+ hashtable[key] + "\n";
            }
            return output;
        }

        public void createExcercises(string[] excerciseName, string[] excerciseReps, double[] excerciseWeight, string[] excerciseTempo, string[] excerciseDescription)
        {
            Hashtable Excercises = new Hashtable();      //Creating Hashtable
            List<string> Details = new List<string>();   //Hashtable only contains 2 Parameters
            for(int i = 0; i <= excerciseName.Length; i++)     //max names = how many excercises
            {
                try
                {
                    Details.Add(excerciseReps[i] + "," + excerciseWeight[i] + "," + excerciseTempo[i] + "," + excerciseDescription[i]);  //Adding Repetitions,Weight,Tempo,Description to our List
                    Excercises.Add(excerciseName[i], Details[i]);
                }catch (Exception) { }
            }
            WorkoutBuilder workoutBuilder = new WorkoutBuilder();
            ICollection allKeysExcercises = Excercises.Keys;        //Building iCollection Excersises
            excerciseFull = workoutBuilder.outputAllKeys(allKeysExcercises, Excercises);
        }

        public void createWorkout(string WorkoutName)
        {
            Workout.Add(WorkoutName, excerciseFull);
        }
    }
}
