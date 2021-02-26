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
    /// Логика взаимодействия для NDS.xaml
    /// </summary>
    public partial class NDS : Window
    {
        public NDS()
        {
            InitializeComponent();
        }

        private void exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(t_price.Text) || combo_rate.Text == string.Empty || combo_choice.Text == string.Empty)
            {
                MessageBox.Show("Ошибка, введите сумму", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else {
                int p = Convert.ToInt32(t_price.Text);
                int r = Convert.ToInt32(combo_rate.Text.Trim('%'));
                Module call = new Module();
                call.calculationNDS(combo_choice, sum, t_sum, p, r,NDS_result,t_NDS_result);                
            }
        }
    }
}
