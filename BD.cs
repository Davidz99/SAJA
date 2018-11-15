using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAJA
{   
    public class BD
    { 
        static MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=saja; Uid=root; pwd=;");

        public MySqlConnection AbrirConexion()
        {
                if (conectar.State == ConnectionState.Closed)
                {
                    conectar.Open();
                }
            return conectar;

        }

        public MySqlConnection CerrarConexion()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
            return conectar;
        }

    }
}
