using System.Windows;
using System.Windows.Media;

namespace Ejer09_NBA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            letraTextBlock.Foreground = new SolidColorBrush(Colors.White);
        }
    }
}
