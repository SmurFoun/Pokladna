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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonRepos jsonRepos = new JsonRepos("data.json");
            jsonRepos.VytvorTestData();
            repositar = jsonRepos;

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

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
