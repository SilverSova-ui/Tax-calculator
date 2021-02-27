using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace Tax_calculator
{
    class Table_Region
    {
        public string Name_Region { get; set; }
        public string[,] Power_rate { get; set; }
    }

    /// <summary>
    /// Логика взаимодействия для Transport_Tax.xaml
    /// </summary>
    public partial class Transport_Tax : Window
    {
        string[] power_list = new string[] { "0-100", "101-150", "151 - 200", "201-250", "251-1000" };
        string[] region_list = new string[] {};

        public Transport_Tax()
        {

            InitializeComponent();
            for(int i = 0; i<combo_Region.Items.Count;i++)
            {
                Array.Resize(ref region_list, region_list.Length + 1);
                region_list[region_list.Length - 1] = combo_Region.Items[i].ToString().Replace("System.Windows.Controls.ComboBoxItem:", "").Trim();
            }
            for(int i = 0; i<12; i++)
            {
                combo_Term_of_ownership.Items.Add((i+1).ToString());
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
            if (!regex.IsMatch(t_sum.Text) || !regex.IsMatch(t_Power.Text) || combo_Region.Text == string.Empty || combo_Term_of_ownership.Text == string.Empty)
            {
                MessageBox.Show("Ошибка, введите сумму", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Table_Region table_Region1 = new Table_Region() { Name_Region = region_list[0], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "12", "35", "50", "75", "150" } } };
                Table_Region table_Region2 = new Table_Region() { Name_Region = region_list[1], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "10", "25,4", "50", "75", "150" } } };
                Table_Region table_Region3 = new Table_Region() { Name_Region = region_list[2], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "24", "35", "50", "75", "150" } } };
                Table_Region table_Region4 = new Table_Region() { Name_Region = region_list[3], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "5", "7", "15", "20", "50" } } };
                Table_Region[] table_Regions = new Table_Region[] { table_Region1, table_Region2, table_Region3, table_Region4 };
                string json = JsonConvert.SerializeObject(table_Regions);
                Table_Region[] obj_json = JsonConvert.DeserializeObject<Table_Region[]>(json);
                Module call = new Module();
                call.calculationTransport(obj_json,t_Power,combo_Term_of_ownership,combo_Region,t_sum,combo_Price,t_result,t_Remaining_sum);
                List<Tuple<string, string>> jouranl = new List<Tuple<string, string>>();
                jouranl.Add(new Tuple<string, string>(sum.Content.ToString(), t_sum.Text));
                jouranl.Add(new Tuple<string, string>(Region.Content.ToString(), combo_Region.Text));
                jouranl.Add(new Tuple<string, string>(Term_of_ownership.Content.ToString(), combo_Term_of_ownership.Text));
                jouranl.Add(new Tuple<string, string>(Power.Content.ToString(), t_Power.Text));
                jouranl.Add(new Tuple<string, string>(Price.Content.ToString(), combo_Price.Text));
                jouranl.Add(new Tuple<string, string>(result.Content.ToString(), t_result.Text));
                jouranl.Add(new Tuple<string, string>(Remaining_sum.Content.ToString(), t_Remaining_sum.Text));
                call.recording_JSON(title, jouranl);
            }
        }
    }
}
