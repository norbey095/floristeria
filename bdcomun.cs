using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace trabajo_final
{
    internal class bdcomun
    {
        public static MySqlConnection obtenerconexion()
        {
            MySqlConnection conectar = null;
            try
            {
                conectar = new MySqlConnection("server=localhost;database=floristeria;user=root;password=;");
                conectar.Open();
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return conectar;
        }
    }
}
