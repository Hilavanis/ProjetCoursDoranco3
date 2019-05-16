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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        Produits fenetre = new Produits();

        CreationTable ct = new CreationTable();

        private void ButtonReader_Click(object sender, EventArgs e)
        {            
            AffichageData.DataSource = ct.creationclient();
        }

        private void ButtonProduit_Click(object sender, EventArgs e)
        {
             fenetre.Show();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            ct.Insertclient(TexteName.Text, TexteAdress.Text, TexteEmail.Text);
        }        
    }
}
