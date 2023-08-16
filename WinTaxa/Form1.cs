using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTaxa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BeregnPris_Click(object sender, EventArgs e)
        {
            double startPris;
            double distancePrisEkstra;
            double prisPerMinut = 5.75;
            double passagerPrisEkstra = 5.75; // Dette tilføjer tillæg til ekstra passager

            if (StorVogn.Checked)
            {
                startPris = NatTid.Checked ? 80.0 : 70.0;
                distancePrisEkstra = NatTid.Checked ? 19.0 : 17.0;
            }
            else
            {
                startPris = NatTid.Checked ? 50.0 : 40.0;
                distancePrisEkstra = NatTid.Checked ? 15 : 12;
            }

            int AntalPassagere = (int)AntalPassagereNumeric.Value;
            startPris += (AntalPassagere - 1) * passagerPrisEkstra;

            var tidvarighed = double.TryParse(VarighedBox.Text, out double varighed);
            var kmafstand = double.TryParse(AfstandBox.Text, out double afstand);
            string destination = DestinationBox.Text;

            if (kmafstand && tidvarighed && !string.IsNullOrEmpty(destination))
            {
                double totalAfstandPris = afstand * distancePrisEkstra;
                double totalVarighedPris = varighed * prisPerMinut;
                double destinationPrisEkstraPerson = 15.0;
                double totalDestinationPris = destination.Length * destinationPrisEkstraPerson;

                double totalPassagerPrisEkstra = (AntalPassagere - 1) * passagerPrisEkstra;

                double totalPris = startPris + totalAfstandPris + totalDestinationPris + totalVarighedPris + totalPassagerPrisEkstra;

                ForventetPris.Text = "Forventet Pris: " + totalPris.ToString("0.00 kr");
            }
            else
            {
                MessageBox.Show("Indtast venligst gyldigt input i boksene", "Ugyldigt input", MessageBoxButtons.OK);
            }
        }
    }
}