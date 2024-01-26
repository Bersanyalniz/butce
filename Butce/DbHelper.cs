using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butce

{
    class DbHelper
    {
        private static string _connectionString;
        private static string _connectionStringKategori;
        public static void ReadSettings()
        {
            string yol = Path.Combine(Application.StartupPath, "connection.txt");
            string yolKategori = Path.Combine(Application.StartupPath, "connectionKategori.txt");
            _connectionString  = File.ReadAllText(yol);
            _connectionStringKategori = File.ReadAllText(yolKategori);

        }
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = _connectionString;
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu.\n{ex.Message}");
                return null;
                
            }
        }
        public static SqlConnection GetConnectionKategori()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = _connectionStringKategori;
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu.\n{ex.Message}");
                return null;
            }
        }

        internal static void AddHaracama(Harcama harcama)
        {
            var conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Harcama (Tarih, Kategori, Tutar, Aciklama) values(@Tarih, @Kategori, @Tutar, @Aciklama)";
            cmd.Parameters.AddWithValue("@Tarih", harcama.Tarih);
            cmd.Parameters.AddWithValue("@Kategori", harcama.Kategori);
            cmd.Parameters.AddWithValue("@Tutar", harcama.Tutar);
            cmd.Parameters.AddWithValue("@Aciklama", harcama.Aciklama);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static List<string> GetKategoriList()
        {
            var list = new List<string>();
            var conn = GetConnectionKategori();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select  Ad from Kategori order by Ad";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(dr["Ad"].ToString());
            }
            dr.Close();
            conn.Close();

            return list;
        }

        public static List<Harcama> GetHarcamaList()
        {
            var list = new List<Harcama>();
            var conn = GetConnection();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select HarcamaId,Tarih,Kategori,Tutar,Aciklama from Harcama order by Tarih desc";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var harcama = new Harcama()
                {
                    HarcamaId = Convert.ToInt32(dr["HarcamaId"]),
                    Tarih = Convert.ToDateTime(dr["Tarih"]),
                    Kategori = dr["Kategori"].ToString(),
                    Tutar = Convert.ToDecimal(dr["Tutar"]),
                    Aciklama = dr["Aciklama"].ToString(),
                };
                list.Add(harcama);
            }
            dr.Close();
            conn.Close();

            return list;

        }

    }
}
