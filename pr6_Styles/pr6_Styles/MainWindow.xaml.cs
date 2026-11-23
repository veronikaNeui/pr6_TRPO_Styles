using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace pr6_Styles
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

        private void btnChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            ThemeHelper.Toggle();
        }

        private void StartWorkoutbtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
        
        private void Resetbtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Stopbtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}