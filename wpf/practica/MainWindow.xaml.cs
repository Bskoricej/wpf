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

namespace practica
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           this.Close();

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.Red);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.LightBlue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Теслова Дарья");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Win.Background = new SolidColorBrush(Colors.LightBlue);
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Теслова Дарья");
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = "Закрыть приложение";
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            one.Text = "Информация о разработчике";
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на красный";
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на розовый";
        }

        private void Image_MouseEnter_4(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на зеленый";
        }

        private void Image_MouseEnter_5(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на голубой";
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = "Информация о разработчике";
        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на красный";
        }

        private void MenuItem_MouseEnter_2(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на розовый";
        }

        private void MenuItem_MouseEnter_3(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на зеленый";
        }

        private void MenuItem_MouseEnter_4(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить цвет на голубой";
        }

        private void MenuItem_MouseEnter_5(object sender, MouseEventArgs e)
        {
            one.Text = "Закрыть приложение";
        }
    }
}
