using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using iniciar_secion.conexion;
using System.Data.SqlClient;
using System.Data;
using iniciar_secion.user;
using iniciar_secion_prioridad;
using iniciar_secion_datos;
using MessageBox = System.Windows.Forms.MessageBox;

namespace iniciar_secion
{
    /// <summary>
    /// Lógica de interacción para ingresar_requisitos.xaml
    /// </summary>
    public partial class ingresar_requisitos : Window
    {
        List<Usuario> lista_de_usuarios = new List<Usuario>();
        public ingresar_requisitos()
        {
            InitializeComponent();
            datos data = new datos();


            data.GetUsuarios();


            asignado.ItemsSource = data.GetUsuarios();

            
        }


        private void Button_Click(object sender, EventArgs e)
        {
            datos du = new datos();


            
           ConexionBD con = new ConexionBD();
            con.abrir();
            string usuario = asignado.Text;
            string tipo = combobox_tipo_requisitos.Text;
            string descripcion = text_box_desc.Text;
            string prioridad = combobox_prioriodad.Text;
            string ingreso = $"insert into Requisitos values('{usuario}','{descripcion}','{tipo}','{prioridad}')";
            SqlCommand conn = new SqlCommand(ingreso,con.conectarbd);
            conn.ExecuteNonQuery();
            MessageBox.Show("se ha logrado ingresar el requerimiento");

        }
     
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void nada(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            listar_requisitos nv = new listar_requisitos();
                nv.Show();

           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
    }

