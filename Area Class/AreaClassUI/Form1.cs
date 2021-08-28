/**
 * 08/28/2021
 * CSC 253
 * Michael Pipkin II
 * Write a class that has three overload static methods for calculating the areas
 * of the follwoing geometric shapes: Circles, Rectangle, Cylinders.
 **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaLibrary;

namespace AreaClassUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        AreaLibrary.Area area = new Area();

        // Event below rises when user clicks on Area of
        // circle radio button. If clicked then groupbox
        // is enabled to calculate area of circle and
        // rest are disabled
        private void CircleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // check if CircleRadioBtn is checked if so
            if (CircleRadioBtn.Checked)
            {
                // enable the circle group box and disable rest
                circleGroupBox.Enabled = true;
                rectangleGroupBox.Enabled = false;
                cyGroupBox.Enabled = false;
            }
        }

        // Event below rises when user clicks on Area of
        // rectangle radio button. If clicked then groupbox
        // is enabled to calculate area of rectangle and
        // rest are disabled
        private void RectanleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RectanleRadioBtn.Checked)
            {
                circleGroupBox.Enabled = false;
                // enable rectangle group box and disable rest
                rectangleGroupBox.Enabled = true;
                cyGroupBox.Enabled = false;
            }
        }

        // Event below rises when user clicks on Area of
        // rectangle radio button. If clicked then groupbox
        // is enabled to calculate area of rectangle and
        // rest are disabled
        private void CylRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // check if cylinderRadioBtn is checked
            if (CylRadioBtn.Checked)
            {
                circleGroupBox.Enabled = false;
                rectangleGroupBox.Enabled = false;
                // enable the cylinder group box and disable rest
                cyGroupBox.Enabled = true;
            }
        }
    // Event rises when user clicks calculate area of circle button
        private void circleBtn_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(radiusTxtBox.Text);

            MessageBox.Show("Area of circle: " + area.ToString());
        }

        // Event rises when user clicks calculate area of rectangle button
        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(lengthTxtBox.Text);

            double width = Convert.ToDouble(widthTxtBox.Text);

            double area = Area.getArea(width, length);

            MessageBox.Show("Area of rectangle: " + area.ToString());
        }

        // Event rises when user clicks calculate area of Cylinder button
        private void cylinderBtn_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(cyRadiusTxtBox.Text);

            double height = Convert.ToDouble(cyHeightTxtBox.Text);

            double area = Area.getArea(radius, height, true);

            MessageBox.Show("Area of cylinder: " + area.ToString());
        }
    }
}
