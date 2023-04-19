using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurphizVoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CUBOID

        double cuboidSfc(double l, double w, double h) // equation for cuboid surface area
        {
            return 2*((l*h) + (l*w) + (w*h));
        }

        double cuboidVol(double l, double w, double h) // equation for cuboid volume
        {
            return l * h * w;
        }



        // SPHERE
        double sphereSfc(double r)
        {
            return 4 * Math.PI * Math.Pow(r,2); // equation for sphere surface area
        }

        double sphereVol(double r)
        {
            return (4/3) * Math.PI * Math.Pow(r,3); // equation for sphere volume
        }



        // CONE
        double coneSfc(double r, double h)
        {
            return (Math.PI * r) * (r + Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r,2))); // equation for cone surface area
        }

        double coneVol(double r, double h)
        {
            return (1/3) * (Math.PI * Math.Pow(r, 2)) + h; // equation for cone volume
        }


        private void btnCub_Click(object sender, EventArgs e) // when cube's calcul888 button pressed
        {
            try 
            {
                // double variables are equal to the user's input in the 3 text boxes
                double cubLength = double.Parse(txtCubL.Text);
                double cubWidth = double.Parse(txtCubW.Text);
                double cubHeight = double.Parse(txtCubH.Text);

                // above variables are fed into the equations
                double cubSfc = cuboidSfc(cubLength, cubWidth, cubHeight);
                double cubVol = cuboidVol(cubLength, cubWidth, cubHeight);

                // these labels display the answer from the doubles above, to 4 sigfigs
                lblCubSfc.Text = "SURFACE AREA:    " + cubSfc.ToString("##.####") + " cm^2";
                lblCubVol.Text = "VOLUME:    " + cubVol.ToString("##.####") + " cm^3";
            }
            catch
            {
                // error handling
                lblCubSfc.Text = "SURFACE AREA:    INVALID INPUT";
                lblCubVol.Text = "VOLUME:    INVALID INPUT";
            } 
        }

        private void btnSph_Click(object sender, EventArgs e) // when sphere's calcul888 button pressed
        {
            try
            {
                // double variables are equal to the user's input in the text box
                double sphRadius = double.Parse(txtSphR.Text);

                double sphSfc = sphereSfc(sphRadius);
                double sphVol = sphereVol(sphRadius);

                lblSphSfc.Text = "SURFACE AREA:    " + sphSfc.ToString("##.####") + " cm^2";
                lblSphVol.Text = "VOLUME:    " + sphVol.ToString("##.####") + " cm^3";
            }
            catch
            {
                // error handling
                lblSphSfc.Text = "SURFACE AREA:    INVALID INPUT";
                lblSphVol.Text = "VOLUME:    INVALID INPUT";
            }
        }

        private void btnCon_Click(object sender, EventArgs e) // when cone's calcul888 button pressed
        {
            try
            {
                // double variables are equal to the user's input in the 2 text boxes
                double conRadius = double.Parse(txtConR.Text);
                double conHeight = double.Parse(txtConH.Text);

                double conSfc = coneSfc(conRadius, conHeight);
                double conVol = coneVol(conRadius, conHeight);

                lblConSfc.Text = "SURFACE AREA:    " + conSfc.ToString("##.####") + " cm^2";
                lblConVol.Text = "VOLUME:    " + conVol.ToString("##.####") + " cm^3";
            }
            catch
            {
                // error handling
                lblConSfc.Text = "SURFACE AREA:    INVALID INPUT";
                lblConVol.Text = "VOLUME:    INVALID INPUT";
            }
        }
    }
}
