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
    /// Lógica de interacción para Producto.xaml
    /// </summary>
    public partial class Producto : UserControl
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void BtnCrearProducto_Click(object sender, RoutedEventArgs e)
        {
            CRUDProductos ventana = new CRUDProductos();
            FrameProducto.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.btnCrear.Visibility = Visibility.Hidden;
        }

        private void Buscando(object sender, TextChangedEventArgs e)
        {

        }

        private void Consultar(object sender, RoutedEventArgs e)
        {

        }

        private void Modificar(object sender, RoutedEventArgs e)
        {

        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {

        }
    }
}
