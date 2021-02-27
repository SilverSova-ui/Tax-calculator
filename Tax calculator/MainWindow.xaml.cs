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
    class Face
    {
        public string Face_Name { get; set; }
        public string[] Tax { get; set; }
    }
    public class Journal
    {
        public string Calculation_Name { get; set; }
        public List<Tuple<string, string>> Meaning { get; set; }

        public string DataTime { get; set; }
    }



    public partial class MainWindow : Window
    {
        bool task = true;
        public MainWindow()
        {
            InitializeComponent();
            Module call = new Module();
            call.reset_JSON(combo_log);
            Face face1 = new Face() { Face_Name = "Физическое лицо", Tax = new string[] {"НДФЛ", "Земельный налог", "Транспортный налог"}};
            Face face2 = new Face() { Face_Name = "Юридическо лицо", Tax = new string[] { "Налог на прибыль", "НДС" } };
            Face[] face = new Face[] {face1, face2 };
            string json = JsonConvert.SerializeObject(face);
            Face[] obj_json = JsonConvert.DeserializeObject<Face[]>(json);
            Task.Factory.StartNew(() =>
            {
                Module completion = new Module();
                bool tf = false;
                bool tu = false;
                while (task == true) {
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
                        task = false;
                        break;
                    }
                }
            });
        }



        private void Transition_Click(object sender, RoutedEventArgs e)
        {

            if (combo_person.Text == "Физическое лицо" && combo_Tax.Text == "НДФЛ") {
                task = false;
                NDFL Transition = new NDFL();
                Transition.Show();
                this.Close();
            }
            else if(combo_person.Text == "Физическое лицо" && combo_Tax.Text == "Земельный налог")
            {
                task = false;
                Earth Transition = new Earth();
                Transition.Show();
                this.Close();
            }
            else if (combo_person.Text == "Физическое лицо" && combo_Tax.Text == "Транспортный налог")
            {
                task = false;
                Transport_Tax Transition = new Transport_Tax();
                Transition.Show();
                this.Close();
            }
            else if (combo_person.Text == "Юридическое лицо" && combo_Tax.Text == "Налог на прибыль")
            {
                task = false;
                IncomeTax Transition = new IncomeTax();
                Transition.Show();
                this.Close();
            }
            else if (combo_person.Text == "Юридическое лицо" && combo_Tax.Text == "НДС")
            {
                task = false;
                NDS Transition = new NDS();
                Transition.Show();
                this.Close();
            }
        }
    }
}
