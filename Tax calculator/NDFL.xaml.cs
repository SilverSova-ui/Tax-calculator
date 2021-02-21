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
    /// Логика взаимодействия для NDFL.xaml
    /// </summary>

    public partial class NDFL : Window
    {
        Module call = new Module();
        public NDFL()
        {
            InitializeComponent();
            string[] NDFL = new string[] { "9", "13", "30", "35" };
            call.content(NDFL,combo_rate);
        }

        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(t_Sum.Text) || combo_rate.Text == string.Empty)
            {
                MessageBox.Show("Ошибка, введите сумму", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                call.calculationNDFL(t_Sum, combo_rate, t_Tax_fee, t_Remaining_sum);
            }

            
        }

        private void exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow Transition = new MainWindow();
            Transition.Show();
            this.Close();
        }
    }
}
