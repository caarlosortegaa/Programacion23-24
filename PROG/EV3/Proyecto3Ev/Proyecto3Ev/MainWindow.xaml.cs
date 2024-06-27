using Proyecto3Ev.Views;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Proyecto3Ev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TBShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.5;
        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        private void PreviewLeftMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            BtnShowHide.IsChecked = false;
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Usuarios_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Usuarios();
        }

        //private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if(e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        DragMove();
        //    }
        //}

        private void BtnProductos_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Producto();
        }

        private void MiCuenta(object sender, RoutedEventArgs e)
        {
            MiCuenta mc = new MiCuenta();
            mc.ShowDialog();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            AcercaDe ac = new AcercaDe();
            ac.ShowDialog();
        }

        private void dashboard(object sender, RoutedEventArgs e)
        {
            DataContext = new DashBoard();
        }

        private void POS(object sender, RoutedEventArgs e)
        {
            DataContext = new POS();
        }
        private void CambiarEstado()
        {
            switch(WindowState)
            {
                case WindowState.Normal:
                    {
                        WindowState = WindowState.Maximized;
                        break;
                    }
                case WindowState.Maximized:
                    {
                        WindowState= WindowState.Normal;
                        break;
                    }
            }
        }
        public void RestaurarVentana(object sender, RoutedEventArgs a)
        {
            Mover(sender as Border);
        }

        private void Mover(Border header)
        {
            var restaurar = false;

            header.MouseLeftButtonDown += (s, e) =>
            {
                if (e.ClickCount == 2)
                {
                    if ((ResizeMode == ResizeMode.CanResize) || ResizeMode == ResizeMode.CanResizeWithGrip)
                    {
                        CambiarEstado();
                    }
                }
                else
                {
                    if (WindowState == WindowState.Maximized)
                    {
                        restaurar = true;
                    }
                    DragMove();
                }
            };
            header.MouseLeftButtonUp += (s, e) =>
            {
                restaurar = false;
            };
            header.MouseMove += (s, e) =>
            {
                if(restaurar)
                {
                    try
                    {
                        restaurar = false;
                        var MouseX = e.GetPosition(this).X;
                        var width = RestoreBounds.Width;
                        var x = MouseX - width / 2;
                        if(x < 0)
                        {
                            x = 0;
                        }
                        else if(x + width < SystemParameters.PrimaryScreenHeight)
                        {
                            x = SystemParameters.PrimaryScreenWidth - width;
                        }
                        WindowState = WindowState.Normal;
                        Left = x;
                        Top = 0;
                        DragMove();
                    }
                    catch(System.Exception)
                    {
                        throw;
                    }
                }
            };

        }
    }
}
