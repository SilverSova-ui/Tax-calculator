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
    public class Face
    {
        public string Face_Name { get; set; }
        public string[] Tax { get; set; }
    }
    /*class Tax_Rate
    {
        public string Tax_Name { get; set; }
        public string[] Tax_rate { get; set; }
    }*/

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //json и сократить код
            InitializeComponent();
            Face face1 = new Face() { Face_Name = "Физическое лицо", Tax = new string[] {"НДФЛ", "Земельный налог", "Транспортный налог", "Налог на имущество" }};
            Face face2 = new Face() { Face_Name = "Юридическо лицо", Tax = new string[] { "Налог на прибыль", "Налог на имущество предприятий", "НДС" } };
            Face[] face = new Face[] {face1, face2 };
            string json = JsonConvert.SerializeObject(face);
            Face[] obj_json = JsonConvert.DeserializeObject<Face[]>(json);
            /*string[] NDFL = new string[] {"9", "13", "30","35"};
            string[] Earth = new string[] { "Test 3", "Test 4" };
            string[] transport = new string[] { "Test 5", "Test 6" };
            string[] property = new string[] { "Test 7", "Test 8" };
            string[] profit = new string[] { "Test 9", "Test 10" };
            string[] property_enterprise = new string[] { "Test 11", "Test 12" };
            string[] NDS = new string[] { "Test 13", "Test 14" };
            string[][] bid = new string[][] { NDFL, Earth, transport, property, profit, property_enterprise, NDS};
            int t = 0;
            for(int i = 0; i< obj_json.Length; i++){
                for (int q = 0; q < obj_json[i].Tax.Length; q++)
                {
                    Tax_Rate Rate = new Tax_Rate();
                    Rate.Tax_Name = obj_json[i].Tax[q];
                    Rate.Tax_rate = bid[t];
                    string json2 = JsonConvert.SerializeObject(Rate);
                    Tax_Rate obj_json2 = JsonConvert.DeserializeObject<Tax_Rate>(json2);
                    for (int o = 0; o < obj_json2.Tax_rate.Length; o++)
                    {
                        Console.WriteLine(obj_json2.Tax_Name + " " + obj_json2.Tax_rate[o]);
                    }
                    t++;
                }
            }*/
            Task.Factory.StartNew(() =>
            {
                Module completion = new Module();
                bool tf = false;
                bool tu = false;
                while (true) {
                    //Thread.Sleep(1000);
                    try
                    {
                        Dispatcher.Invoke(() =>
                        {
                            if (combo_person.Text == "Физическое лицо" && tf == false)
                            {
                                combo_Tax.Items.Clear();
                                completion.fillCompletion(obj_json[0], combo_Tax);
                                tf = true;
                                tu = false;
                            }
                            else if (combo_person.Text == "Юридическое лицо" && tu == false)
                            {
                                combo_Tax.Items.Clear();
                                completion.fillCompletion(obj_json[1], combo_Tax);
                                tf = false;
                                tu = true;
                            }
                        });
                    }
                    catch
                    {
                        break;
                    }
                }
            });
        }

        private void Transition_Click(object sender, RoutedEventArgs e)
        {
            //условие перехода
            NDFL Transition = new NDFL();
            Transition.Show();
            this.Close();
        }


        /*NDFL Transition = new NDFL();
        Transition.Show();
        this.Close();*/
        /*Module completion = new Module();
        string Rub = t_Rub.Text;
        string Cop = t_Cop.Text;
        double i = 1000.00;
        double a = System.Math.Round((double)(i * 13 / 100));
        t_Tax_fee.Text = a.ToString() + " руб";
        t_Remaining_sum.Text = (i - a).ToString() + " руб";*/
    }
}
