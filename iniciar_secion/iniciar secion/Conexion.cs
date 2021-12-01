using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iniciar_secion.conexion;
using iniciar_secion.user;
using iniciar_secion;
using System.Windows.Forms;
using iniciar_secion_prioridad;
using System.Data;


namespace iniciar_secion.conexion
{
    class ConexionBD
    {



        string cadena = "Data Source=DESKTOP-AFQLBQR;Initial Catalog=proyecto_final; User=sa; Password=jmgl23; ";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("conexio exitosa");

            }
            catch (Exception eX)
            {
                Console.WriteLine("conexion fallida por error: ", eX.Message);
                throw;
            }

        }
        public void cerrar()
        {
            conectarbd.Close();

        }

    }
}