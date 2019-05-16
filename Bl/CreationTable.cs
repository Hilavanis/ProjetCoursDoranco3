using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class CreationTable
    {
        public Client client;
        public Produit produit;
        public DataTable dt;
        public DataTable creationclient()
        {
            client = new Client();
            dt = client.Reader();
            return dt;
        }

        public DataTable creationproduit()
        {
            produit = new Produit();
            dt = produit.Reader();
            return dt;
        }

        public DataTable Insertclient(string nom, string adresse, string email)
        {
            client = new Client();
            dt = client.Insert(nom, adresse, email);
            return dt;
        }

        public DataTable Insertproduit(string libelle, Double prix, int quantite)
        {
            client = new Client();
            dt = produit.Insert(libelle, prix, quantite);
            return dt;
        }
    }
}
