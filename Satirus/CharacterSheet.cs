using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Satirus
{
    public partial class form : System.Windows.Forms.Form
    {
        List<Item> inv, spell;
        List<string>[] inventorydata, spellbookdata;
        List<string> data;
        MySqlCommand cmd;
        string id;
        Connection conn;

        public form()
        {
            InitializeComponent();
            inv = new List<Item>();
            spell = new List<Item>();
            conn = new Connection();
            id = Master.idselected;

        }
        private void form_Load(object sender, EventArgs e)
        {
            initiallizeForm();



        }
        private void initiallizeForm()
        {
            if (id != "678879303")
            {
                data = conn.getPJ(id);
                tbName.Text = data[1].ToString();
                nudLevel.Value = Convert.ToInt32(data[2].ToString());
                tbRaza.Text = data[3].ToString();
                int order, karma;
                order = Convert.ToInt32(data[4].ToString());
                karma = Convert.ToInt32(data[5].ToString());
                leveler(Convert.ToInt32(data[6].ToString()));
                lblStr.Text = data[7].ToString();
                lblInt.Text = data[8].ToString();
                lblRes.Text = data[9].ToString();
                lblAgi.Text = data[10].ToString();
                lblCha.Text = data[11].ToString();
                lblluc.Text = data[12].ToString();
                baseStr.Value = Convert.ToInt32(data[13].ToString());
                baseInt.Value = Convert.ToInt32(data[14].ToString());
                baseRes.Value = Convert.ToInt32(data[15].ToString());
                baseAgi.Value = Convert.ToInt32(data[16].ToString());
                baseCha.Value = Convert.ToInt32(data[17].ToString());
                baseluc.Value = Convert.ToInt32(data[18].ToString());

                switch (order)
                {
                    case 1:
                        lawful.Select();
                        break;
                    case 2:
                        normal.Select();
                        break;
                    case 3:
                        chaotic.Select();
                        break;
                }
                switch (karma)
                {
                    case 1:
                        good.Select();
                        break;
                    case 2:
                        neutral.Select();
                        break;
                    case 3:
                        evil.Select();
                        break;
                }


                calcHealth();
                currenthp.Value = Convert.ToInt32(data[19].ToString());
                TSTR.Text = ((Convert.ToInt32(lblStr.Text)) + (baseStr).Value) + "";
                TINT.Text = ((Convert.ToInt32(lblInt.Text)) + (baseInt).Value) + "";
                TRES.Text = ((Convert.ToInt32(lblRes.Text)) + (baseRes).Value) + "";
                TAGI.Text = ((Convert.ToInt32(lblAgi.Text)) + (baseAgi).Value) + "";
                TCHA.Text = ((Convert.ToInt32(lblCha.Text)) + (baseCha).Value) + "";
                TLUC.Text = ((Convert.ToInt32(lblluc.Text)) + (baseluc).Value) + "";

                inventorydata = conn.SelectItems(id, false);
                spellbookdata = conn.SelectItems(id, true);
                int i = 0;
                while (i < inventorydata[0].Count)
                {
                    inv.Add(new Item(inventorydata[0].ElementAt(i), inventorydata[1].ElementAt(i)));
                    Inventory.Items.Add(inventorydata[0].ElementAt(i));
                    i++;
                }
                i = 0;
                while (i < spellbookdata[0].Count)
                {
                    spell.Add(new Item(spellbookdata[0].ElementAt(i), spellbookdata[1].ElementAt(i)));
                    Spellbook.Items.Add(spellbookdata[0].ElementAt(i));
                    i++;
                }


            }
            else
            {
                calcHealth();
                currenthp.Value = Convert.ToInt32(hptotal.Text);
            }
            calcSkillPoints();
        }
        private void calcHealth()
        {
            int hp;
            hp = ((Convert.ToInt32(nudLevel.Value) * 10) + (Convert.ToInt32(lblStr.Text)) + (Convert.ToInt32(lblRes.Text) * 2) + (Convert.ToInt32(baseStr.Text)) + (Convert.ToInt32(baseRes.Text) * 2));
            health.Maximum = hp;
            hptotal.Text = hp + "";
            currenthp.Maximum = hp;
        }
        private void level_ValueChanged(object sender, EventArgs e)
        {
            if (nudLevel.Value < 1)
            {
                nudLevel.Value = 0;
            }
            if (nudLevel.Value > 100)
            {
                nudLevel.Value = 100;
            }
            expProgress.Maximum = Convert.ToInt32(nudLevel.Value) * 1000;
            lblExpCounter.Text = 0 + "";
            nudExpAdd.Value = 0;
            expProgress.Value = 0;
            calcSkillPoints();
            calcHealth();
        }
        private void calcSkillPoints()
        {
            int pos, neg;
            pos = Convert.ToInt32(nudLevel.Value) * 6;
            neg = (Convert.ToInt32(lblStr.Text) + Convert.ToInt32(lblInt.Text) + Convert.ToInt32(lblRes.Text) + Convert.ToInt32(lblAgi.Text) + Convert.ToInt32(lblCha.Text) + Convert.ToInt32(lblluc.Text)) - (Convert.ToInt32(baseStr.Value) + Convert.ToInt32(baseInt.Value) + Convert.ToInt32(baseRes.Value) + Convert.ToInt32(baseAgi.Value) + Convert.ToInt32(baseCha.Value) + Convert.ToInt32(baseluc.Value));
            skillPoints.Text = (pos - neg) + "";
        }
        private void btnExpAdd_Click(object sender, EventArgs e)
        {
            int add = Convert.ToInt32(nudExpAdd.Value);
            leveler(add);
        }
        private void leveler(int exp)
        {
            exp = exp + expProgress.Value;
            while (canLevel(exp))
            {
                exp = exp - expProgress.Maximum;
                nudLevel.Value = nudLevel.Value + 1;
                expProgress.Maximum = Convert.ToInt32(nudLevel.Value) * 1000;
            }
            if (nudLevel.Value < 100)
            {
                lblExpCounter.Text = "" + exp;
                expProgress.Value = exp;
            }
            else
            {
                expProgress.Value = expProgress.Maximum;
                lblExpCounter.Text = "MAX"; ;
            }
        }
        private Boolean canLevel(int exp)
        {
            if (exp >= expProgress.Maximum)
            {
                if (nudLevel.Value < 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                lblExpCounter.Text = "" + exp;
                expProgress.Value = exp;
                return false;
            }
        }

        private void baseStr_ValueChanged(object sender, EventArgs e)
        {
            TSTR.Text = ((Convert.ToInt32(lblStr.Text)) + ((NumericUpDown)sender).Value) + "";
            calcHealth();
        }

        private void baseInt_ValueChanged(object sender, EventArgs e)
        {
            TINT.Text = ((Convert.ToInt32(lblInt.Text)) + ((NumericUpDown)sender).Value) + "";
        }

        private void baseRes_ValueChanged(object sender, EventArgs e)
        {
            TRES.Text = ((Convert.ToInt32(lblRes.Text)) + ((NumericUpDown)sender).Value) + "";
            calcHealth();
        }

        private void baseAgi_ValueChanged(object sender, EventArgs e)
        {
            TAGI.Text = ((Convert.ToInt32(lblAgi.Text)) + ((NumericUpDown)sender).Value) + "";
        }

        private void baseCha_ValueChanged(object sender, EventArgs e)
        {
            TCHA.Text = ((Convert.ToInt32(lblCha.Text)) + ((NumericUpDown)sender).Value) + "";
        }

        private void baseluc_ValueChanged(object sender, EventArgs e)
        {
            TLUC.Text = ((Convert.ToInt32(lblluc.Text)) + ((NumericUpDown)sender).Value) + "";
        }

        private void lessStr_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToInt32(lblStr.Text) <= 0))
            {
                lblStr.Text = (Convert.ToInt32(lblStr.Text) - 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) + 1);
            }
            TSTR.Text = ((Convert.ToInt32(lblStr.Text)) + (baseStr).Value) + "";
            calcHealth();
        }

        private void moreStr_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(skillPoints.Text) > 0))
            {
                lblStr.Text = (Convert.ToInt32(lblStr.Text) + 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) - 1);
            }
            TSTR.Text = ((Convert.ToInt32(lblStr.Text)) + (baseStr).Value) + "";
            calcHealth();
        }

        private void lessInt_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToInt32(lblInt.Text) <= 0))
            {
                lblInt.Text = (Convert.ToInt32(lblInt.Text) - 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) + 1);
            }
            TINT.Text = ((Convert.ToInt32(lblInt.Text)) + (baseInt).Value) + "";
        }

        private void moreInt_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(skillPoints.Text) > 0))
            {
                lblInt.Text = (Convert.ToInt32(lblInt.Text) + 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) - 1);
            }
            TINT.Text = ((Convert.ToInt32(lblInt.Text)) + (baseInt).Value) + "";
        }

        private void lessRes_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToInt32(lblRes.Text) <= 0))
            {
                lblRes.Text = (Convert.ToInt32(lblRes.Text) - 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) + 1);
            }
            TRES.Text = ((Convert.ToInt32(lblRes.Text)) + (baseRes).Value) + "";
            calcHealth();
        }

        private void moreRes_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(skillPoints.Text) > 0))
            {
                lblRes.Text = (Convert.ToInt32(lblRes.Text) + 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) - 1);
            }
            TRES.Text = ((Convert.ToInt32(lblRes.Text)) + (baseRes).Value) + "";
            calcHealth();
        }

        private void lessAgi_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToInt32(lblAgi.Text) <= 0))
            {
                lblAgi.Text = (Convert.ToInt32(lblAgi.Text) - 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) + 1);
            }
            TAGI.Text = ((Convert.ToInt32(lblAgi.Text)) + (baseAgi).Value) + "";
        }

        private void moreAgi_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(skillPoints.Text) > 0))
            {
                lblAgi.Text = (Convert.ToInt32(lblAgi.Text) + 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) - 1);
            }
            TAGI.Text = ((Convert.ToInt32(lblAgi.Text)) + (baseAgi).Value) + "";
        }

        private void lessCha_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToInt32(lblCha.Text) <= 0))
            {
                lblCha.Text = (Convert.ToInt32(lblCha.Text) - 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) + 1);
            }
            TCHA.Text = ((Convert.ToInt32(lblCha.Text)) + (baseCha).Value) + "";
        }

        private void moreCha_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(skillPoints.Text) > 0))
            {
                lblCha.Text = (Convert.ToInt32(lblCha.Text) + 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) - 1);
            }
            TCHA.Text = ((Convert.ToInt32(lblCha.Text)) + (baseCha).Value) + "";
        }

        private void lessLu_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToInt32(lblluc.Text) <= 0))
            {
                lblluc.Text = (Convert.ToInt32(lblluc.Text) - 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) + 1);
            }
            TLUC.Text = ((Convert.ToInt32(lblluc.Text)) + (baseluc).Value) + "";
        }

        private void moreLu_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(skillPoints.Text) > 0))
            {
                lblluc.Text = (Convert.ToInt32(lblluc.Text) + 1) + "";
                skillPoints.Text = "" + ((Convert.ToInt32(skillPoints.Text)) - 1);
            }
            TLUC.Text = ((Convert.ToInt32(lblluc.Text)) + (baseluc).Value) + "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (itemname.Text.Trim() != "")
            {
                Inventory.Items.Add(itemname.Text.Trim());
                if (itemdescr.Text.Trim() != "")
                    inv.Add(new Item(itemname.Text.Trim(), itemdescr.Text.Trim()));

                else
                    inv.Add(new Item(itemname.Text.Trim(), "---"));
            }
            itemname.Text = "";
            itemdescr.Text = "";
        }

        private void Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Inventory.SelectedIndex;
            if (index != -1)
            {
                itemdsc.Text = inv[index].ItemDescr;
            }
            else
                itemdsc.Text = "";
        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
            int index = Inventory.SelectedIndex;
            if (index != -1)
            {
                Inventory.Items.RemoveAt(index);
                inv.RemoveAt(index);
            }
        }



        private void Addspl_Click(object sender, EventArgs e)
        {
            if (spellname.Text.Trim() != "")
            {
                Spellbook.Items.Add(spellname.Text.Trim());
                if (spelldescr.Text.Trim() != "")
                    spell.Add(new Item(spellname.Text.Trim(), spelldescr.Text.Trim()));

                else
                    spell.Add(new Item(spellname.Text.Trim(), "---"));
            }
            spellname.Text = "";
            spelldescr.Text = "";
        }

        private void Spellbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Spellbook.SelectedIndex;
            if (index != -1)
            {
                spelldesc.Text = spell[index].ItemDescr;
            }
            else
                spelldesc.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void deletespell_Click_1(object sender, EventArgs e)
        {
            int index = Spellbook.SelectedIndex;
            if (index != -1)
            {
                Spellbook.Items.RemoveAt(index);
                spell.RemoveAt(index);
            }
        }
        private int getselectedo()
        {
            int i = 2;
            if (lawful.Checked)
            {
                i = 1;
            }
            if (normal.Checked)
            {
                i = 2;
            }
            if (chaotic.Checked)
            {
                i = 3;
            }
            return i;

        }
        private int getselectedk()
        {
            int i = 2;
            if (good.Checked)
            {
                i = 1;
            }
            if (neutral.Checked)
            {
                i = 2;
            }
            if (evil.Checked)
            {
                i = 3;
            }
            return i;

        }


        private void currenthp_ValueChanged(object sender, EventArgs e)
        {
            health.Value = Convert.ToInt32(currenthp.Value);
        }

        private void saveplayer(object sender, EventArgs e)
        {
            if (Convert.ToInt32(skillPoints.Text) >= 0)
            {
                conn.Delete("satirus.pj", "name", "'" + tbName.Text + "'");
                conn.Insert("satirus.pj", "`name`, `level`, `race`, `order`, `karma`, `exp`, `str`, `int`, `res`, `agi`, `cha`, `luc`, `bstr`, `bint`, `bres`, `bagi`, `bcha`, `bluc`, `hp`", "'" + tbName.Text + "', " + Convert.ToInt32(nudLevel.Value) + ", '" + tbRaza.Text + "', " + getselectedo() + ", " + getselectedk() + ", " + Convert.ToInt32(lblExpCounter.Text) + ", " + Convert.ToInt32(lblStr.Text) + ",  " + Convert.ToInt32(lblInt.Text) + ",  " + Convert.ToInt32(lblRes.Text) + ",  " + Convert.ToInt32(lblAgi.Text) + ",  " + Convert.ToInt32(lblCha.Text) + ",  " + Convert.ToInt32(lblluc.Text) + ",  " + Convert.ToInt32(baseStr.Text) + ", " + Convert.ToInt32(baseInt.Text) + ", " + Convert.ToInt32(baseRes.Text) + ", " + Convert.ToInt32(baseAgi.Text) + ", " + Convert.ToInt32(baseCha.Text) + ", " + Convert.ToInt32(baseluc.Text) + ", " + Convert.ToInt32(currenthp.Value));
                id = conn.getID(tbName.Text);
                conn.Delete("satirus.inventory", "owner", "'" + id + "'");
                int i = 0;
                while (i < inv.Count)
                {
                    conn.Insert("satirus.inventory", "`owner`, `item`, `description`", id + ",'" + inv[i].ItemName + "','" + inv[i].ItemDescr + "'");
                    i++;
                }
                conn.Delete("satirus.spellbook", "owner", "'" + id + "'");
                i = 0;
                while (i < spell.Count)
                {
                    conn.Insert("satirus.spellbook", " `owner`, `spell`, `description`", "'" + id + "','" + spell[i].ItemName + "','" + spell[i].ItemDescr + "'");
                    i++;
                }

                MessageBox.Show("Character successfully saved!", "Accept");
            }
            else
            {
                MessageBox.Show("You can't use that many skillpoints at your current level \n\n                           (Current skillpoints: " + skillPoints.Text + ")", "Skillpoints error");
            }
        }
    }
}
