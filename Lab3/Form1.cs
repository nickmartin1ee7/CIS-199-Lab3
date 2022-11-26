/**
 *  Grading ID:     L8486
 *  Course:         199-72
 *  Lab:            3
 *  Due:            9/22/19
 *  Description:    Sphere calulator program that will accept a radius as input, then calculate and output diameter, surface area, and volume of a sphere.
 **/

using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When calculate button is clicked, calculate diameter, surface area, and volume values, then update result labels
        private void calcButton_Click(object sender, EventArgs e)
        {
            // Variables
            double radius,      // Radius value of sphere
                   diameter,    // Calculated diameter value of sphere
                   surfaceArea, // Calculated surface area value of sphere
                   volume;      // Calculated volume value of sphere

            // Input
            radius = double.Parse(radiusOfSphereTextBox.Text);  // Parse input of radius textbox into radius value

            // Calculations
            diameter = radius * 2;                              // Mathmatical formula to calculate diameter using a radius
            surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);    // Mathmatical formula to calculate surface area using radius
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;   // Mathmatical formula to calculate volume using radius

            // Output
            diameterResultLabel.Text = $"{diameter:f2}";         // Update diameter result label's text
            surfaceAreaResultLabel.Text = $"{surfaceArea:f2}";   // Update surface result label's text
            volumeResultLabel.Text = $"{volume:f2}";             // Update volume result label's text
        }
    }
}
