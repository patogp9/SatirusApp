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
    public partial class fighter : UserControl
    {
        Connection conn;
        List<string> names;
        List<string> data;
        public static string idselected;
        public static string namefght;
        int hpmax;
        public static int strtotal, restotal, inttotal, agitotal, chatotal, luctotal, levelfght, healthp;

    

        public fighter()
        {
            InitializeComponent();
        }

        private void namechar_Click(object sender, EventArgs e)
        {
            names = conn.SelectPJList()[1];
            namechar.Items.Clear();
            int i = 0;
            i = 0;
            while (i < names.Count)
            {
                namechar.Items.Add(names.ElementAt(i));
                i++;
            }

        }

        public void rbselect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sethp()
        {
         
            hpmax = (strtotal + (restotal * 2)) + (levelfght * 10);
            tothp.Text = hpmax+"";
            currhp.Maximum = hpmax;
            currhp.Value = healthp;
            hp.Maximum = hpmax;
            hp.Value = healthp;
        }

        private void currhp_ValueChanged(object sender, EventArgs e)
        {
            healthp = Convert.ToInt32(currhp.Value);
            
            sethp();
        }

        private void resstat_ValueChanged(object sender, EventArgs e)
        {
           
            restotal = Convert.ToInt32(resstat.Value);
           
            sethp();
        }

        private void strstat_ValueChanged(object sender, EventArgs e)
        {
            
            strtotal = Convert.ToInt32(strstat.Value);
            
            sethp();
        }

        private void level_ValueChanged(object sender, EventArgs e)
        {
            levelfght=(Convert.ToInt32(level.Value));

            sethp();
        }

        private void fighter_Load(object sender, EventArgs e)
        {
            conn = new Connection();
            names = conn.SelectPJList()[1];
            int i = 0;
            i = 0;
            while (i < names.Count)
            {
                namechar.Items.Add(names.ElementAt(i));
                i++;
            }

        }
        private void namechar_changed(object sender, EventArgs e)
        {

            idselected = conn.getID(namechar.SelectedItem.ToString());

            data = conn.getPJ(idselected);
            levelfght = Convert.ToInt32(data[2]);
            namefght = data[1];
            healthp = Convert.ToInt32(data[19]);
            strtotal = (Convert.ToInt32(data[7]) + Convert.ToInt32(data[13]));
            inttotal = (Convert.ToInt32(data[8]) + Convert.ToInt32(data[14]));
            restotal = (Convert.ToInt32(data[9]) + Convert.ToInt32(data[15]));
            agitotal = (Convert.ToInt32(data[10]) + Convert.ToInt32(data[16]));
            chatotal = (Convert.ToInt32(data[11]) + Convert.ToInt32(data[17]));
            luctotal = (Convert.ToInt32(data[12]) + Convert.ToInt32(data[18]));
            

            namechar.Text = namefght;
            level.Value = levelfght;
            strstat.Value = strtotal;
            intstat.Value = inttotal;
            resstat.Value = restotal;
            agistat.Value = agitotal;
            chastat.Value = chatotal;
            lucstat.Value = luctotal;
         
            sethp();
        }


    }
}
