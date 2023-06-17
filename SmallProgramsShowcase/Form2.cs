using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SmallProgramsShowcase
{
    //this class is responsible for calculating the BMI
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            try
            {

                string status;
                double bmi;
                string weightString = tbxWeight.Text;
                string heightString = tbxHeight.Text;
                //taking in the height and weight as strings and then converting them to doubles
                double weight = Convert.ToDouble(weightString);
                double height = Convert.ToDouble(heightString);
                bmi = 703 * (weight / (height * height)); //using the imperial system to get in and lb
                bmi = Math.Round(bmi, 2); //rounding to 2 decimal places

                //finding the category to which the user belongs
                if (bmi < 18.5)
                {
                    status = "underweight";

                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    status = "normal weight";
                }
                else if (bmi >= 25.0 && bmi <= 29.9)
                {
                    status = "overweight";
                }
                else
                {
                    status = "obese";
                }
                //populating the textboxes with the results from the calculations
                tbxBMI.Text = bmi.ToString();
                tbxStatus.Text = status;
            }
            catch (Exception ex)
            {
                //showing an error message in a modal dialog box if the user enters a string
                MessageBox.Show("The mass and height must be numbers.");
                if (DialogResult == DialogResult.OK)
                {
                    //if they hit ok, then the box will close instead of flashing
                    Close(); 
                }

                //clearing the weight and height if the user tries to enter a string
                tbxWeight.Clear();
                tbxHeight.Clear();

            }
        }

        //if the user wants to leave the program, they can hit the close button
        private void btnCloseBMI_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
