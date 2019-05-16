using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Produit
    {
        public int IDProd { get; private set; }
        public string LibelleProd { get; private set; }
        public double Prix { get; private set; }
        public int Quantite { get; private set; }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;

        public Produit()
        {
            connStr = "Data Source=PC-N-3-313;Initial Catalog=DBAdonet;Integrated Security=True";
            conn = new SqlConnection(connStr);
        }

        public DataTable Reader()
        {
            conn.Open();
            cmd = new SqlCommand("Select* From TableProduit", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public DataTable Insert(string libelle, double prix, int quantite)
        {
            LibelleProd = libelle;
            Prix = prix;
            Quantite = quantite;

            conn.Open();
            cmd = new SqlCommand("Insert Into TableProduit (Libelle, Prix, Quantite) Values (@Libelle, @Prix, @Quantite)", conn);

            try
            {
                cmd.Parameters.AddWithValue("@Libelle", LibelleProd);
                cmd.Parameters.AddWithValue("@Prix", Prix);
                cmd.Parameters.AddWithValue("@Quantite", Quantite);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dt = new DataTable();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            return dt;
        }

        public void Update()
        {

        }

        public int Delete(int idprod)
        {
            return -1;
        }
    }
}
