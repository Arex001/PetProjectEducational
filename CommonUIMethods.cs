using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PetProjectEducational
{
    internal class CommonUIMethods
    {
        #region Перечисление, отвечающее за контейнеры.
        /// <summary>
        /// Перечисление, отвечающее за контейнеры.
        /// </summary>
        enum PanelsTypes
        {
            /// <summary>
            /// Разделяет пространство на строки и столбцы. Универсален и очень часто используется.
            /// </summary>
            Grid,

            /// <summary>
            /// Делит область на одинаковые ячейки. Подходит для равномерных сеток (например, шахматная доска).
            /// </summary>
            UniformGrid,

            /// <summary>
            /// Располагает дочерние элементы вертикально или горизонтально. Удобен для “линейного” интерфейса.
            /// </summary>
            StackPanel,

            /// <summary>
            /// Как StackPanel, но оптимизирована для длинных списков. “Виртуализирует” невидимые элементы для экономии ресурсов.
            /// </summary>
            VirtualizingStackPanel,

            /// <summary>
            /// Элементы «переносятся» на новую строку/столбец при нехватке места. Полезен для галерей, облаков тегов и т. д.
            /// </summary>
            WrapPanel,

            /// <summary>
            /// “Пришивает” элементы к сторонам контейнера (Top, Bottom, Left, Right). Последний элемент занимает оставшееся пространство.
            /// </summary>
            DockPanel,

            /// <summary>
            /// Позиционирование по координатам (x, y). Удобен для кастомной графики и динамических сцен.
            /// </summary>
            Canvas,

            /// <summary>
            /// Масштабирует вложенный элемент, сохраняя пропорции. Полезен, если нужно растягивать контент при изменении размера окна.
            /// </summary>
            Viewbox,

            /// <summary>
            /// Рисует рамку вокруг своего содержимого (+ фон, закругления). Часто используется для выделения блоков.
            /// </summary>
            Border,

            /// <summary>
            /// Отображает маленькую метку (буллет) рядом с основным содержимым. Например, для пунктов списка.
            /// </summary>
            BulletDecorator
        }
        #endregion

        #region Метод создает границу, занимающую все пространство.
        /// <summary>
        /// Создает границу, занимающую все пространство.
        /// </summary>
        /// <param name="borderThickness"> Толщина границы. </param>
        /// <param name="borderBrush"> Цвет границы. </param>
        /// <param name="backgroundColor"> Цвет фона внутри границы. </param>
        /// <param name="paddingThickness"> Толщина отступа между границей и контентом внутри. </param>
        /// <param name="marginThickness"> Толищна отступа между границей и внешним пространством. </param>
        /// <returns> Граница, занимающая все пространство. </returns>
        public static Border CreateStretchBorder(int borderThickness, 
                                    Brush borderBrush, 
                                    Brush backgroundColor, 
                                    int paddingThickness,
                                    int marginThickness)
        {
            return new Border()
            {
                BorderThickness = new Thickness(borderThickness),
                BorderBrush = borderBrush,
                Background = backgroundColor,
                Padding = new Thickness(paddingThickness),
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Margin = new Thickness(marginThickness),
            };
        }
        #endregion

        #region Метод создает ячейку текста с максимально возможным размером шрифта на 1 строку.
        /// <summary>
        /// Создает ячейку текста с максимально возможным размером шрифта на 1 строку.
        /// </summary>
        /// <param name="text"> Текст. </param>
        /// <param name="textColor"> Цвет текста. </param>
        /// <param name="fontWeight"> Насыщенность шрифта. </param>
        /// <returns></returns>
        public static Viewbox CreateTextBlockWithOneString(string text, 
                                                            Brush textColor,
                                                            FontWeight fontWeight)
        {
            TextBlock textBlock = new TextBlock
            {
                Text = text,
                Foreground = textColor,
                TextAlignment = TextAlignment.Center,
                FontWeight = fontWeight
            };

            Viewbox viewbox = new Viewbox();
            viewbox.Child = textBlock;
            return viewbox;
        }
        #endregion
    }
}
