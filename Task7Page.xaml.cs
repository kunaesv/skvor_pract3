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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Дополнительное задание 2

            int number = Convert.ToInt32(TbNumberA.Text);
            string description;

            if (number < 1 || number > 999)
            {
                description = "Число должно быть в диапазоне от 1 до 999";
            }
            else if (number < 10)
            {
                description = "Однозначное число";
            }
            else if (number < 100)
            {
                if (number % 2 == 0)
                {
                    description = "Четное двузначное число";
                }
                else
                {
                    description = "Нечетное двузначное число";
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    description = "Четное трехзначное число";
                }
                else
                {
                    description = "Нечетное трехзначное число";
                }
            }

            TextBlockAnswer.Text = description;

        }
    }
}
