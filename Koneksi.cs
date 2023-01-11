using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    static class Koneksi
    {
        private static string str_koneksi = "datasource=localhost;username=root;password=;database=perpustakaan;";
        

        private static MySqlConnection getConnection() { 
            return new MySqlConnection(str_koneksi);
        }

        public static MySqlDataReader Query(string query)
        {
            MySqlConnection koneksi = getConnection();
            koneksi.Close();
            koneksi.Open();
            MySqlCommand command = new MySqlCommand(query, koneksi);
            MySqlDataReader data = command.ExecuteReader();
            //koneksi.Close();
            return data;
        }

        public static DataTable display(string query)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlConnection koneksi = getConnection();
                koneksi.Open();
                MySqlCommand command = new MySqlCommand(query, koneksi);
                MySqlDataReader response = command.ExecuteReader();
                table.Load(response);
                koneksi.Close();
                return table;     
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }
    }
}
