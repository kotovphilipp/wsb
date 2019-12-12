using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a,x;
        int count;
        bool znak = true;
        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
         

        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(count)
            {
                case 1:
                    x = a + float.Parse(result.Text);
                    result.Text = x.ToString();
                    break;

                case 2:
                    x = a - float.Parse(result.Text);
                    result.Text = x.ToString();
                    break;
                case 3:
                    x = a * float.Parse(result.Text);
                    result.Text = x.ToString();
                    break;
                case 4:
                    x = a / float.Parse(result.Text);
                    result.Text = x.ToString();
                    break;
                default:
                    break;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
         

        }

        private void button10_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            condition = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
          

        }

        private void button6_Click(object sender, EventArgs e)
        {
       
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
          

        }

        private void buttondeli_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonumnoz_Click(object sender, EventArgs e)
        {
          

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
        

        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            a = float.Parse(result.Text);
            result.Clear();
            count = 1;
            znak = true;
            

        }

        private void buttondot_Click(object sender, EventArgs e)
        {
           

        }
        bool condition = false;
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (condition == false)
            {
                result.Text = b.Text;

                condition = true;
            }
            else
            {
                result.Text += b.Text;
            }
            
        }
    }
}
