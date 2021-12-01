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
using iniciar_secion_prioridad;
using iniciar_secion_datos;
using iniciar_secion.conexion;
using System.Data.SqlClient;


namespace iniciar_secion
{
    /// <summary>
    /// Lógica de interacción para listar_requisitos.xaml
    /// </summary>
    public partial class listar_requisitos : Window
    {
        public listar_requisitos()
        {
            InitializeComponent();
            ConexionBD co = new ConexionBD();
            co.abrir();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            List<requerimientos> list_s = new List<requerimientos>();
            string tipos = comboX_requerimiento.Text;
            string prioridad = comBO_prioridad.Text;
            ConexionBD conexion = new ConexionBD();
            datos dat = new datos();
            dat.che_pendiente_Checked();
            dat.che_resulato_Checked();
            string esto = dat.che_resulato_Checked();
            MessageBox.Show(esto);
            string estados = dat.che_pendiente_Checked();
            conexion.abrir();
            string cadena = $" select * FROM Requisitos where tipo='{tipos}' and prioridad='{prioridad} and estado='{esto}';";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                string asignado = lector.GetString(0);
                string descripcion = lector.GetString(1);
                string tipo = lector.GetString(2);
                string prioridades = lector.GetString(3);
                requerimientos res = new requerimientos(prioridades, tipo,asignado,descripcion);
                list_s.Add(res);
                data_final.ItemsSource = list_s;
            }
        }

        private void fin(object sender, RoutedEventArgs e)
        {

        }

        private void comboX_requerimiento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comBO_prioridad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
