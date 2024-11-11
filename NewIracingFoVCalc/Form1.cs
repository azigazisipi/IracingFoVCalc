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
                // Parse input values
                double screenWidth = double.Parse(textBoxScreenWidth.Text);
                double distanceToScreen = double.Parse(textBoxDistanceToScreen.Text);
                double fov;

                // Determine if it's a single or triple screen setup
                if (comboBoxScreenSetup.SelectedItem != null && comboBoxScreenSetup.SelectedItem.ToString() == "Triple")
                {
                    // Triple screen setup: Calculate FOV for one screen and multiply by 3
                    double singleScreenFOV = 2 * Math.Atan((screenWidth / 2) / distanceToScreen) * (180 / Math.PI);
                    fov = singleScreenFOV * 3;
                }
                else
                {
                    // Single screen setup: Calculate FOV
                    fov = 2 * Math.Atan((screenWidth / 2) / distanceToScreen) * (180 / Math.PI);
                }

                // Display the calculated FOV
                labelFOVResult.Text = $"FOV: {fov:F2}°";
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
