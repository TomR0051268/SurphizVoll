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

        double cuboidSfc(double l, double w, double h)
        {
            return 2*((l*h) + (l*w) + (w*h));
        }

        double cuboidVol(double l, double w, double h)
        {
            return l * h * w;
        }

        // SPHERE
        double sphereSfc(double r)
        {
            return 4 * Math.PI * Math.Pow(r,2);
        }

        double sphereVol(double r)
        {
            return (4/3) * Math.PI * Math.Pow(r,3);
        }

        // CONE
        double conSfc(double r, double h)
        {
            return (Math.PI * r) * (r + Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r,2)));
        }

        double conVol(double r, double h)
        {
            return (1/3) * (Math.PI * Math.Pow(r, 2)) + h;
        }


        private void btnCub_Click(object sender, EventArgs e)
        {
            try 
            {
                double cubLength = double.Parse(txtCubL.Text);
                double cubWidth = double.Parse(txtCubW.Text);
                double cubHeight = double.Parse(txtCubH.Text);

                lblCubSfc.Text = "SURFACE AREA:    " + cuboidSfc(cubLength, cubWidth, cubHeight);
                lblCubVol.Text = "VOLUME:    " + cuboidVol(cubLength, cubWidth, cubHeight);
            }
            catch
            {
                lblCubSfc.Text = "SURFACE AREA:    INVALID INPUT";
                lblCubVol.Text = "VOLUME:    INVALID INPUT";
            } 
        }

        private void btnSph_Click(object sender, EventArgs e)
        {
            try
            {
                double sphRadius = double.Parse(txtSphR.Text);
                lblSphSfc.Text = "SURFACE AREA:    " + sphereSfc(sphRadius);
                lblSphVol.Text = "VOLUME:    " + sphereVol(sphRadius);
            }
            catch
            {
                lblSphSfc.Text = "SURFACE AREA:    INVALID INPUT";
                lblSphVol.Text = "VOLUME:    INVALID INPUT";
            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            try
            {
                double conRadius = double.Parse(txtConR.Text);
                double conHeight = double.Parse(txtConH.Text);

                lblConSfc.Text = "SURFACE AREA:    " + conSfc(conRadius, conHeight);
                lblConVol.Text = "VOLUME:    " + conVol(conRadius, conHeight);
            }
            catch
            {
                lblConSfc.Text = "SURFACE AREA:    INVALID INPUT";
                lblConVol.Text = "VOLUME:    INVALID INPUT";
            }
        }
    }
}
