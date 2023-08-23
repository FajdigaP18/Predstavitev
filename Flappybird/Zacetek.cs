using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Flappybird
{
    public partial class Zacetek : Form
    {
        private List<Igralec> igralci;
        private string pot = @"rezultati1.json";
        public Zacetek()
        {
            InitializeComponent();
            igralci = LoadJson(pot);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flappy zacetekIgre = new Flappy(igralec.Text, igralci);
            zacetekIgre.Show();
            //Close();
        }
        /// <summary>
        /// Naložimo podatke iz prjšnjih iger
        /// </summary>
        /// <returns></returns>
        public List<Igralec> LoadJson(string pot)
        {
            if (File.Exists(pot))
            {
                using (StreamReader r = new StreamReader(pot))
                {

                    string json = r.ReadToEnd();
                    List<Igralec> podatki = JsonSerializer.Deserialize<List<Igralec>>(json);

                    podatki.Sort();

                    return podatki;
                }
            }
            else
            {
                return new List<Igralec>();
            }
        }


    }
}
