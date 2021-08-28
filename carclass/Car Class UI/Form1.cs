/**
 * 08/28/2021
 * CSC 253
 * Michael Pipkin II
 * Create a class named Car that has the following properties:
 * Year, Make, and Speed. The class should have the following
 * constructors and other methods: Constructor, Accelerate, and Brake.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace Car_Class_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        CarLibrary.Car car = new Car();

        private void AccelerateBtn_Click(object sender, EventArgs e)
        {
            if (txtboxMake.Text == String.Empty || txtBoxYear.Text == String.Empty)
                MessageBox.Show("Make and Year are empty");

            else
            {
                car.Accelerate();
                lblSpeed.Text = Convert.ToString(car.getSpeed());
            }
        }

        private void BrakeBtn_Click(object sender, EventArgs e)
        {
            if (txtboxMake.Text == String.Empty || txtBoxYear.Text == String.Empty)
                MessageBox.Show("Make and Year are empty");

            else
            {
                if (car.getSpeed() > 0)
                    car.Brake();
                else
                    MessageBox.Show("Speed cannot be negative", "Error");

                lblSpeed.Text = Convert.ToString(car.getSpeed());
            }
        }
    }
}
