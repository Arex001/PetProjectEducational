﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PetProjectEducational.Pages._01___Main_Menu_Page_1;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace PetProjectEducational.Pages._00___Main_Menu
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPage01.xaml
    /// </summary>
    public partial class MainMenuPage01 : Page
    {
        public MainMenuPage01()
        {
            InitializeComponent();
        }

        private void MainMenuPrevious(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenuNext(object sender, RoutedEventArgs e)
        {

        }

        private void IntroductionClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrameInstance.Navigate(new Page1Introduction());
        }
    }
}
