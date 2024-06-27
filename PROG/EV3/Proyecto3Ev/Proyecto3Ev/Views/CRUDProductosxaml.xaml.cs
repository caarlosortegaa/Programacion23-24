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
using Capa_Entidad;
using System.IO;
using Microsoft.Win32;

namespace Proyecto3Ev.Views
{
    /// <summary>
    /// Lógica de interacción para CRUDProductosxaml.xaml
    /// </summary>
    public partial class CRUDProductos : Page
    {
        public int IdProducto;
        public string Patron = "VentasExpress";
        public byte[] data;
        private bool imagensubida = false;

        CN_Grupos obj_CN_Grupos = new CN_Grupos();
        CN_Productos obj_CN_Productos= new CN_Productos();
        CE_Productos CE_Productos = new CE_Productos();
        public CRUDProductos()
        {
            InitializeComponent();
            cargar();
        }

        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new Producto();
        }
        void cargar()
        {
            List<string> grupo = new List<string>();
            for(int i = 0 ; i < grupo.Count; i++)
            {
                cbGrupo.Items.Add(grupo[i]);
            }
        }
        public bool CamposLlenos()
        {
            if (tbNombreProducto.Text == "" || cbGrupo.Text == "" || tbCodigo.Text == "" || tbPrecio.Text == "" ||
               tbCanitdad.Text == "" || tbMedida.Text == "" || tbDescripcion.Text == "")
                return false;
            else
                return true;
        }
        private void Crear(object sender, RoutedEventArgs e)
        {
            if(CamposLlenos() == true)
            {
                int idgrupo = obj_CN_Grupos.IdGrupo(cbGrupo.Text);

                CE_Productos.Nombre = tbNombreProducto.Text;
                CE_Productos.Codigo = tbCodigo.Text;
                CE_Productos.Precio = double.Parse(tbPrecio.Text);
                CE_Productos.Cantidad = double.Parse(tbCanitdad.Text);
                CE_Productos.Activo = (bool)tbActivo.IsChecked;
                CE_Productos.UnidadMedida = tbMedida.Text;
                CE_Productos.Img = data;
                CE_Productos.Descripcion = tbDescripcion.Text;
                CE_Productos.Grupo = idgrupo;

                obj_CN_Productos.Insertar(CE_Productos);
                Content = new Producto();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
        }

        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (CamposLlenos() == true)
            {
                int idgrupo = obj_CN_Grupos.IdGrupo(cbGrupo.Text);

                CE_Productos.IdArticulo = IdProducto;
                CE_Productos.Nombre = tbNombreProducto.Text;
                CE_Productos.Codigo = tbCodigo.Text;
                CE_Productos.Precio = double.Parse(tbPrecio.Text);
                CE_Productos.Cantidad = double.Parse(tbCanitdad.Text);
                CE_Productos.Activo = (bool)tbActivo.IsChecked;
                CE_Productos.UnidadMedida = tbMedida.Text;
                CE_Productos.Descripcion = tbDescripcion.Text;
                CE_Productos.Grupo = idgrupo;

                obj_CN_Productos.ActualizarDatos(CE_Productos);
                Content = new Producto();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            if(imagensubida == true)
            {
                CE_Productos.IdArticulo = IdProducto;
                CE_Productos.Img = data;

                obj_CN_Productos.ActualizarIMG();

                Content = new Producto();
            }
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            CE_Productos.IdArticulo = IdProducto;
            obj_CN_Productos.Eliminar(CE_Productos);
            Content = new Producto();
        }
        
        private void Subir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.SetValue(Image.SourceProperty, imgs.ConvertFromString(ofd.FileName.ToString()));
            }
            imagensubida = true;
        }

        public void Consultar()
        {
            var a = obj_CN_Productos.Consultar(IdProducto);
            tbNombreProducto.Text = a.Nombre.ToString();
            tbCodigo.Text = a.Codigo.ToString();
            tbPrecio.Text = a.Precio.ToString();
            tbActivo.IsChecked = a.Activo;
            tbCanitdad.Text = a.Cantidad.ToString();
            tbMedida.Text = a.UnidadMedida.ToString();
            ImageSourceConverter imgs = new ImageSourceConverter();
            imagen.Source = (ImageSource)imgs.ConvertFrom(a.Img);
            tbDescripcion.Text = a.Descripcion.ToString();

            var b = obj_CN_Grupos.Nombre(a.Grupo);
            cbGrupo.Text = "";
        }
    }
}
