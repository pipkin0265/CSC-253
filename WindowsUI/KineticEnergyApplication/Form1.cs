using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KineticEnergyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcKE_Click(object sender, EventArgs e)
        {
            // get the object's mass from the
            // massTextBox
            double m = double.Parse(massTxtBox.Text);

            // get the object's velocity from the
            // velocityTxtBox
            double v = double.Parse(velocityTxtBox.Text);

            // call the KineticEnergy method to get
            // the Kinetic Energy
            double ke = KineticEnergy(m, v);

            // display the Kinetic Energy in the
            // lblKeneticEnerfy.Text
            lblKeneticEnergy.Text = ke.ToString("E2");
        }

        private double KineticEnergy(double m, double v)
        {
            return (0.5 * m * v * v);
        }
    }
}
