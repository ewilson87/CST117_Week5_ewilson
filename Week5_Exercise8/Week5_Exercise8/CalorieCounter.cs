/**
 * Program: Daily Calorie Calculator
 * File: CalorieCounter.cs
 * Summary: Converts daily intake of fat grams and carbs grams into calories
 * Author: Evan Wilson
 * Date: May 24th, 2018
 **/

using System;
using System.Windows.Forms;

namespace Week5_Exercise8
{
    public partial class CalorieCounter : Form
    {
        //declare variables
        private int caloriesFromFat;
        private int caloriesFromCarbs;
        private int fatGrams;
        private int carbsGrams;

        public CalorieCounter()
        {
            InitializeComponent();
        }

        //clears initial default text when entered
        private void fatTextBox_Enter(object sender, EventArgs e)
        {
            fatTextBox.Text = fatTextBox.Text.Trim();
            if (fatTextBox.Text == "Enter # of grams of fat")
            {
                fatTextBox.Text = "";
            }
        }

        private void carbsTextBox_Enter(object sender, EventArgs e)
        {
            carbsTextBox.Text = carbsTextBox.Text.Trim();
            if (carbsTextBox.Text == "Enter # of grams of carbs")
            {
                carbsTextBox.Text = "";
            }
        }

        //method to calculate calories from fat
        public int calculateFatCalories(int fatGrams)
        {
            caloriesFromFat = fatGrams * 9;
            calculatedFatCalories.Text = caloriesFromFat.ToString();
            calculatedFatCalories.Visible = true;
            fatCaloriesGroupBox.Visible = true;
            fatErrorBox.Visible = false;

            return caloriesFromFat;
        }

        //method to calculate calories from carbs
        public int calculateCarbsCalories(int carbsGrams)
        {
            carbsGrams *= 4;
            calculatedCarbsCalories.Text = carbsGrams.ToString();
            calculatedCarbsCalories.Visible = true;
            carbsCaloriesGroupBox.Visible = true;
            carbsErrorBox.Visible = false;

            return caloriesFromCarbs;
        }

        //runs methods to calculate calories on button click
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //parse textbox, and check if value is non negative. Sets visibilities and text
            try
            {
                fatGrams = int.Parse(fatTextBox.Text);
                if (fatGrams >= 0)
                {
                    caloriesFromFat = calculateFatCalories(fatGrams);
                }
            }
            catch
            {
                fatTextBox.Text = "";
                fatErrorBox.Visible = true;
                calculatedFatCalories.Visible = false;
                fatCaloriesGroupBox.Visible = true;
            }

            try
            {
                carbsGrams = int.Parse(carbsTextBox.Text);
                if (carbsGrams >= 0)
                {
                    caloriesFromCarbs = calculateCarbsCalories(carbsGrams);
                }
            }
            catch
            {
                carbsTextBox.Text = "";
                carbsErrorBox.Visible = true;
                calculatedCarbsCalories.Visible = false;
                carbsCaloriesGroupBox.Visible = true;
            }
        }
    }
}
