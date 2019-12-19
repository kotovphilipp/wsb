using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanyatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBok_TextChanged(object sender, EventArgs e)
        {
            double bok;

            if (double.TryParse(txtBok.Text, out bok) && bok > 0) 
            {
                txtPole.Text = Math.Pow(bok, 2).ToString();
                txtObwod.Text = (4 * bok).ToString();
                lblKomunikat.Text = "ok";
            }
            else
            {
                lblKomunikat.Text = "Wpisz liczbe dodatnia";
                txtPole.Text = String.Empty;
                txtObwod.Text = String.Empty;
            }
        }

        private void txtObwod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBok.Text = String.Empty;
            txtObwod.Text = String.Empty;
            txtPole.Text = String.Empty;
            lblKomunikat.Text = "wpisz wymiar boku";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formColor = new Color();
            formColor.Show();
        }
    }
}
