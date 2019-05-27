using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satirus
{
    public partial class Monster : UserControl
    {
        public int levelvalue;
        public double  pwrs, defs, spes;
        public Monster()
        {
            InitializeComponent();
        }
        private void Monster_Load(object sender, EventArgs e)
        {
            levelvalue = 0;
            pwrs = 0;
            defs = 0;
            spes = 0;
        }
        private void sethp()
        {
            hp.Maximum = Convert.ToInt32(numericUpDown1.Maximum);
            hp.Value = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sethp();
        }

        private void level_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Convert.ToInt32(level.Value) * 10;
            maxhp.Text = (Convert.ToInt32(level.Value) * 10) + "";
            numericUpDown1.Value = numericUpDown1.Maximum;
            levelvalue = Convert.ToInt32(level.Value);
            power.Text = Math.Round((pwrs * Convert.ToInt32(level.Value)) / 10) + "";
            defense.Text = Math.Round((defs * Convert.ToInt32(level.Value)) / 10) + "";
            speed.Text = Math.Round((spes * Convert.ToInt32(level.Value)) / 10) + "";
            sethp();
        }

        private void pwrstat_ValueChanged(object sender, EventArgs e)
        {
            pwrs = Convert.ToInt32(pwrstat.Value);
            power.Text = Math.Round((pwrs*Convert.ToInt32(level.Value))/10) + "";

        }

        private void defstat_ValueChanged(object sender, EventArgs e)
        {
            defs = Convert.ToInt32(defstat.Value);
            defense.Text = Math.Round((defs * Convert.ToInt32(level.Value))/10) + "";
        }

        private void spestat_ValueChanged(object sender, EventArgs e)
        {
            spes = Convert.ToInt32(spestat.Value);
            speed.Text = Math.Round((spes * Convert.ToInt32(level.Value))/10) + "";
        }
    }
}
