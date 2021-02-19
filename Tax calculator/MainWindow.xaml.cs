using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Newtonsoft.Json;

namespace Tax_calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    class Tax_Rate
    {
        public string Tax_Name { get; set; }
        public string Tax_rate { get; set; }
    }

    public partial class MainWindow : Window
    {
        string[] listTax_f = new string[] { "НДФЛ", "Земельный налог", "Транспортный налог", "Налог на имущество" };
        string[] listTax_u = new string[] { "Налог на прибль", "Налог на имущество предприятий", "НДС" };
        public MainWindow()
        {
            //json и сократить код
            InitializeComponent();
            Tax_Rate tax = new Tax_Rate();
            tax.Tax_Name = "НДФЛ";
            tax.Tax_rate = "13";
            string json = JsonConvert.SerializeObject(tax);
            Tax_Rate m = JsonConvert.DeserializeObject<Tax_Rate>(json);
            Console.WriteLine(tax.Tax_Name + " " + tax.Tax_rate);
            Task.Factory.StartNew(() =>
            {
                Module completion = new Module();
                bool tf = false;
                bool tu = false;
                while (true) {
                    //Thread.Sleep(1000);
                    Dispatcher.Invoke(() =>
                    {
                        if (combo_person.Text == "Физическое лицо" && tf == false)
                        {
                            combo_Tax.Items.Clear();
                            completion.fillCompletion(listTax_f, combo_Tax);
                            tf = true;
                            tu = false;
                        }
                        else if (combo_person.Text == "Юридическое лицо" && tu == false)
                        {
                            combo_Tax.Items.Clear();
                            completion.fillCompletion(listTax_u, combo_Tax);
                            tf = false;
                            tu = true;
                        }
                        /*else if ()
                        {

                        }*/
                    });
                }
            });
        }

        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            /*Module completion = new Module();
            string Rub = t_Rub.Text;
            string Cop = t_Cop.Text;
            double i = 1000.00;
            double a = System.Math.Round((double)(i * 13 / 100));
            t_Tax_fee.Text = a.ToString() + " руб";
            t_Remaining_sum.Text = (i - a).ToString() + " руб";*/
        }
    }
}
