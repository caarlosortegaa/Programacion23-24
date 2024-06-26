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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto3Ev.Views
{
    /// <summary>
    /// Lógica de interacción para CRUDProductosxaml.xaml
    /// </summary>
    public partial class CRUDProductos : Page
    {
        public CRUDProductos()
        {
            InitializeComponent();
        }

        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new Producto();
        }

        private void Crear(object sender, RoutedEventArgs e)
        {

        }

        private void Modificar(object sender, RoutedEventArgs e)
        {

        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {

        }

        private void Subir(object sender, RoutedEventArgs e)
        {

        }
    }
}
