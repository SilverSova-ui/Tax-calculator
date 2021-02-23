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
        string[] power_list = new string[] { };
        string[] region_list = new string[] { };

        public Transport_Tax()
        {

            InitializeComponent();
            for (int i = 0; i<combo_Power.Items.Count; i++)
            {
                Array.Resize(ref power_list, power_list.Length + 1);
                power_list[power_list.Length - 1] = combo_Power.Items[i].ToString().Replace("System.Windows.Controls.ComboBoxItem:", "").Trim();
            }//менять смотря формулу
            for(int i = 0; i<combo_Region.Items.Count;i++)
            {
                Array.Resize(ref region_list, region_list.Length + 1);
                region_list[region_list.Length - 1] = combo_Region.Items[i].ToString().Replace("System.Windows.Controls.ComboBoxItem:", "").Trim();
                Console.WriteLine(region_list[i]);
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
            Table_Region table_Region1 = new Table_Region() { Name_Region = region_list[0], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "12", "35", "50", "75", "150" } } };
            Table_Region table_Region2 = new Table_Region() { Name_Region = region_list[1], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "10", "25,4", "50", "75", "150" } } };
            Table_Region table_Region3 = new Table_Region() { Name_Region = region_list[2], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "24", "35", "50", "75", "150" } } };
            Table_Region table_Region4 = new Table_Region() { Name_Region = region_list[3], Power_rate = new string[,] { { power_list[0], power_list[1], power_list[2], power_list[3], power_list[4] }, { "5", "7", "15", "20", "50" } } };
            Table_Region[] table_Regions = new Table_Region[] { table_Region1, table_Region2, table_Region3, table_Region4 };
            string json = JsonConvert.SerializeObject(table_Regions);
            Table_Region[] obj_json = JsonConvert.DeserializeObject<Table_Region[]>(json);
            //MessageBox.Show(obj_json[0].Name_Region + " " + obj_json[0].Power_rate[0, 0] + " " + obj_json[0].Power_rate[1, 0]);
            int colums = obj_json[0].Power_rate.GetUpperBound(1) + 1;
            int p = Convert.ToInt32(combo_Power.Text.Split('-')[1].Split(' ')[0]);
            Console.WriteLine(p);
            //
            /*for (int i=0; i<obj_json.Length; i++)
            {
                if(obj_json[i].Name_Region == combo_Region.Text)
                {
                    for (int t = 0; t<colums; t++)
                    {
                        if (combo_Power.Text == obj_json[i].Power_rate[0,t]) {
                            
                            //Console.WriteLine(obj_json[i].Power_rate[1,t] *  );
                        }
                    }
                }
            }*/
        }
    }
}
