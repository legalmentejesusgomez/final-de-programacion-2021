using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iniciar_secion_prioridad;
using iniciar_secion.user;
using System.Data.SqlClient;
using iniciar_secion.conexion;
using System.Windows;

namespace iniciar_secion_datos
{

    
    class datos
    {
        public List<string> GetUsuarios1()
        {
            List<string> lista_usuarios = new List<string>();
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();
            string cadena = " select * from Requisitos ;";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                string prioridad = lector.GetString(0);
                string tipo = lector.GetString(1);
                string asignado = lector.GetString(2);
                string descripcion = lector.GetString(3);
                lista_usuarios.Add(descripcion);
            }
            return lista_usuarios;
        }

        public List<string> GetUsuarios()
        {
            List<string> lista_usuarios = new List<string>();
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();
            string cadena = " select * FROM usuario ;";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int id = lector.GetInt32(0);
                string nombre = lector.GetString(1);
                string passs = lector.GetString(2);
                lista_usuarios.Add(nombre);   
            }
            return lista_usuarios;
        }
        public static int insertar_re(requerimientos x) 
        {
            int retorno = 0;
            ConexionBD co = new ConexionBD();
            co.abrir();
            string cadena = $"insert into Requisitos values(@asignado,@descripcion,@tipo,@prioridad)";
            SqlCommand comandos = new SqlCommand(cadena, co.conectarbd);
            comandos.Parameters.AddWithValue( "@asignado", x.Asignacion);
            comandos.Parameters.AddWithValue( "@descripcion", x.Descripcion);
            comandos.Parameters.AddWithValue("@tipo", x.Tipo);
            comandos.Parameters.AddWithValue("@prioridad", x.Tipo);
            retorno = comandos.ExecuteNonQuery();
            co.cerrar();

            return retorno;
        }
        public string che_resulato_Checked()
        {
            MessageBox.Show("usaste el checkbox de resultado");
            string resulto = "resulto";
            return resulto;
        }
        public string che_pendiente_Checked()
        {
            MessageBox.Show("usaste el checkbox de pendiente");
            string pendiente = "pendiente";
            return pendiente;
        }






    }
}
