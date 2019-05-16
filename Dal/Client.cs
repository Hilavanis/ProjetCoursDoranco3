using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Client
    {
        public int IDclient { get; private set; }        
        public string Nom { get; private set; }
        public string Adresse { get; private set; }
        public string Email { get; private set; }
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;

        public Client()
        {
            connStr = "Data Source=PC-N-3-313;Initial Catalog=DBAdonet;Integrated Security=True";
            conn = new SqlConnection(connStr);
        }               

        public DataTable Reader()
        {
            
            conn.Open();
            cmd = new SqlCommand("Select* From TableClient", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            return dt;
        }

        public DataTable Insert(string nom, string adresse, string email)
        {
            Nom = nom;
            Adresse = adresse;
            Email = email;

            conn.Open();
            cmd = new SqlCommand("Insert Into TableClient (Nom, Adresse, Email) Values (@Nom, @Adresse, @Email)", conn);

            try
            {
                cmd.Parameters.AddWithValue("@Nom", Nom);
                cmd.Parameters.AddWithValue("@Adresse", Adresse);
                cmd.Parameters.AddWithValue("@Email", Email);
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

        public int Delete(int idclient)
        {
            return -1;
        }
    }
}
