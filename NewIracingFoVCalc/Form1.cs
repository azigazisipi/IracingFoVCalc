using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewIracingFoVCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Initial state setup when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // Default to disabling the Screen Angle TextBox if Single is selected
            textBoxScreenAngle.Enabled = false;

            // Default to disabling the Monitor Curvature TextBox
            textBoxMonitorCurvature.Enabled = false;
        }

        // Event handler for Screen Setup ComboBox selection change
        private void comboBoxScreenSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if "Triple" is selected in Screen Setup ComboBox
            if (comboBoxScreenSetup.SelectedItem != null && comboBoxScreenSetup.SelectedItem.ToString() == "Triple")
            {
                // Enable the Screen Angle TextBox for Triple screen setup
                textBoxScreenAngle.Enabled = true;
            }
            else
            {
                // Disable the Screen Angle TextBox for Single screen setup
                textBoxScreenAngle.Enabled = false;
            }
        }

        private void comboBoxMonitorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable or disable Monitor Curvature based on "Flat" or "Curved"
            if (comboBoxMonitorType.SelectedItem != null && comboBoxMonitorType.SelectedItem.ToString() == "Curved")
            {
                textBoxMonitorCurvature.Enabled = true;
            }
            else
            {
                textBoxMonitorCurvature.Enabled = false;
            }
        }

        private void buttonCalculateFOV_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the input values from TextBoxes
                double screenWidth = double.Parse(textBoxScreenWidth.Text);
                double distanceToScreen = double.Parse(textBoxDistanceToScreen.Text);
                double fov;

                // Determine if it's a single or triple screen setup
                if (comboBoxScreenSetup.SelectedItem != null && comboBoxScreenSetup.SelectedItem.ToString() == "Triple")
                {
                    double screenAngle = double.Parse(textBoxScreenAngle.Text);
                    double screenAngleRadians = Math.PI * screenAngle / 180;

                    // Check if the monitor type is "Curved"
                    if (comboBoxMonitorType.SelectedItem != null && comboBoxMonitorType.SelectedItem.ToString() == "Curved")
                    {
                        double curvatureRadius = double.Parse(textBoxMonitorCurvature.Text);

                        // Adjust the distance for curved monitors
                        double adjustedDistance = distanceToScreen - (curvatureRadius - Math.Sqrt(Math.Pow(curvatureRadius, 2) - Math.Pow(screenWidth / 3, 2)));
                        fov = 2 * Math.Atan((screenWidth * 1.5) / (adjustedDistance * Math.Cos(screenAngleRadians / 2))) * (180 / Math.PI);
                    }
                    else
                    {
                        // Use regular distance for flat monitors
                        fov = 2 * Math.Atan((screenWidth * 1.5) / (distanceToScreen * Math.Cos(screenAngleRadians / 2))) * (180 / Math.PI);
                    }
                }
                else
                {
                    // Single screen setup: Calculate FOV with or without curvature adjustment
                    double adjustedDistance = distanceToScreen;

                    if (comboBoxMonitorType.SelectedItem != null && comboBoxMonitorType.SelectedItem.ToString() == "Curved")
                    {
                        double curvatureRadius = double.Parse(textBoxMonitorCurvature.Text);
                        adjustedDistance = distanceToScreen - (curvatureRadius - Math.Sqrt(Math.Pow(curvatureRadius, 2) - Math.Pow(screenWidth / 2, 2)));
                    }

                    fov = 2 * Math.Atan((screenWidth / 2) / adjustedDistance) * (180 / Math.PI);
                }

                // Round the FOV to the nearest whole number
                int roundedFov = (int)Math.Round(fov);

                // Display the rounded FOV in the label
                labelFOVResult.Text = $"FOV: {roundedFov}°";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
