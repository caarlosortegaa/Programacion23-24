using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Capa_Negocio;
using Capa_Entidad;
using System;
using System.Collections.Generic;

namespace Proyecto3Ev.Views
{
   
    public partial class CrudUsuarios : Page
    {
        readonly CN_Usuarios CN_Usuarios = new CN_Usuarios();
        readonly CE_Usuarios CE_Usuarios = new CE_Usuarios();
        readonly CN_Privilegio CN_Privilegio = new CN_Privilegio();
        byte[] data;
        private bool _imagenSubida = false;
        public int idUsuario;
        public string Patron = "VentasExpress";
        public CrudUsuarios()
        {
            InitializeComponent();
            CargarCB();
        }
        public bool CamposLlenos()
        {
            if (tbNombres.Text == "" || tbApellidos.Text == "" || tbDNI.Text == "" || tbCorreo.Text == "" || tbTeléfono.Text == "" ||
               tbNacimineto.Text == "" || cbPrivilegio.Text == "" || tbUsuario.Text == "")
                return false;
            else
                return true;
        }
        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new Usuarios();
        }
        void CargarCB()
        {
            List<string> privilegios = CN_Privilegio.ListarPrivilegios();
            for(int i = 0; i < privilegios.Count; i++)
            {
                cbPrivilegio.Items.Add(privilegios[i]);
            }
            
        }

        private void Crear(object sender, RoutedEventArgs e)
        {

            if (CamposLlenos() == true && tbContrasenia.Text != "")
            {
                int privilegio = CN_Privilegio.IdPrivilegio(cbPrivilegio.Text);
                CE_Usuarios.Nombre = tbNombres.Text;
                CE_Usuarios.Apellidos = tbApellidos.Text;
                CE_Usuarios.DNI = tbNombres.Text;
                CE_Usuarios.Correo = tbCorreo.Text;
                CE_Usuarios.Telefono = int.Parse(tbTeléfono.Text);
                CE_Usuarios.Fecha_nac = DateTime.Parse(tbNacimineto.Text);
                CE_Usuarios.Privilegio = privilegio;
                CE_Usuarios.Img = data;
                CE_Usuarios.Usuario = tbUsuario.Text;
                CE_Usuarios.Contrasenia = tbContrasenia.Text;
                CE_Usuarios.Patron = Patron;

                CN_Usuarios.Insertar(CE_Usuarios);

                Content = new Usuarios();
            }
            else
                MessageBox.Show("Los campos no se pueden quedar vacios");
        }
        public void Consultar()
        {
            var a = CN_Usuarios.Consulta(idUsuario);
            tbNombres.Text = a.Nombre.ToString();
            tbApellidos.Text = a.Apellidos.ToString();
            tbDNI.Text = a.DNI.ToString();
            tbCorreo.Text = a.Correo.ToString();
            tbTeléfono.Text = a.Telefono.ToString();
            tbNacimineto.Text = a.Fecha_nac.ToString();

            var b = CN_Privilegio.NombrePrivilegio(a.Privilegio);
            cbPrivilegio.Text = b.NombrePrivilegio;

            ImageSourceConverter ims = new ImageSourceConverter();
            imagen.Source = (ImageSource)ims.ConvertFrom(a.Img);
            tbUsuario.Text = a.Usuario.ToString();

        }
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            CE_Usuarios.IdUsuario = idUsuario;
            CN_Usuarios.Eliminar(CE_Usuarios);
            Content = new Usuarios();
        }

        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (CamposLlenos() == true)
            {
                int privilegio = CN_Privilegio.IdPrivilegio(cbPrivilegio.Text);

                CE_Usuarios.Nombre = tbNombres.Text;
                CE_Usuarios.Apellidos = tbApellidos.Text;
                CE_Usuarios.DNI = tbNombres.Text;
                CE_Usuarios.Correo = tbCorreo.Text;
                CE_Usuarios.Telefono = int.Parse(tbTeléfono.Text);
                CE_Usuarios.Fecha_nac = DateTime.Parse(tbNacimineto.Text);
                CE_Usuarios.Privilegio = privilegio;
                CE_Usuarios.Usuario = tbUsuario.Text;
                
                CN_Usuarios.ActualizarDatos(CE_Usuarios);

                Content = new Usuarios();
            }
            else
                MessageBox.Show("Los campos no se pueden quedar vacios");

            if(tbContrasenia.Text != "")
            {
                CE_Usuarios.IdUsuario = idUsuario;
                CE_Usuarios.Contrasenia = tbContrasenia.Text;
                CE_Usuarios.Patron = Patron;

                CN_Usuarios.ActualizarContrasenia(CE_Usuarios);

                Content = new Usuarios();
            }
            if(_imagenSubida == true)
            {
                CE_Usuarios.IdUsuario = idUsuario;
                CE_Usuarios.Img = data;
                CN_Usuarios.ActualizarImagen(CE_Usuarios);

                Content = new Usuarios();
            }

        }

        private void Subir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.SetValue(Image.SourceProperty, imgs.ConvertFromString(ofd.FileName.ToString()));
            }
            _imagenSubida = true;
        }
    }
}
