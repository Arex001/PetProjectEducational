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
using static PetProjectEducational.CommonUIMethods;
using static PetProjectEducational.JsonMethods;

namespace PetProjectEducational
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Frame, который используется для отображения различного контента.
        /// "= new Frame()" - указал, чтобы не вызывать предупреждение CS8618.
        /// </summary>
        public static Frame MainFrameInstance {  get; private set; } = new Frame();

        public MainWindow()
        {
            InitializeComponent();
            //SetupGrid();
        }

        public void SetupGrid()
        {
            // Добавляем строки и столбцы
            MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            
            // Создаем 3 Border и 3 TextBlock
            var border1 = CreateStretchBorder(5, Brushes.Black, Brushes.Bisque, 5, 10);
            var border2 = CreateStretchBorder(5, Brushes.Black, Brushes.Gray, 5, 10);
            var border3 = CreateStretchBorder(5, Brushes.Black, Brushes.Azure, 50, 10);

            var textBlock1 = CreateTextBlockWithOneString("Пример текста внутри Border #1", Brushes.Black, FontWeights.Bold);
            var textBlock2 = CreateTextBlockWithOneString("Пример текста внутри Border #2", Brushes.DarkBlue, FontWeights.DemiBold);
            var textBlock3 = CreateTextBlockWithOneString("Пример текста внутри Border #3", Brushes.Crimson, FontWeights.UltraBlack);

            // Привязываем TextBlock к своим Border
            border1.Child = textBlock1;
            border2.Child = textBlock2;
            border3.Child = textBlock3;

            // Указываем позиции в Grid
            Grid.SetRow(border1, 0);
            Grid.SetColumn(border1, 1);
            Grid.SetColumnSpan(border1, 2);

            Grid.SetRow(border2, 1);
            Grid.SetColumn(border2, 0);

            Grid.SetRow(border3, 1);
            Grid.SetColumn(border3, 1);

            // Добавляем Border-ы в Grid
            MainGrid.Children.Add(border1);
            MainGrid.Children.Add(border2);
            MainGrid.Children.Add(border3);
        }
    }
}