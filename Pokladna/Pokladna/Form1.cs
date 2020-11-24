using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
    public partial class Form1 : Form
    {
        List<PokladniZaznam> pokladna;
        IRepos repositar;
        PokladniZaznam vybranyZaznam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonRepos jsonRepos = new JsonRepos("data.json");
            //jsonRepos.VytvorTestData();
            SqlRepos sqlRepos = new SqlRepos();
            //sqlRepos.VytvorTestData(jsonRepos.NactiVse());
            repositar = sqlRepos;

            comboBoxRok.SelectedIndex = comboBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
            comboBoxMesic.SelectedIndex = DateTime.Now.Month-1;

            //repositar = new SqlRepos();
            //repositar = new XmlRepos();
            //pokladna = repositar.NactiVse(); 
            //foreach (var p in pokladna)
            //{
            //    listView1.Items.Add(p.DoLvItem());
            //}
        }

        private void NactiAktMesic()
        {
            if (comboBoxRok.SelectedIndex >= 0 && comboBoxMesic.SelectedIndex >= 0)
            {
                pokladna = repositar.NactiMesic(int.Parse(comboBoxRok.SelectedItem.ToString()), comboBoxMesic.SelectedIndex + 1);
                listView1.Items.Clear();
                foreach (var p in pokladna)
                {
                    listView1.Items.Add(p.DoLvItem());
                }
            }
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            NactiAktMesic();
        }

        private void textBoxCisloDokladu_TextChanged(object sender, EventArgs e)
        {
            buttonUlozit.Enabled = textBoxCisloDokladu.Text != "";
        }

        private void textBoxPopis_TextChanged(object sender, EventArgs e)
        {
            buttonUlozitJakoNovy.Enabled = textBoxPopis.Text.Trim() != "" && numericUpDownCastka.Value != 0;
        }

        private void numericUpDownCastka_ValueChanged(object sender, EventArgs e)
        {
            buttonUlozitJakoNovy.Enabled = textBoxPopis.Text.Trim() != "" && numericUpDownCastka.Value != 0;
        }

        private void buttonUlozitJakoNovy_Click(object sender, EventArgs e)
        {
            PokladniZaznam novyZaznam = new PokladniZaznam(dateTimePickerDatum.Value, textBoxPopis.Text, (double)numericUpDownCastka.Value, textBoxPoznamka.Text);
            repositar.VytvorZaznam(novyZaznam);
            NactiAktMesic();
            textBoxPopis.Text = "";
            numericUpDownCastka.Value = 0;
            textBoxPoznamka.Text = "";
            textBoxCisloDokladu.Text = "";
            dateTimePickerDatum.Value = DateTime.Now;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            VyberZaznam();
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            vybranyZaznam.Datum = dateTimePickerDatum.Value;
            vybranyZaznam.Popis = textBoxPopis.Text;
            vybranyZaznam.Castka = Convert.ToDouble(numericUpDownCastka.Value);
            vybranyZaznam.Poznamka = textBoxPoznamka.Text;
            repositar.UpravZaznam(vybranyZaznam);
            NactiAktMesic();
            ResetujFormular();         
        }

        private void ResetujFormular()
        {
            textBoxPopis.Text = "";
            numericUpDownCastka.Value = 0;
            textBoxPoznamka.Text = "";
            textBoxCisloDokladu.Text = "";
            dateTimePickerDatum.Value = DateTime.Now;
        }

        private void VyberZaznam()
        {
            if(listView1.SelectedIndices.Count>0)
            {
                int vybranyIndex = listView1.SelectedIndices[0];
                vybranyZaznam = pokladna[vybranyIndex];
                dateTimePickerDatum.Value = vybranyZaznam.Datum;
                textBoxCisloDokladu.Text = vybranyZaznam.Cislo.ToString();
                textBoxPopis.Text = vybranyZaznam.Popis.ToString();
                numericUpDownCastka.Value = Convert.ToDecimal(vybranyZaznam.Castka);
                textBoxPoznamka.Text = vybranyZaznam.Poznamka;
            }
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    VyberZaznam();
                    break; 

                case Keys.Delete:
                    if(listView1.SelectedIndices.Count > 0)
                    {
                        int vybranyIndex = listView1.SelectedIndices[0];
                        vybranyZaznam = pokladna[vybranyIndex];
                        if(MessageBox.Show("Opravdu chcete smazat vybranou položku?", "Mazání položky", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            repositar.SmazZaznam(vybranyZaznam);
                            NactiAktMesic();
                            ResetujFormular();
                        }   
                    }
                    break;
            }
        }

        private void comboBoxTridit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetriditPokladnu();
        }

        private void checkBoxSestupne_CheckedChanged(object sender, EventArgs e)
        {
            SetriditPokladnu();
        }

        private void SetriditPokladnu()
        {
            string[] sloupce = new string[] { "Datum", "Popis", "Castka", "Castka" };
            string sloupec = sloupce[comboBoxTridit.SelectedIndex];
            string smer = checkBoxSestupne.Checked ? "desc" : "asc";
            if (checkBoxSestupne.Checked)
            {
                pokladna.Sort((a, b) => b.Datum.CompareTo(a.Datum));
            }
            else
            {
                pokladna.Sort((a, b) => a.Datum.CompareTo(b.Datum));
            }
            listView1.Items.Clear();
            foreach (var p in pokladna)
            {
                listView1.Items.Add(p.DoLvItem());
            }
        }
    }
}
