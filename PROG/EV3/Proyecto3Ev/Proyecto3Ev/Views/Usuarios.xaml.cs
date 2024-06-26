using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Capa_Negocio;

namespace Proyecto3Ev.Views
{
    public partial class Usuarios : UserControl
    {
        readonly CN_Usuarios cN_Usuarios = new CN_Usuarios();
        public Usuarios()
        {
            InitializeComponent();
            Buscar("");
            
        }
      
        void CargarDatos()
        {
            GridDatos.ItemsSource = cN_Usuarios.CargarUsuarios().DefaultView;
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            CrudUsuarios ventana = new CrudUsuarios();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.btnCrear.Visibility = Visibility.Visible;
        }

        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsuarios ventana = new CrudUsuarios();
            ventana.idUsuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.Titulo.Text = "Consulta de Usuario";
            ventana.tbNombres.IsEnabled = false;
            ventana.tbApellidos.IsEnabled = false;
            ventana.tbDNI.IsEnabled = false;
            ventana.tbCorreo.IsEnabled = false;
            ventana.tbTeléfono.IsEnabled = false;
            ventana.tbNacimineto.IsEnabled = false;
            ventana.cbPrivilegio.IsEnabled = false;
            ventana.tbUsuario.IsEnabled = false;
            ventana.tbContrasenia.IsEnabled = false;
            ventana.btnSubir.IsEnabled = false;
        }
        private void Modificar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsuarios ventana = new CrudUsuarios();
            ventana.idUsuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.Titulo.Text = "Modificar Usuario";
            ventana.tbNombres.IsEnabled = true;
            ventana.tbApellidos.IsEnabled = true;
            ventana.tbDNI.IsEnabled = true;
            ventana.tbCorreo.IsEnabled = true;
            ventana.tbTeléfono.IsEnabled = true;
            ventana.tbNacimineto.IsEnabled = true;
            ventana.cbPrivilegio.IsEnabled = true;
            ventana.tbUsuario.IsEnabled = true;
            ventana.tbContrasenia.IsEnabled = true;
            ventana.btnSubir.IsEnabled = true;
            ventana.btnModificar.Visibility = Visibility.Visible;
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsuarios ventana = new CrudUsuarios();
            ventana.idUsuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.Titulo.Text = "Eliminar Usuario";
            ventana.tbNombres.IsEnabled = false;
            ventana.tbApellidos.IsEnabled = false;
            ventana.tbDNI.IsEnabled = false;
            ventana.tbCorreo.IsEnabled = false;
            ventana.tbTeléfono.IsEnabled = false;
            ventana.tbNacimineto.IsEnabled = false;
            ventana.cbPrivilegio.IsEnabled = false;
            ventana.tbUsuario.IsEnabled = false;
            ventana.tbContrasenia.IsEnabled = false;
            ventana.btnSubir.IsEnabled = false;
            ventana.btnLIMINAR.Visibility = Visibility.Visible;
        }
        private void Buscar(string buscar)
        {
            GridDatos.ItemsSource = cN_Usuarios.Buscar(buscar).DefaultView;
        }
        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
    }
}
