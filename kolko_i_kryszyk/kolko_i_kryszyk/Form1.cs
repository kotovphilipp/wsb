﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_i_kryszyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int click = 0;
        bool notwin = true;


        private void button1_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button1.Text != "X" && notwin)
            {
                button1.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }


            if(click % 2 ==1 && button1.Text != "0" && notwin)
            {
                button1.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button9.Text == "X" && button6.Text == "X" && button1.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }

            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button9.Text == "0" && button6.Text == "0" && button1.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button1.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }

            if(button1.Text !="" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                notwin = true;
                label1.Text = "Remis";
            }

            
        }

     
        private void button9_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button9.Text != "X" && notwin)
            {
                button9.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button9.Text != "0" && notwin)
            {
                button9.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button9.Text == "X" && button6.Text == "X" && button1.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }


            if (button9.Text == "0" && button8.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button9.Text == "0" && button6.Text == "0" && button1.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button3.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button2.Text != "X" && notwin)
            {
                button2.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button2.Text != "0" && notwin)
            {
                button2.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }

            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button3.Text != "X" && notwin)
            {
                button3.Text = "0"; 
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button3.Text != "0" && notwin)
            {
                button3.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }


            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button3.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button3.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button4.Text != "X" && notwin)
            {
                button4.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button4.Text != "0" && notwin)
            {
                button4.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button6.Text == "X" && button5.Text == "X" && button4.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }


            if (button6.Text == "0" && button5.Text == "0" && button4.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button3.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button5.Text != "X" && notwin)
            {
                button5.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button5.Text != "0" && notwin)
            {
                button5.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button6.Text == "X" && button5.Text == "X" && button4.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }



            if (button6.Text == "0" && button5.Text == "0" && button4.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button1.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button3.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button6.Text != "X" && notwin)
            {
                button6.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button6.Text != "0" && notwin)
            {
                button6.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button6.Text == "X" && button5.Text == "X" && button4.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button9.Text == "X" && button6.Text == "X" && button1.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }


            if (button6.Text == "0" && button5.Text == "0" && button4.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button9.Text == "0" && button6.Text == "0" && button1.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button7.Text != "X" && notwin)
            {
                button7.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button7.Text != "0" && notwin)
            {
                button7.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }



            if (button9.Text == "0" && button8.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button3.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button1.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button8.Text != "X" && notwin)
            {
                button8.Text = "0";
                label1.Text = "Kolejny gracz X";
                click++;
            }

            if (click % 2 == 1 && button8.Text != "0" && notwin)
            {
                button8.Text = "X";
                label1.Text = "Kolejny gracz 0";
                click++;
            }
            if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label1.Text = "Wygrywa gracz X";
                notwin = false;
            }


            if (button9.Text == "0" && button8.Text == "0" && button7.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                label1.Text = "Wygrywa gracz 0";
                notwin = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            notwin = true;

            if(click % 2 == 0)
            {
                label1.Text = "Kolej gracza 0";
            }
            else
            {
                label1.Text = "Kolej gracza X";
            }
                       
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
    }
}
