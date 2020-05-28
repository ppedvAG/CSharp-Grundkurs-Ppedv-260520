using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M09Demo_WinForms
{
    public partial class Form1 : Form
    {
        /*
         * ÜBUNG:
         * Das Spiel soll nach jeder Runde auch neu gestartet werden können.
         * Anzahl der Gewinne von jedem Spieler wird nach jeder Runde ausgegeben.         
         */

        // fields
        int counter = 0;
        int oWon = 0;
        int xWon = 0;

        // ctor
        public Form1()
        {
            InitializeComponent();
        }

        // methods

        void CountSteps(object senderobj)
        {
            //string btntext = ((Button)senderobj).Text;
            string btntext = (senderobj as Button).Text;
            if (btntext == "")
            {
                if (counter % 2 == 0)
                {
                    (senderobj as Button).Text = "X";
                    CheckWinner("X");
                }
                else
                {
                    (senderobj as Button).Text = "O";
                    CheckWinner("O");
                }
                counter++;
            }
            else
            {
                MessageBox.Show("Bist du blind!? Klick woanders!");
            }
        }

        void CheckWinner(string x_or_o)
        {
            if(button1.Text == x_or_o && button2.Text == x_or_o && button3.Text == x_or_o)
            {
                MessageBox.Show($"{x_or_o} hat gewonnen");
                label3.Text += " " + x_or_o;
                // if (x_or_o == "X")
                    // label4 = xWon;               
                    
            }
            else if (button4.Text == x_or_o && button5.Text == x_or_o && button6.Text == x_or_o)
            {
                MessageBox.Show($"{x_or_o} hat gewonnen");
                label3.Text += " " + x_or_o;
            }
            else if (button7.Text == x_or_o && button8.Text == x_or_o && button9.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen!");
                label3.Text += " " + x_or_o;
            }
            else if (button1.Text == x_or_o && button4.Text == x_or_o && button7.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen!");
                label3.Text += " " + x_or_o;
            }
            else if (button2.Text == x_or_o && button5.Text == x_or_o && button8.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen!");
                label3.Text += " " + x_or_o;
            }
            else if (button3.Text == x_or_o && button6.Text == x_or_o && button9.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen!");
                label3.Text += " " + x_or_o;
            }
            else if (button1.Text == x_or_o && button5.Text == x_or_o && button9.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen!");
                label3.Text += " " + x_or_o;
            }
            else if (button3.Text == x_or_o && button5.Text == x_or_o && button7.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen!");
                label3.Text += " " + x_or_o;
            }
            else if (counter == 8)
            {
                MessageBox.Show("Unentschieden, macht lieber Sport!");
                Environment.Exit(0);
            }

        }
        private void button_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
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
