using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using iniciar_secion.conexion;
using iniciar_secion.user;

namespace iniciar_secion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Usuario> lista_de_usuarios = new List<Usuario>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();


            string users = Usuarios_ingresar.Text;
            string PS = contraseña_ingresar.Text;
            Usuario usuario_buscar = new Usuario(users, PS);
            string cadena = $" SELEct * FROM usuario where usuario='{users}' and pass='{PS}'";



            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {

                    int id = lector.GetInt32(0);
                    string nombre = lector.GetString(1);
                    string passs = lector.GetString(2);

                    Console.WriteLine("id: " + lector.GetValue(0).ToString() + " nombre: " + lector.GetValue(1).ToString() + " contraseña: " + lector.GetValue(2).ToString());
                    Console.WriteLine("el usuario existe");

         
                        MessageBox.Show("usted ha iniciado seccion ");
                        menu_requisitos nv = new menu_requisitos();
                        nv.Show();


                  
                }
                else
                {
                    MessageBox.Show("usted no existe en la base de datos");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("error la consulta no se pudo ejecutar");
                Console.WriteLine("conexion fallida por error: ", ex.Message);
                MessageBox.Show("usted no existe en la base de datos");
                throw;
            }

        }
    }
}
