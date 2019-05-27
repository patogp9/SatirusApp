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
    public partial class battlesim : Form
    {
        public int selectedally, selectedmonster;
        public bool fren;
        public battlesim()
        {
            InitializeComponent();
        }

        private void battlesim_Load(object sender, EventArgs e)
        {
            selectedally = 1;
            selectedmonster = 1;
            fren = true;
        }


        private void rbally_CheckedChanged(object sender, EventArgs e)
        {
            fren = true;
            RadioButton rb = (RadioButton)sender;
            selectedally = Convert.ToInt32(rb.Tag);
            indexselally.Text = selectedally+"";

        }

        private void rbene_CheckedChanged(object sender, EventArgs e)
        {
            fren = false;
            RadioButton rb = (RadioButton)sender;
            selectedmonster = Convert.ToInt32(rb.Tag);
            indexselene.Text = selectedmonster+"";
        }

        private void faction_chkchngd(object sender, EventArgs e)
        {
            if (allys.Checked)
            {
                checkBox1.Enabled = true;
                panel3.BackColor = Color.SkyBlue;
                label1.Text = "Ally Attacks Monster";
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
                panel3.BackColor = Color.Salmon;
                label1.Text = "Monster Attacks Ally";
            }
        }

        private List<int> getvalues()
        {
            List<int> lista = new List<int>();
            fighter f = new fighter();
            f = fighter1;
            Monster m = new Monster();
            switch (selectedally)
            {
                case 1:
                    f = fighter1;
                   
                    break;
                case 2:
                    f = fighter2;
                   
                    break;
                case 3:
                    f = fighter3;
                   
                    break;
                case 4:
                    f = fighter4;
                    
                    break;
                case 5:
                    f = fighter5;
                    
                    break;
                case 6:
                    f = fighter6;
                   
                    break;
            }
            switch (selectedmonster)
            {
                case 1:
                    m = monster1;
                    break;
                case 2:
                    m = monster2;
                    break;
                case 3:
                    m = monster3;
                    break;
                case 4:
                    m = monster4;
                    break;
                case 5: 
                    m = monster5;
                    break;
                case 6:
                    m = monster6;
                    break;
            }
            if (allys.Checked) {
                lista.Insert(0, Convert.ToInt32(f.level.Value));
                lista.Insert(1, Convert.ToInt32(f.strstat.Value));
                lista.Insert(2, Convert.ToInt32(f.intstat.Value));
                lista.Insert(3, Convert.ToInt32(f.resstat.Value));
                lista.Insert(4, Convert.ToInt32(f.agistat.Value));
                lista.Insert(5, Convert.ToInt32(f.chastat.Value));
                lista.Insert(6, Convert.ToInt32(f.lucstat.Value));
                lista.Insert(7, Convert.ToInt32(m.defense.Text));
            }else
            {
                lista.Insert(0, Convert.ToInt32(m.level.Value));
                lista.Insert(1, Convert.ToInt32(m.power.Text));
                lista.Insert(2, Convert.ToInt32(m.power.Text));
                lista.Insert(3, Convert.ToInt32(m.defense.Text));
                lista.Insert(4, Convert.ToInt32(m.speed.Text));
                lista.Insert(5, Convert.ToInt32(m.speed.Text));
                lista.Insert(6, Convert.ToInt32(m.speed.Text));
                lista.Insert(7, Convert.ToInt32(f.resstat.Value));
            }


            return lista;
        }

        private void dado_ValueChanged(object sender, EventArgs e)
        {
            modifier.Text =(Convert.ToDouble(dado.Value) / 10)+"";
        }

        private void dmgcalc_Click(object sender, EventArgs e)
        {
            res.Text=damagecalculus(getvalues());
        }

        private string damagecalculus(List<int> values)
        {
            string res="";
            double damage;
            int power = checkBox1.Checked ? values[2] : values[1];
            int def = values[7];
            damage = (((((((2 * values[0]) / 5) + 2) * (Convert.ToDouble(atackpowa.Value) * (power+1) / (def+1))) / 50) + 2) * Convert.ToDouble(modifier.Text));
            res = Math.Round(damage) + "";


            return res;
        }
    }
}
