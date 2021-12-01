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

namespace iniciar_secion
{
    /// <summary>
    /// Lógica de interacción para menu_requisitos.xaml
    /// </summary>
    public partial class menu_requisitos : Window
    {
        public menu_requisitos()
        {
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ingresar_requisitos nv = new ingresar_requisitos();
            nv.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MainWindow nv = new MainWindow();
            nv.Show();

        }
    }
}
