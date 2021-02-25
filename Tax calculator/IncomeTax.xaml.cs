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
    /// Логика взаимодействия для IncomeTax.xaml
    /// </summary>
    public partial class IncomeTax : Window
    {
        public IncomeTax()
        {
            InitializeComponent();
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
            if (!regex.IsMatch(t_rate_Tax.Text) || !regex.IsMatch(t_sum_Expenses.Text) || !regex.IsMatch(t_sum_Revenue.Text))
            {
                MessageBox.Show("Ошибка, введите сумму", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int CT = Convert.ToInt32(t_rate_Tax.Text);
                int D = Convert.ToInt32(t_sum_Revenue.Text);
                int P = Convert.ToInt32(t_sum_Expenses.Text);
                Module call = new Module();
                call.calculationIncome(regex,t_work,t_Tax,D,P,CT);
            }
        }
    }
}
