using System.Windows;


namespace MiPrimerWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("boton apretado");
            var state = checkboxMain.IsChecked;
            checkboxMain.IsChecked = !state;

            Botonmian.Content += "0";
        }
    }
}
