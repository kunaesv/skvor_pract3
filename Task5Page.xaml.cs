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

namespace skvor_pract3
{
    /// <summary>
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 5

            int x, y; if (!int.TryParse(TbNumberX.Text, out x) || !int.TryParse(TbNumberY.Text, out y))
            {
                TextBlockAnswer.Text = "Введите целочисленные значения!";
                return;
            }
            string result; if (x >= -40 && x <= 40 && y >= -40 && y <= 40)
            {
                result = "Точка находится внутри области";
            }
            else if (x == 40 || x == -40 || y == 40 || y == -40)
            {
                result = "Точка находится на границе области";
            }
            else
            {
                result = "Точка находится вне области";
            }
            TextBlockAnswer.Text = result;
        }
    }
}   

