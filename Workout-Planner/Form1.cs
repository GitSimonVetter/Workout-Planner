using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workout_Planner
{
    public partial class Form1 : Form
    {
        string[] name = {"Ladzug", "Hose hochziehen"};
        string[] reps = {"8-10","12-14"};
        double[] weight = { 75, 10 };
        string[] tempo = { "2.2.4","2.4.2" };
        string[] description = {"Ladzug Maschine viel hilft viel","Hosenstall zu machen"};
        string workoutName = "Fett weg";
        WorkoutBuilder workoutBuilder = new WorkoutBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btWorkoutBuilder_Click(object sender, EventArgs e)
        {

        }

        private void btWorkoutAddExercise_Click(object sender, EventArgs e)
        {
            workoutBuilder.createExcercises(name, reps, weight, tempo, description);

        }

        private void btNewWorkout_Click(object sender, EventArgs e)
        {
            
            ICollection allKeysWorkout = WorkoutBuilder.Workout.Keys;
            workoutBuilder.createWorkout(workoutName);
            string messagebox = workoutBuilder.outputAllKeys(allKeysWorkout,WorkoutBuilder.Workout);
            MessageBox.Show(messagebox);
        }
    }
}
