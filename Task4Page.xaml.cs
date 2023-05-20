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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 4 

            int a = Convert.ToInt32(TbNumberA.Text);
            int b = Convert.ToInt32(TbNumberB.Text);
            int c = Convert.ToInt32(TbNumberC.Text);

            double M = (a + b) / (2.0 * c);
            int k = (int)M % 3;

            double y;

            if (k == 1)
            {
                y = Math.Log(a / b);
               
            }
            else if (k == 0)
            {
                y = Math.Exp(M + c);
               
            }
            else
            {
                y = Math.Sqrt(Math.Abs(Math.Pow(a + b, 2) + c));
            }

            TextBlockAnswer.Text = $"Значение функции y = {y}";

        }
    }
}
