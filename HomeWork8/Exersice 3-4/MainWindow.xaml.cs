using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
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

//Семиков Сергей


namespace HomeWork8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataWeather data = new DataWeather();
        public MainWindow()
        {
            InitializeComponent();
            data.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/37.xml");
            data.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/5.xml");
            listView.ItemsSource = data.Data;
            Width = listView.Width + 10;
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                data.AddCity(textBox.Text);
                textBox.Text = "Ссылка на город .xml";
                listView.ItemsSource = data.Data;
            }
            catch (System.Net.WebException)
            {
                textBox.Text = "Неверная ссылка на город .xml";
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            data.Clear();
            listView.ItemsSource = null;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
