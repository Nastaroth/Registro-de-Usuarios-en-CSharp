using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Practica_Telefonos.Properties;
using System.Configuration;

namespace Practica_Telefonos
{
    class BasedeDatos
    {
        public static string ObtenerString()
        {
            return Settings.Default.practica_TConnectionString;
        }
        public static SqlConnection Conexion()
        {
            //SqlConnection Conex = new SqlConnection ("Data Source=nastaroth;Initial Catalog=practica_T;Integrated Security=True");
            SqlConnection Conex = new SqlConnection(ObtenerString());
            Conex.Open();

            return Conex;
        }
    }
}
