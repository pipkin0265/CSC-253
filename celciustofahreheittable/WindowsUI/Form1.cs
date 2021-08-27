/**
 *08/18/2021
 *CSC 253
 *Michael Pipkin
 *Create an application that displays a table of the Celsius temperatures
 *0-20 and their Fahrenheit equivalents. The application should use loop to 
 *display the temperatures in a list box.
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

namespace WindowsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // declaring variables
            double cel = 0.0;
            double fah = 0.0;

            // clear list box
            lstBox.Items.Clear();
            lstBox.Items.Add("Celsius\t\tFahrenheit");

            // using while loop
            while (cel <= 20)
            {
                // convert temperature in to Fahrenheit
                fah = (9 * cel / 5) + 32;

                // add Celsius and Fahrenheit temperature into lstBox
                lstBox.Items.Add(cel.ToString() + "\t\t" + fah.ToString());
                
                // increment value of celsius
                cel++;
            }
        }
    }
}
