namespace CST_150_Activity8
{
    partial class calorieConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calorieConverter));
            this.title = new System.Windows.Forms.Label();
            this.fatGrams = new System.Windows.Forms.TextBox();
            this.carbGrams = new System.Windows.Forms.TextBox();
            this.fatFramsLabel = new System.Windows.Forms.Label();
            this.carbGramsLabel = new System.Windows.Forms.Label();
            this.caloriesFromFatsLabel = new System.Windows.Forms.Label();
            this.caloriesFromCarbsLabel = new System.Windows.Forms.Label();
            this.fatCals = new System.Windows.Forms.Label();
            this.carbCals = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.totalCals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.title.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.title.Location = new System.Drawing.Point(1, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(2118, 251);
            this.title.TabIndex = 0;
            this.title.Text = "Calorie Converter";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatGrams
            // 
            this.fatGrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.fatGrams.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatGrams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.fatGrams.Location = new System.Drawing.Point(767, 317);
            this.fatGrams.Name = "fatGrams";
            this.fatGrams.Size = new System.Drawing.Size(197, 88);
            this.fatGrams.TabIndex = 1;
            // 
            // carbGrams
            // 
            this.carbGrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.carbGrams.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbGrams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.carbGrams.Location = new System.Drawing.Point(1400, 317);
            this.carbGrams.Name = "carbGrams";
            this.carbGrams.Size = new System.Drawing.Size(197, 88);
            this.carbGrams.TabIndex = 2;
            // 
            // fatFramsLabel
            // 
            this.fatFramsLabel.AutoSize = true;
            this.fatFramsLabel.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatFramsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.fatFramsLabel.Location = new System.Drawing.Point(518, 328);
            this.fatFramsLabel.Name = "fatFramsLabel";
            this.fatFramsLabel.Size = new System.Drawing.Size(243, 77);
            this.fatFramsLabel.TabIndex = 3;
            this.fatFramsLabel.Text = "Fat(grams):";
            // 
            // carbGramsLabel
            // 
            this.carbGramsLabel.AutoSize = true;
            this.carbGramsLabel.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbGramsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.carbGramsLabel.Location = new System.Drawing.Point(1102, 328);
            this.carbGramsLabel.Name = "carbGramsLabel";
            this.carbGramsLabel.Size = new System.Drawing.Size(292, 77);
            this.carbGramsLabel.TabIndex = 4;
            this.carbGramsLabel.Text = "Carbs(grams):";
            // 
            // caloriesFromFatsLabel
            // 
            this.caloriesFromFatsLabel.AutoSize = true;
            this.caloriesFromFatsLabel.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromFatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.caloriesFromFatsLabel.Location = new System.Drawing.Point(767, 682);
            this.caloriesFromFatsLabel.Name = "caloriesFromFatsLabel";
            this.caloriesFromFatsLabel.Size = new System.Drawing.Size(389, 77);
            this.caloriesFromFatsLabel.TabIndex = 5;
            this.caloriesFromFatsLabel.Text = "Calories From Fats:";
            // 
            // caloriesFromCarbsLabel
            // 
            this.caloriesFromCarbsLabel.AutoSize = true;
            this.caloriesFromCarbsLabel.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromCarbsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.caloriesFromCarbsLabel.Location = new System.Drawing.Point(767, 789);
            this.caloriesFromCarbsLabel.Name = "caloriesFromCarbsLabel";
            this.caloriesFromCarbsLabel.Size = new System.Drawing.Size(412, 77);
            this.caloriesFromCarbsLabel.TabIndex = 6;
            this.caloriesFromCarbsLabel.Text = "Calories from Carbs:";
            // 
            // fatCals
            // 
            this.fatCals.AutoSize = true;
            this.fatCals.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatCals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(163)))), ((int)(((byte)(159)))));
            this.fatCals.Location = new System.Drawing.Point(1162, 682);
            this.fatCals.Name = "fatCals";
            this.fatCals.Size = new System.Drawing.Size(45, 77);
            this.fatCals.TabIndex = 7;
            this.fatCals.Text = " ";
            // 
            // carbCals
            // 
            this.carbCals.AutoSize = true;
            this.carbCals.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbCals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(163)))), ((int)(((byte)(159)))));
            this.carbCals.Location = new System.Drawing.Point(1185, 789);
            this.carbCals.Name = "carbCals";
            this.carbCals.Size = new System.Drawing.Size(45, 77);
            this.carbCals.TabIndex = 8;
            this.carbCals.Text = " ";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.calculateButton.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(224)))));
            this.calculateButton.Location = new System.Drawing.Point(876, 487);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(303, 88);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaloriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(163)))), ((int)(((byte)(159)))));
            this.totalCaloriesLabel.Location = new System.Drawing.Point(767, 891);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(319, 77);
            this.totalCaloriesLabel.TabIndex = 10;
            this.totalCaloriesLabel.Text = "Total Calories:";
            // 
            // totalCals
            // 
            this.totalCals.AutoSize = true;
            this.totalCals.Font = new System.Drawing.Font("Myanmar Text", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(163)))), ((int)(((byte)(159)))));
            this.totalCals.Location = new System.Drawing.Point(1071, 891);
            this.totalCals.Name = "totalCals";
            this.totalCals.Size = new System.Drawing.Size(45, 77);
            this.totalCals.TabIndex = 11;
            this.totalCals.Text = " ";
            // 
            // calorieConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(2116, 1109);
            this.Controls.Add(this.totalCals);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.carbCals);
            this.Controls.Add(this.fatCals);
            this.Controls.Add(this.caloriesFromCarbsLabel);
            this.Controls.Add(this.caloriesFromFatsLabel);
            this.Controls.Add(this.carbGramsLabel);
            this.Controls.Add(this.fatFramsLabel);
            this.Controls.Add(this.carbGrams);
            this.Controls.Add(this.fatGrams);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calorieConverter";
            this.Text = "Calorie Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox fatGrams;
        private System.Windows.Forms.TextBox carbGrams;
        private System.Windows.Forms.Label fatFramsLabel;
        private System.Windows.Forms.Label carbGramsLabel;
        private System.Windows.Forms.Label caloriesFromFatsLabel;
        private System.Windows.Forms.Label caloriesFromCarbsLabel;
        private System.Windows.Forms.Label fatCals;
        private System.Windows.Forms.Label carbCals;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label totalCals;
    }
}

