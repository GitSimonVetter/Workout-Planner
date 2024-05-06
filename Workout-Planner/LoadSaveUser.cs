using Biorhythmus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workout_Planner
{
    public class LoadSaveUser
    {
        
        private static string path = Application.StartupPath + @"\Workout-Planner.txt";

      
        public static void save(string[] Workoutplan)
        {
            if (File.Exists(path) == false)
            {
                File.Create(path);
                
            }
            File.WriteAllLines(path, Workoutplan);
            
        }
    }
}
