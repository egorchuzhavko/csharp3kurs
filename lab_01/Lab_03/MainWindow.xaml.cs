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

namespace Lab_03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int counter = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorToRed_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Background = new SolidColorBrush(Colors.Red);
        }
        private void ColorToBlue_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Background = new SolidColorBrush(Colors.Blue);
        }
        private void ColorToGreen_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Background = new SolidColorBrush(Colors.Green);
        }
        private void ColorToYellow_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Background = new SolidColorBrush(Colors.Yellow);
        }
        private void ColorToOrange_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Background = new SolidColorBrush(Colors.Orange);
        }
        private void ColorToPurple_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Background = new SolidColorBrush(Colors.Purple);
        }
        private void ColorToWhite_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Background = new SolidColorBrush(Colors.White);
        }
        private void ExitFromProgram(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void InfoAboutDesigner(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Чужавко Егор Т-992");
        }

        private void SetBrushColorRed(object sender,RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Color = Colors.Red;
        }
        private void SetBrushColorOrange(object sender, RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Color = Colors.Orange;
        }
        private void SetBrushColorYellow(object sender, RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Color = Colors.Yellow;
        }
        private void SetBrushColorGreen(object sender, RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Color = Colors.Green;
        }
        private void SetBrushColorSkyBlue(object sender, RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Color = Colors.SkyBlue;
        }
        private void SetBrushColorBlue(object sender, RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void SetBrushColorPurple(object sender, RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Color = Colors.Purple;
        }

        private void SetDrawModeIntoDrawning(object sender, RoutedEventArgs e)
        {
            DrawingPaper.EditingMode = InkCanvasEditingMode.Ink;
        }
        private void SetDrawModeIntoEditing(object sender, RoutedEventArgs e)
        {
            DrawingPaper.EditingMode = InkCanvasEditingMode.Select;
        }
        private void SetDrawModeIntoDeleting(object sender, RoutedEventArgs e)
        {
            DrawingPaper.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
        private void SizeChangedOnSlider(object sender, RoutedEventArgs e)
        {
            DrawingPaper.DefaultDrawingAttributes.Height = sl.Value;
            DrawingPaper.DefaultDrawingAttributes.Width = sl.Value;
        }

        private void MouseEnterToMenu(object sender, RoutedEventArgs e)
        {
            sb.Text = "Это меню для выбора некоторого функционала";
        }
        private void MouseEnterToColor(object sender, RoutedEventArgs e)
        {
            sb.Text = "Это пункт меню для выбора цвета окна";
        }
        private void MouseEnterToInfoAboutDeveloper(object sender, RoutedEventArgs e)
        {
            sb.Text = "Это пункт меню для сообщения информации о разработчике";
        }
        private void MouseEnterToExit(object sender, RoutedEventArgs e)
        {
            sb.Text = "Это пункт меню для выхода из программы";
        }
        private void ChangeColorB(object sender, RoutedEventArgs e)
        {
            switch (counter)
            {
                case 1:
                    MainPage.Background = new SolidColorBrush(Colors.Red);
                    counter++;
                    break;
                case 2:
                    MainPage.Background = new SolidColorBrush(Colors.Blue);
                    counter++;
                    break;
                case 3:
                    MainPage.Background = new SolidColorBrush(Colors.Green);
                    counter++;
                    break;
                case 4:
                    MainPage.Background = new SolidColorBrush(Colors.Yellow);
                    counter++;
                    break;
                case 5:
                    MainPage.Background = new SolidColorBrush(Colors.Orange);
                    counter++;
                    break;
                case 6:
                    MainPage.Background = new SolidColorBrush(Colors.Purple);
                    counter++;
                    break;
                case 7:
                    MainPage.Background = new SolidColorBrush(Colors.White);
                    counter++;
                    break;
            }
            counter = counter > 7 ? 1 : counter;
        }
    }
}
