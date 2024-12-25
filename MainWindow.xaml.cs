using PetProjectEducational.Pages;
using PetProjectEducational.Pages._00___Main_Menu;
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

namespace PetProjectEducational
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 
        /// = new Frame() - указал, чтобы не вызывать предупреждение CS8618
        /// </summary>
        public static Frame MainFrameInstance {  get; private set; } = new Frame();

        public MainWindow()
        {
            InitializeComponent();
            MainFrameInstance = MainFrame;
        }

        private void MainMenuTransfer(object sender, RoutedEventArgs e)
        {
            MainFrameInstance.Content = new MainMenuPage01();
        }
    }
}