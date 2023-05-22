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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Дополнительное задание 1

            int number = Convert.ToInt32(TbNumberA.Text);
            string description;

            if (number == 0)
            {
                description = "нулевое число";
            }
            else if (number > 0)
            {
                if (number % 2 == 0)
                {
                    description = "положительное четное число";
                }
                else
                {
                    description = "положительное нечетное число";
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    description = "отрицательное четное число";
                }
                else
                {
                    description = "отрицательное нечетное число";
                }
            }

            TextBlockAnswer.Text = description;
        }
    }
}
