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

namespace Tax_calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Task.Factory.StartNew(() => 
            {
                bool tf = false;
                bool tu = false;
                while (true) {
                    Thread.Sleep(1000);
                    Dispatcher.Invoke(() =>
                    {
                        if (combo_person.Text == "Физическое лицо" && tf == false)
                        {
                            combo_Tax.Items.Clear();
                            combo_Tax.Items.Add("Физ");
                            tf = true;
                            tu = false;
                        }
                        else if (combo_person.Text == "Юридическое лицо" && tu == false)
                        {
                            combo_Tax.Items.Clear();
                            combo_Tax.Items.Add("Юри");
                            tf = false;
                            tu = true;
                        }
                    });
                }
            });
        }
    }
}
