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
                try
                {
                    int CT = Convert.ToInt32(t_rate_Tax.Text);
                    int D = Convert.ToInt32(t_sum_Revenue.Text);
                    int P = Convert.ToInt32(t_sum_Expenses.Text);
                    Module call = new Module();
                    call.calculationIncome(regex, t_work, t_Tax, D, P, CT);
                    List<Tuple<string, string>> jouranl = new List<Tuple<string, string>>();
                    jouranl.Add(new Tuple<string, string>(rate_Tax.Content.ToString(), t_rate_Tax.Text));
                    jouranl.Add(new Tuple<string, string>(sum_Expenses.Content.ToString(), t_sum_Expenses.Text));
                    jouranl.Add(new Tuple<string, string>(sum_Revenue.Content.ToString(), t_sum_Revenue.Text));
                    jouranl.Add(new Tuple<string, string>(work.Content.ToString(), t_work.Text));
                    jouranl.Add(new Tuple<string, string>(Tax.Content.ToString(), t_Tax.Text));
                    call.recording_JSON(title, jouranl);
                }
                catch
                {
                    MessageBox.Show("Ошибка, формата ввода", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
