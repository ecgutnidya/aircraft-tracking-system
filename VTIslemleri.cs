using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Windows.Forms;

namespace stajproje1
{
    public class VTIslemleri
    {
        SQLiteConnection sqlite_conn;
        public VTIslemleri()
        {
            sqlite_conn = new SQLiteConnection("Data Source=stajprojesi.db; Version = 3; New = True; Compress = True; ");
        }
        public int CheckUser(string username, string password)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT userType FROM users WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";
            sqlite_cmd.Parameters.AddWithValue("kullaniciAdi", username);
            sqlite_cmd.Parameters.AddWithValue("sifre", password);
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            if (sqlite_datareader.Read())
            {
                int userType = sqlite_datareader.GetInt16(0);
                sqlite_datareader.Close();
                sqlite_conn.Close();
                return userType;
            }
            else
            {
                sqlite_datareader.Close();
                sqlite_conn.Close();
                return -1;
            }
        }
        public DataGridView GetAllUcuslar(DataGridView ucuslar)
        {
            sqlite_conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From ucuslar", sqlite_conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    ucuslar.Rows.Add(new object[] {
            read.GetValue(0),
            read.GetValue(1),
            read.GetValue(2),
            read.GetValue(3),
            read.GetValue(4),
            read.GetValue(5),
            read.GetValue(6),
            read.GetValue(7),
            read.GetValue(8),
            });
                }
            }
            sqlite_conn.Close();
            return ucuslar;
        }
        public void AddUcuslar(string[] bilgiler)
        {
            sqlite_conn.Open();
            string query = "INSERT INTO ucuslar (Tarih,[Planlanan Saat / Tahmini Saat]," +
                "[Hava Yolu],[Ucus No],Varis,[Check-in Kontuar]," +
                "Kapi,Durumu," +
                "Tip) VALUES (@value0, @value1,@value2, @value3,@value4, @value5," +
                "@value6, @value7,@value8)";
            SQLiteCommand command = new SQLiteCommand(query, sqlite_conn);
            for (int i = 0; i < bilgiler.Length; i++)
            {
                command.Parameters.AddWithValue($"value{i}", bilgiler[i]);
            }
            command.ExecuteReader();
            sqlite_conn.Close();
        }
    }
}