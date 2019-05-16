using Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Produits : Form
    {
        public Produits()
        {
            InitializeComponent();
        }

        CreationTable ct = new CreationTable();

        private void ButtonReaderP_Click(object sender, EventArgs e)
        {
            AffichageData.DataSource = ct.creationproduit();
        }

        private void ButtonInsertP_Click(object sender, EventArgs e)
        {
            double prix;
            int quantite;

            if(Double.TryParse(TextePrixP.Text, out prix) != true || int.TryParse(TexteQuantiteP.Text, out quantite) != true)
            {
                MessageBox.Show("Les champs Prix et / ou Quantite sont mal renseigner");
            }
            else
                ct.Insertproduit(TexteLibelleP.Text, Double.Parse(TextePrixP.Text), int.Parse(TexteQuantiteP.Text));
        }
    }
}

