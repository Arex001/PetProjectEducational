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
