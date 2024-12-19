using System;
using System.Data.SqlClient;

namespace PetrolOtomasyonSistemi
{
    public static class DatabaseHelper
    {
        // Bağlantı dizesi
        private static string connectionString = "Data Source=DESKTOP-JIOMUP1;Initial Catalog=PetrolOtomasyonDB;Integrated Security=True;Encrypt=False;";

        // Bağlantı nesnesi döndüren metod
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
