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

namespace SanValentin
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Comprobar(object sender, TextChangedEventArgs e)
        {
            if (Respuesta.Text == "Tú")
            {
                MiImagen.Visibility = Visibility.Visible; // Hace visible la imagen
            }
            else
            {
                MiImagen.Visibility = Visibility.Hidden; // Oculta la imagen
            }
        }
    }
}
