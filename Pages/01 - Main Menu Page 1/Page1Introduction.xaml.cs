using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PetProjectEducational.Pages._00___Main_Menu;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PetProjectEducational.Pages._01___Main_Menu_Page_1
{
    /// <summary>
    /// Логика взаимодействия для Page1Introduction.xaml
    /// </summary>
    public partial class Page1Introduction : Page
    {
        public Page1Introduction()
        {
            InitializeComponent();
        }

        private void MainMenuPrevious(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrameInstance.Navigate(new MainMenuPage01());
        }

        private void MainMenuNext(object sender, RoutedEventArgs e)
        {

        }
    }
}
