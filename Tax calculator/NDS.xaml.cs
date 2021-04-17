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
            MainWindow Transition = new MainWindow();
            Transition.Show();
            this.Close();
        }

        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"^[0-9]+$");
                if (!regex.IsMatch(t_price.Text) || combo_rate.Text == string.Empty || combo_choice.Text == string.Empty)
                {
                    MessageBox.Show("Ошибка, введите сумму", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    int p = Convert.ToInt32(t_price.Text);
                    int r = Convert.ToInt32(combo_rate.Text.Trim('%'));
                    Module call = new Module();
                    call.calculationNDS(combo_choice, sum, t_sum, p, r, NDS_result, t_NDS_result);
                    List<Tuple<string, string>> jouranl = new List<Tuple<string, string>>();
                    jouranl.Add(new Tuple<string, string>(price.Content.ToString(), t_price.Text));
                    jouranl.Add(new Tuple<string, string>(choice.Content.ToString(), combo_choice.Text));
                    jouranl.Add(new Tuple<string, string>(rate.Content.ToString(), combo_rate.Text));
                    jouranl.Add(new Tuple<string, string>(sum.Content.ToString(), t_sum.Text));
                    if (combo_choice.Text == combo_choice.Items[1].ToString().Replace("System.Windows.Controls.ComboBoxItem:", "").Trim())
                    {
                        jouranl.Add(new Tuple<string, string>(NDS_result.Content.ToString(), t_NDS_result.Text));
                    }
                    call.recording_JSON(title, jouranl);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка, формата ввода", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
