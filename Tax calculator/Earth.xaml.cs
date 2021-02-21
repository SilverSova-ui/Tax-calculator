using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tax_calculator
{
    /// <summary>
    /// Логика взаимодействия для Earth.xaml
    /// </summary>
    public partial class Earth : Window
    {
        public Earth()
        {
            InitializeComponent();
            double a = 0.1;
            for (int i = 0;i<20; i++)
            {
                combo_Earth_rate.Items.Add(a.ToString() + "%");
                a = a + 0.1;
            }
        }

        private void exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow Transition = new MainWindow();
            Transition.Show();
            this.Close();
        }

        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(t_cadastral.Text) || combo_Earth_rate.Text == string.Empty) 
            {
                MessageBox.Show("Ошибка, Введите кадастровую стоимость", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Module call = new Module();
                call.calculationEarth(combo_Earth_rate, t_cadastral, t_ndfl, t_result, t_Remaining_sum);
            }
        }
    }
}
