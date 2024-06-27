using Capa_Negocio;
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
            Buscar("");
        }
        readonly CN_Productos obj_CN_Productos = new CN_Productos();
        public void Buscar(string buscar)
        {
            GridDatos.ItemsSource = obj_CN_Productos.BuscarProducto(buscar).DefaultView;
        }
        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        private void BtnCrearProducto_Click(object sender, RoutedEventArgs e)
        {
            CRUDProductos ventana = new CRUDProductos();
            FrameProducto.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.btnCrear.Visibility = Visibility.Hidden;
        }
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDProductos ventana = new CRUDProductos();
            FrameProducto.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.IdProducto = id;
            ventana.Consultar();
            ventana.Titulo.Text = "Consulta de Producto";
            ventana.tbNombreProducto.IsEnabled = false;
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbCanitdad.IsEnabled = false;
            ventana.tbActivo.IsEnabled = false;
            ventana.tbPrecio.IsEnabled = false;
            ventana.cbGrupo.IsEnabled = false;
            ventana.tbMedida.IsEnabled = false;
            ventana.tbDescripcion.IsEnabled = false;
            ventana.btnSubir.IsEnabled = false;
        }

        private void Modificar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDProductos ventana = new CRUDProductos();
            FrameProducto.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.IdProducto = id;
            ventana.Consultar();
            ventana.Titulo.Text = "Modificar Producto";
            ventana.tbNombreProducto.IsEnabled = true;
            ventana.tbCodigo.IsEnabled = true;
            ventana.tbCanitdad.IsEnabled = true;
            ventana.tbActivo.IsEnabled = true;
            ventana.tbPrecio.IsEnabled = true;
            ventana.cbGrupo.IsEnabled = true;
            ventana.tbMedida.IsEnabled = true;
            ventana.tbDescripcion.IsEnabled = true;
            ventana.btnSubir.IsEnabled = true;
            ventana.btnModificar.Visibility = Visibility.Hidden;
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDProductos ventana = new CRUDProductos();
            FrameProducto.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.IdProducto = id;
            ventana.Consultar();
            ventana.Titulo.Text = "Eliminar de Producto";
            ventana.tbNombreProducto.IsEnabled = false;
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbCanitdad.IsEnabled = false;
            ventana.tbActivo.IsEnabled = false;
            ventana.tbPrecio.IsEnabled = false;
            ventana.cbGrupo.IsEnabled = false;
            ventana.tbMedida.IsEnabled = false;
            ventana.tbDescripcion.IsEnabled = false;
            ventana.btnSubir.IsEnabled = false;
            ventana.btnLIMINAR.Visibility = Visibility.Hidden;
        }
    }
}
