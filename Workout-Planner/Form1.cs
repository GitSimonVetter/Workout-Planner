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
        public string[] name = {"Ladzug", "Hose hochziehen"};
        public string[] reps = {"8-10","12-14"};
        public double[] weight = { 75, 10 };
        public string[] tempo = { "2.2.4","2.4.2" };
        public string[] description = {"Ladzug Maschine viel hilft viel","Hosenstall zu machen"};
        public string workoutName = "Fett weg";
        int selectedTab = 0;
        WorkoutBuilder workoutBuilder = new WorkoutBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btWorkoutBuilder_Click(object sender, EventArgs e)
        {
            selectedTab = 6;
            showTab(selectedTab);
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
        private void showTab(int input)
        {
            switch (input)
            {
                case 0:
                    pnHomepage.Show();
                    btHomepage.BackColor = Color.LightBlue;

                    pn2.Hide();
                    button2.BackColor = Color.White;
                    button2.ForeColor = Color.Black;
                    pnExcercises.Hide();
                    btExcercises.BackColor = Color.White;
                    btExcercises.ForeColor = Color.Black;
                    pnWorkout.Hide();
                    btWorkout.BackColor = Color.White;
                    btWorkout.ForeColor = Color.Black;
                    pnSchedule.Show();
                    btSchedule.BackColor = Color.White;
                    btSchedule.ForeColor = Color.Black;
                    pnSharing.Hide();
                    btSharing.BackColor = Color.White;
                    btSharing.ForeColor = Color.Black;
                    pnWorkoutBuilder.Hide();
                    btWorkoutBuilder.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;

                    break;
                case 1:
                    pn2.Show();
                    button2.BackColor = Color.LightBlue;

                    pnHomepage.Hide();
                    btHomepage.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    pnExcercises.Hide();
                    btExcercises.BackColor = Color.White;
                    btExcercises.ForeColor = Color.Black;
                    pnWorkout.Hide();
                    btWorkout.BackColor = Color.White;
                    btWorkout.ForeColor = Color.Black;
                    pnSchedule.Hide();
                    btSchedule.BackColor = Color.White;
                    btSchedule.ForeColor = Color.Black;
                    pnSharing.Hide();
                    btSharing.BackColor = Color.White;
                    btSharing.ForeColor = Color.Black;
                    pnWorkoutBuilder.Hide();
                    btWorkoutBuilder.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    break;
                case 2:
                    pnExcercises.Show();
                    btExcercises.BackColor = Color.LightBlue;

                    pnHomepage.Hide();
                    btHomepage.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    pn2.Hide();
                    button2.BackColor = Color.White;
                    button2.ForeColor = Color.Black;
                    pnWorkout.Hide();
                    btWorkout.BackColor = Color.White;
                    btWorkout.ForeColor = Color.Black;
                    pnSchedule.Show();
                    btSchedule.BackColor = Color.White;
                    btSchedule.ForeColor = Color.Black;
                    pnSharing.Hide();
                    btSharing.BackColor = Color.White;
                    btSharing.ForeColor = Color.Black;
                    pnWorkoutBuilder.Hide();
                    btWorkoutBuilder.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    break;
                case 3:
                    pnWorkout.Show();
                    btWorkout.BackColor = Color.LightBlue;

                    pnHomepage.Hide();
                    btHomepage.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    pn2.Hide();
                    button2.BackColor = Color.White;
                    button2.ForeColor = Color.Black;
                    pnExcercises.Hide();
                    btExcercises.BackColor = Color.White;
                    btExcercises.ForeColor = Color.Black;
                    pnSchedule.Show();
                    btSchedule.BackColor = Color.White;
                    btSchedule.ForeColor = Color.Black;
                    pnSharing.Hide();
                    btSharing.BackColor = Color.White;
                    btSharing.ForeColor = Color.Black;
                    pnWorkoutBuilder.Hide();
                    btWorkoutBuilder.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    break;
                case 4:
                    pnSchedule.Show();
                    btSchedule.BackColor = Color.LightBlue;
                    
                    pnHomepage.Hide();
                    btHomepage.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    pn2.Hide();
                    button2.BackColor = Color.White;
                    button2.ForeColor = Color.Black;
                    pnExcercises.Hide();
                    btExcercises.BackColor = Color.White;
                    btExcercises.ForeColor = Color.Black;
                    pnWorkout.Hide();
                    btWorkout.BackColor = Color.White;
                    btWorkout.ForeColor = Color.Black;
                    pnSharing.Hide();
                    btSharing.BackColor = Color.White;
                    btSharing.ForeColor = Color.Black;
                    pnWorkoutBuilder.Hide();
                    btWorkoutBuilder.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    break;
                case 5:
                    pnSharing.Show();
                    btSharing.BackColor = Color.LightBlue;

                    pnHomepage.Hide();
                    btHomepage.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    pn2.Hide();
                    button2.BackColor = Color.White;
                    button2.ForeColor = Color.Black;
                    pnExcercises.Hide();
                    btExcercises.BackColor = Color.White;
                    btExcercises.ForeColor = Color.Black;
                    pnWorkout.Hide();
                    btWorkout.BackColor = Color.White;
                    btWorkout.ForeColor = Color.Black;
                    pnSchedule.Show();
                    btSchedule.BackColor = Color.White;
                    btSchedule.ForeColor = Color.Black;
                    pnWorkoutBuilder.Hide();
                    btWorkoutBuilder.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    break;
                case 6:
                    pnWorkoutBuilder.Show();
                    btWorkoutBuilder.BackColor = Color.LightBlue;

                    pnHomepage.Hide();
                    btHomepage.BackColor = Color.White;
                    btWorkoutBuilder.ForeColor = Color.Black;
                    pn2.Hide();
                    button2.BackColor = Color.White;
                    button2.ForeColor = Color.Black;
                    pnExcercises.Hide();
                    btExcercises.BackColor = Color.White;
                    btExcercises.ForeColor = Color.Black;
                    pnWorkout.Hide();
                    btWorkout.BackColor = Color.White;
                    btWorkout.ForeColor = Color.Black;
                    pnSchedule.Show();
                    btSchedule.BackColor = Color.White;
                    btSchedule.ForeColor = Color.Black;
                    pnSharing.Hide();
                    btSharing.BackColor = Color.White;
                    btSharing.ForeColor = Color.Black;
                    break;
            }
        }

        private void btHomepage_Click(object sender, EventArgs e)
        {
            selectedTab = 0;
            showTab(selectedTab);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedTab = 1;
            showTab(selectedTab);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedTab = 2;
            showTab(selectedTab);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedTab = 3;
            showTab(selectedTab);
        }

        private void btSchedule_Click(object sender, EventArgs e)
        {
            selectedTab = 4;
            showTab(selectedTab);
        }

        private void btSharing_Click(object sender, EventArgs e)
        {
            selectedTab = 5;
            showTab(selectedTab);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
