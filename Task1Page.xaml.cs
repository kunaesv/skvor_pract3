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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 1

            int a = Convert.ToInt32(TbNumberA.Text);
            int number = Convert.ToInt32(TbNumberB.Text);

            int digitSum = (number / 10) + (number % 10);
            bool isMultiple = digitSum % a == 0;

            if (isMultiple)
            {
                TextBlockAnswer.Text = $"Сумма цифр числа {number} кратна числу {a}";
            }
            else
            {
                TextBlockAnswer.Text = $"Сумма цифр числа {number} не кратна числу {a}";
            }
        }
    }
}
