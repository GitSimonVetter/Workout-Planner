﻿namespace Workout_Planner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnWorkoutBuilder = new System.Windows.Forms.Panel();
            this.pnHomepage = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.pn3 = new System.Windows.Forms.Panel();
            this.btNewWorkout = new System.Windows.Forms.Button();
            this.btWorkoutAddExercise = new System.Windows.Forms.Button();
            this.btHomepage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btSchedule = new System.Windows.Forms.Button();
            this.btSharing = new System.Windows.Forms.Button();
            this.btWorkoutBuilder = new System.Windows.Forms.Button();
            this.pn4 = new System.Windows.Forms.Panel();
            this.pnSchedule = new System.Windows.Forms.Panel();
            this.pnSharing = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnWorkoutBuilder.SuspendLayout();
            this.pnHomepage.SuspendLayout();
            this.pn2.SuspendLayout();
            this.pn4.SuspendLayout();
            this.pnSchedule.SuspendLayout();
            this.pnSharing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnWorkoutBuilder
            // 
            this.pnWorkoutBuilder.Controls.Add(this.pnHomepage);
            this.pnWorkoutBuilder.Controls.Add(this.btNewWorkout);
            this.pnWorkoutBuilder.Controls.Add(this.btWorkoutAddExercise);
            this.pnWorkoutBuilder.Location = new System.Drawing.Point(1, 25);
            this.pnWorkoutBuilder.Name = "pnWorkoutBuilder";
            this.pnWorkoutBuilder.Size = new System.Drawing.Size(798, 426);
            this.pnWorkoutBuilder.TabIndex = 0;
            // 
            // pnHomepage
            // 
            this.pnHomepage.Controls.Add(this.pn2);
            this.pnHomepage.Location = new System.Drawing.Point(0, 0);
            this.pnHomepage.Name = "pnHomepage";
            this.pnHomepage.Size = new System.Drawing.Size(798, 426);
            this.pnHomepage.TabIndex = 3;
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.pn3);
            this.pn2.Location = new System.Drawing.Point(0, 0);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(798, 426);
            this.pn2.TabIndex = 4;
            // 
            // pn3
            // 
            this.pn3.Location = new System.Drawing.Point(0, 0);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(798, 426);
            this.pn3.TabIndex = 5;
            // 
            // btNewWorkout
            // 
            this.btNewWorkout.Location = new System.Drawing.Point(27, 22);
            this.btNewWorkout.Name = "btNewWorkout";
            this.btNewWorkout.Size = new System.Drawing.Size(101, 23);
            this.btNewWorkout.TabIndex = 2;
            this.btNewWorkout.Text = "New Workout";
            this.btNewWorkout.UseVisualStyleBackColor = true;
            this.btNewWorkout.Click += new System.EventHandler(this.btNewWorkout_Click);
            // 
            // btWorkoutAddExercise
            // 
            this.btWorkoutAddExercise.Location = new System.Drawing.Point(641, 22);
            this.btWorkoutAddExercise.Name = "btWorkoutAddExercise";
            this.btWorkoutAddExercise.Size = new System.Drawing.Size(101, 23);
            this.btWorkoutAddExercise.TabIndex = 1;
            this.btWorkoutAddExercise.Text = "Add Exercise";
            this.btWorkoutAddExercise.UseVisualStyleBackColor = true;
            this.btWorkoutAddExercise.Click += new System.EventHandler(this.btWorkoutAddExercise_Click);
            // 
            // btHomepage
            // 
            this.btHomepage.BackColor = System.Drawing.Color.LightBlue;
            this.btHomepage.Location = new System.Drawing.Point(0, 1);
            this.btHomepage.Name = "btHomepage";
            this.btHomepage.Size = new System.Drawing.Size(101, 24);
            this.btHomepage.TabIndex = 1;
            this.btHomepage.Text = "Homepage";
            this.btHomepage.UseVisualStyleBackColor = false;
            this.btHomepage.Click += new System.EventHandler(this.btHomepage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btSchedule
            // 
            this.btSchedule.Location = new System.Drawing.Point(428, 1);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Size = new System.Drawing.Size(101, 24);
            this.btSchedule.TabIndex = 5;
            this.btSchedule.Text = "Schedule";
            this.btSchedule.UseVisualStyleBackColor = true;
            this.btSchedule.Click += new System.EventHandler(this.btSchedule_Click);
            // 
            // btSharing
            // 
            this.btSharing.Location = new System.Drawing.Point(535, 1);
            this.btSharing.Name = "btSharing";
            this.btSharing.Size = new System.Drawing.Size(101, 24);
            this.btSharing.TabIndex = 6;
            this.btSharing.Text = "Sharing";
            this.btSharing.UseVisualStyleBackColor = true;
            this.btSharing.Click += new System.EventHandler(this.btSharing_Click);
            // 
            // btWorkoutBuilder
            // 
            this.btWorkoutBuilder.Location = new System.Drawing.Point(642, 1);
            this.btWorkoutBuilder.Name = "btWorkoutBuilder";
            this.btWorkoutBuilder.Size = new System.Drawing.Size(101, 24);
            this.btWorkoutBuilder.TabIndex = 7;
            this.btWorkoutBuilder.Text = "WorkoutBuilder";
            this.btWorkoutBuilder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btWorkoutBuilder.UseVisualStyleBackColor = true;
            this.btWorkoutBuilder.Click += new System.EventHandler(this.btWorkoutBuilder_Click);
            // 
            // pn4
            // 
            this.pn4.Controls.Add(this.pnSchedule);
            this.pn4.Location = new System.Drawing.Point(1, 25);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(798, 423);
            this.pn4.TabIndex = 6;
            // 
            // pnSchedule
            // 
            this.pnSchedule.Controls.Add(this.pnSharing);
            this.pnSchedule.Location = new System.Drawing.Point(0, 0);
            this.pnSchedule.Name = "pnSchedule";
            this.pnSchedule.Size = new System.Drawing.Size(798, 426);
            this.pnSchedule.TabIndex = 7;
            // 
            // pnSharing
            // 
            this.pnSharing.Controls.Add(this.label1);
            this.pnSharing.Location = new System.Drawing.Point(0, 0);
            this.pnSharing.Name = "pnSharing";
            this.pnSharing.Size = new System.Drawing.Size(798, 426);
            this.pnSharing.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn4);
            this.Controls.Add(this.btWorkoutBuilder);
            this.Controls.Add(this.btSharing);
            this.Controls.Add(this.btSchedule);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btHomepage);
            this.Controls.Add(this.pnWorkoutBuilder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnWorkoutBuilder.ResumeLayout(false);
            this.pnHomepage.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn4.ResumeLayout(false);
            this.pnSchedule.ResumeLayout(false);
            this.pnSharing.ResumeLayout(false);
            this.pnSharing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWorkoutBuilder;
        private System.Windows.Forms.Button btHomepage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btSchedule;
        private System.Windows.Forms.Button btSharing;
        private System.Windows.Forms.Button btWorkoutBuilder;
        private System.Windows.Forms.Button btWorkoutAddExercise;
        private System.Windows.Forms.Button btNewWorkout;
        private System.Windows.Forms.Panel pnHomepage;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Panel pn4;
        private System.Windows.Forms.Panel pnSchedule;
        private System.Windows.Forms.Panel pnSharing;
        private System.Windows.Forms.Label label1;
    }
}

