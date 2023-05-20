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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 3

            int a = Convert.ToInt32(TbNumberA.Text);
            int b = Convert.ToInt32(TbNumberB.Text);
            int c = Convert.ToInt32(TbNumberC.Text);

            int result;

            if (a == b)
            {
                result = c;
            }
            else if (a == c)
            {
                result = b;
            }
            else
            {
                result = a;
            }

            TextBlockAnswer.Text = $"Порядковый номер числа, отличного от остальных: {result}";

        }
    }
}
