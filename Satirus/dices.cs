using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satirus
{
    public partial class dices : Form
    {
        public dices()
        {
            InitializeComponent();
        }


        public int diceRoll(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private void rd3_Click(object sender, EventArgs e)
        {
            d3.Text = diceRoll(1, 3) + "";
        }

        private void rd6_Click(object sender, EventArgs e)
        {
            d6.Text = diceRoll(1, 6) + "";
        }

        private void rd8_Click(object sender, EventArgs e)
        {
            d8.Text = diceRoll(1, 8) + "";
        }

        private void rd10_Click(object sender, EventArgs e)
        {
            d10.Text = diceRoll(1, 10) + "";
        }

        private void rd12_Click(object sender, EventArgs e)
        {
            d12.Text = diceRoll(1, 12) + "";
        }

        private void rd20_Click(object sender, EventArgs e)
        {
            d20.Text = diceRoll(1, 20) + "";
        }

        private void rd100_Click(object sender, EventArgs e)
        {

            int per = diceRoll(0, 9);
            string numerus;
            switch (per)
            {
                case 0:
                    numerus = "00";
                    break;
                case 1:
                    numerus = "10";
                    break;
                case 2:
                    numerus = "20";
                    break;
                case 3:
                    numerus = "30";
                    break;
                case 4:
                    numerus = "40";
                    break;
                case 5:
                    numerus = "50";
                    break;
                case 6:
                    numerus = "60";
                    break;
                case 7:
                    numerus = "70";
                    break;
                case 8:
                    numerus = "80";
                    break;
                case 9:
                    numerus = "90";
                    break;
                default:
                    numerus = "err0r";
                    break;
            }
            d100.Text = "" + numerus;
        }
    }
}
