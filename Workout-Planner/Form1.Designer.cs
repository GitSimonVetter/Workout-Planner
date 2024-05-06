namespace Workout_Planner
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
            this.btNewWorkout = new System.Windows.Forms.Button();
            this.btWorkoutAddExercise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btWorkoutBuilder = new System.Windows.Forms.Button();
            this.pnWorkoutBuilder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnWorkoutBuilder
            // 
            this.pnWorkoutBuilder.Controls.Add(this.btNewWorkout);
            this.pnWorkoutBuilder.Controls.Add(this.btWorkoutAddExercise);
            this.pnWorkoutBuilder.Location = new System.Drawing.Point(1, 25);
            this.pnWorkoutBuilder.Name = "pnWorkoutBuilder";
            this.pnWorkoutBuilder.Size = new System.Drawing.Size(798, 426);
            this.pnWorkoutBuilder.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 24);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(535, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 24);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btWorkoutBuilder);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnWorkoutBuilder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnWorkoutBuilder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWorkoutBuilder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btWorkoutBuilder;
        private System.Windows.Forms.Button btWorkoutAddExercise;
        private System.Windows.Forms.Button btNewWorkout;
    }
}

