using MySql.Data.MySqlClient;
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
    public partial class Master : System.Windows.Forms.Form
    {
        Connection conn;
        List<string> names;
        public static string idselected;
        public Master()
        {
            InitializeComponent();
        }
        private void Master_Load(object sender, EventArgs e)
        {

            conn = new Connection();
            conn.createdatabase();
            names = conn.SelectPJList()[1];
            int i = 0;
            i = 0;
            while (i < names.Count)
            {
                comboBox1.Items.Add(names.ElementAt(i));
                i++;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            idselected = "678879303";
            form chars = new form();
            chars.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load.Enabled = true;
            idselected = conn.getID(comboBox1.SelectedItem.ToString());
            idt.Text = idselected;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            names = conn.SelectPJList()[1];
            comboBox1.Items.Clear();
            int i = 0;
            i = 0;
            while (i < names.Count)
            {
                comboBox1.Items.Add(names.ElementAt(i));
                i++;
            }

        }

        private void load_Click(object sender, EventArgs e)
        {
            idselected = conn.getID(comboBox1.SelectedItem.ToString());
            form chars = new form();
            chars.Show();
        }

        private void battlesimulator_Click(object sender, EventArgs e)
        {
            battlesim bs = new battlesim();
            bs.Show();
        }

        private void dicebutton_Click(object sender, EventArgs e)
        {
            dices dice = new dices();
            dice.Show();
        }
    }
}
