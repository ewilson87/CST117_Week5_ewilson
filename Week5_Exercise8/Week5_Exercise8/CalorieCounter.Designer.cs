namespace Week5_Exercise8
{
    partial class CalorieCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalorieCounter));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.carbsCaloriesGroupBox = new System.Windows.Forms.GroupBox();
            this.carbsErrorBox = new System.Windows.Forms.RichTextBox();
            this.calculatedCarbsCalories = new System.Windows.Forms.Label();
            this.fatCaloriesGroupBox = new System.Windows.Forms.GroupBox();
            this.calculatedFatCalories = new System.Windows.Forms.Label();
            this.fatErrorBox = new System.Windows.Forms.RichTextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.carbsGroupBox = new System.Windows.Forms.GroupBox();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.fatGroupBox = new System.Windows.Forms.GroupBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.carbsCaloriesGroupBox.SuspendLayout();
            this.fatCaloriesGroupBox.SuspendLayout();
            this.carbsGroupBox.SuspendLayout();
            this.fatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.carbsCaloriesGroupBox);
            this.bunifuGradientPanel1.Controls.Add(this.fatCaloriesGroupBox);
            this.bunifuGradientPanel1.Controls.Add(this.calculateButton);
            this.bunifuGradientPanel1.Controls.Add(this.carbsGroupBox);
            this.bunifuGradientPanel1.Controls.Add(this.fatGroupBox);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(452, 305);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // carbsCaloriesGroupBox
            // 
            this.carbsCaloriesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.carbsCaloriesGroupBox.Controls.Add(this.carbsErrorBox);
            this.carbsCaloriesGroupBox.Controls.Add(this.calculatedCarbsCalories);
            this.carbsCaloriesGroupBox.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsCaloriesGroupBox.Location = new System.Drawing.Point(240, 196);
            this.carbsCaloriesGroupBox.Name = "carbsCaloriesGroupBox";
            this.carbsCaloriesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.carbsCaloriesGroupBox.TabIndex = 3;
            this.carbsCaloriesGroupBox.TabStop = false;
            this.carbsCaloriesGroupBox.Text = "Calories From Carbs";
            this.carbsCaloriesGroupBox.Visible = false;
            // 
            // carbsErrorBox
            // 
            this.carbsErrorBox.Enabled = false;
            this.carbsErrorBox.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsErrorBox.Location = new System.Drawing.Point(6, 22);
            this.carbsErrorBox.Name = "carbsErrorBox";
            this.carbsErrorBox.ReadOnly = true;
            this.carbsErrorBox.Size = new System.Drawing.Size(188, 71);
            this.carbsErrorBox.TabIndex = 5;
            this.carbsErrorBox.Text = "You must enter a positive number of carbs grams";
            this.carbsErrorBox.Visible = false;
            // 
            // calculatedCarbsCalories
            // 
            this.calculatedCarbsCalories.AutoSize = true;
            this.calculatedCarbsCalories.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedCarbsCalories.Location = new System.Drawing.Point(83, 36);
            this.calculatedCarbsCalories.Name = "calculatedCarbsCalories";
            this.calculatedCarbsCalories.Size = new System.Drawing.Size(0, 28);
            this.calculatedCarbsCalories.TabIndex = 0;
            this.calculatedCarbsCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatCaloriesGroupBox
            // 
            this.fatCaloriesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.fatCaloriesGroupBox.Controls.Add(this.calculatedFatCalories);
            this.fatCaloriesGroupBox.Controls.Add(this.fatErrorBox);
            this.fatCaloriesGroupBox.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatCaloriesGroupBox.Location = new System.Drawing.Point(13, 195);
            this.fatCaloriesGroupBox.Name = "fatCaloriesGroupBox";
            this.fatCaloriesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.fatCaloriesGroupBox.TabIndex = 2;
            this.fatCaloriesGroupBox.TabStop = false;
            this.fatCaloriesGroupBox.Text = "Calories From Fat";
            this.fatCaloriesGroupBox.Visible = false;
            // 
            // calculatedFatCalories
            // 
            this.calculatedFatCalories.AutoSize = true;
            this.calculatedFatCalories.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedFatCalories.Location = new System.Drawing.Point(83, 36);
            this.calculatedFatCalories.Name = "calculatedFatCalories";
            this.calculatedFatCalories.Size = new System.Drawing.Size(0, 28);
            this.calculatedFatCalories.TabIndex = 0;
            this.calculatedFatCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatErrorBox
            // 
            this.fatErrorBox.Enabled = false;
            this.fatErrorBox.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatErrorBox.Location = new System.Drawing.Point(6, 23);
            this.fatErrorBox.Name = "fatErrorBox";
            this.fatErrorBox.ReadOnly = true;
            this.fatErrorBox.Size = new System.Drawing.Size(188, 71);
            this.fatErrorBox.TabIndex = 4;
            this.fatErrorBox.Text = "You must enter a positive number of fat grams";
            this.fatErrorBox.Visible = false;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(126, 129);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(200, 50);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // carbsGroupBox
            // 
            this.carbsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.carbsGroupBox.Controls.Add(this.carbsTextBox);
            this.carbsGroupBox.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsGroupBox.Location = new System.Drawing.Point(236, 13);
            this.carbsGroupBox.Name = "carbsGroupBox";
            this.carbsGroupBox.Size = new System.Drawing.Size(200, 100);
            this.carbsGroupBox.TabIndex = 2;
            this.carbsGroupBox.TabStop = false;
            this.carbsGroupBox.Text = "Carbohydrates Grams";
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(4, 41);
            this.carbsTextBox.MaxLength = 3;
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(190, 26);
            this.carbsTextBox.TabIndex = 0;
            this.carbsTextBox.Text = "Enter # of grams of carbs";
            this.carbsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.carbsTextBox.Enter += new System.EventHandler(this.carbsTextBox_Enter);
            // 
            // fatGroupBox
            // 
            this.fatGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.fatGroupBox.Controls.Add(this.fatTextBox);
            this.fatGroupBox.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatGroupBox.Location = new System.Drawing.Point(13, 13);
            this.fatGroupBox.Name = "fatGroupBox";
            this.fatGroupBox.Size = new System.Drawing.Size(200, 100);
            this.fatGroupBox.TabIndex = 1;
            this.fatGroupBox.TabStop = false;
            this.fatGroupBox.Text = "Fat Grams";
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(6, 41);
            this.fatTextBox.MaxLength = 3;
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(188, 26);
            this.fatTextBox.TabIndex = 0;
            this.fatTextBox.Text = "Enter # of grams of fat";
            this.fatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fatTextBox.Enter += new System.EventHandler(this.fatTextBox_Enter);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 305);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Daily Calories";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.carbsCaloriesGroupBox.ResumeLayout(false);
            this.carbsCaloriesGroupBox.PerformLayout();
            this.fatCaloriesGroupBox.ResumeLayout(false);
            this.fatCaloriesGroupBox.PerformLayout();
            this.carbsGroupBox.ResumeLayout(false);
            this.carbsGroupBox.PerformLayout();
            this.fatGroupBox.ResumeLayout(false);
            this.fatGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox carbsGroupBox;
        private System.Windows.Forms.TextBox carbsTextBox;
        private System.Windows.Forms.GroupBox fatGroupBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox carbsCaloriesGroupBox;
        private System.Windows.Forms.Label calculatedCarbsCalories;
        private System.Windows.Forms.GroupBox fatCaloriesGroupBox;
        private System.Windows.Forms.Label calculatedFatCalories;
        private System.Windows.Forms.RichTextBox fatErrorBox;
        private System.Windows.Forms.RichTextBox carbsErrorBox;
    }
}

