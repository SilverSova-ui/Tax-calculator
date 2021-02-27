using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Text.Json;

namespace Tax_calculator
{
    class Module
    {
        public async Task recording_JSON(TextBlock title, List<Tuple<string, string>> jouranl)
        {
            Directory.CreateDirectory(@".\json");
            using (FileStream fs = new FileStream(@".\json\Journal.json", FileMode.Append))
            {
                Journal new_journal = new Journal() { Calculation_Name = title.Text, Meaning = jouranl, DataTime = DateTime.Now.ToString() };
                await System.Text.Json.JsonSerializer.SerializeAsync<Journal>(fs, new_journal);
            }
        }

        public async Task reset_JSON(ComboBox combo_log)
        {
            List<Journal> journal = new List<Journal>();
            JsonTextReader reader = new JsonTextReader(new StreamReader(@".\json\Journal.json"));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                else
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    Journal obj = serializer.Deserialize<Journal>(reader);
                    journal.Add(obj);
                    string j = "";
                    for (int i = 0; i < journal.Count; i++)
                    {
                        for (int q = 0; q < journal[i].Meaning.Count; q++)
                        {
                            j += journal[i].Meaning[q].Item1 + " " + journal[i].Meaning[q].Item2 + "\n";
                        }
                        combo_log.Items.Add(journal[i].Calculation_Name + ":\n" + j + "Дата и время расчетов " + journal[i].DataTime);
                        j = "";
                    }
                }
            }
        }

        public void fillCompletion(Face obj_json, ComboBox combo)
        {
            for (int i = 0; i < obj_json.Tax.Length; i++)
            {
                combo.Items.Add(obj_json.Tax[i]);
            }
        }

        public void content(string[] Tax, ComboBox combo_rate)
        {
            for (int i = 0; i < Tax.Length; i++)
            {
                combo_rate.Items.Add(Tax[i] + "%");
            }
        }

        public void calculationNDFL(TextBox t_Sum, ComboBox combo_rate, TextBlock t_Tax_fee, TextBlock t_Remaining_sum)
        {
            int Sum = Convert.ToInt32(t_Sum.Text);
            int rate = Convert.ToInt32(combo_rate.Text.Trim('%'));
            double result = System.Math.Round((double)(Sum * rate / 100));
            t_Tax_fee.Text = result.ToString() + " руб";
            t_Remaining_sum.Text = (Convert.ToInt32(Sum) - result).ToString() + " руб";
        }
        public void calculationEarth(ComboBox combo_Earth_rate,TextBox t_cadastral,TextBox t_ndfl, TextBlock t_result, TextBlock t_Remaining_sum)
        {
            double a = Convert.ToDouble(combo_Earth_rate.Text.Trim('%'));
            double result = System.Math.Round((double)(Convert.ToInt32(t_cadastral.Text) * a / 100));
            if (t_ndfl.Text == string.Empty)
            {
                t_result.Text = result.ToString() + " руб";
                t_Remaining_sum.Text = (Convert.ToInt32(t_cadastral.Text) - result).ToString() + " руб";
            }
            else if (t_ndfl.Text != string.Empty)
            {
                string ndfl = t_ndfl.Text.Remove(t_ndfl.Text.Length - 3);
                result = result - Convert.ToDouble(ndfl);
                t_result.Text = result.ToString() + " руб";
                t_Remaining_sum.Text = (Convert.ToInt32(t_cadastral.Text) - result).ToString() + " руб";
            }
        }
        public void calculationTransport(Table_Region[] obj_json, TextBox t_Power, ComboBox combo_Term_of_ownership, ComboBox combo_Region, TextBox t_sum, ComboBox combo_Price, TextBlock t_result, TextBlock t_Remaining_sum)
        {
            int colums = obj_json[0].Power_rate.GetUpperBound(1) + 1;
            int p = Convert.ToInt32(t_Power.Text);
            int m = Convert.ToInt32(combo_Term_of_ownership.Text);
            for (int i = 0; i < obj_json.Length; i++)
            {
                if (obj_json[i].Name_Region == combo_Region.Text)
                {
                    for (int t = 0; t < colums; t++)
                    {
                        int min = Convert.ToInt32(obj_json[i].Power_rate[0, t].Split('-')[0]);
                        int max = Convert.ToInt32(obj_json[i].Power_rate[0, t].Split('-')[1]);
                        if (p >= min && p <= max)
                        {
                            double R = Convert.ToDouble(obj_json[i].Power_rate[1, t]);
                            int sum = Convert.ToInt32(t_sum.Text);
                            switch (combo_Price.Text)
                            {
                                case "От 3000000 до 5000000 руб.":
                                    double result = System.Math.Round((double)R * p * m / 12 * 1.1);
                                    t_result.Text = result.ToString() + " руб.";
                                    var r_sum = sum - result;
                                    t_Remaining_sum.Text = r_sum.ToString() + " руб.";
                                    break;
                                case "От 5000000 до 10000000 руб.":
                                    result = System.Math.Round((double)R * p * m / 12 * 2);
                                    t_result.Text = result.ToString() + " руб.";
                                    r_sum = sum - result;
                                    t_Remaining_sum.Text = r_sum.ToString() + " руб.";
                                    break;
                                case "От 10000000 до 15000000 руб.":
                                    result = System.Math.Round((double)R * p * m / 12 * 3);
                                    t_result.Text = result.ToString() + " руб.";
                                    r_sum = sum - result;
                                    t_Remaining_sum.Text = r_sum.ToString() + " руб.";
                                    break;
                                case "Более 15000000 руб.":
                                    result = System.Math.Round((double)R * p * m / 12 * 3);
                                    t_result.Text = result.ToString() + " руб.";
                                    r_sum = sum - result;
                                    t_Remaining_sum.Text = r_sum.ToString() + " руб.";
                                    break;
                                default:
                                    result = System.Math.Round((double)R * p * m / 12);
                                    t_result.Text = result.ToString() + " руб.";
                                    r_sum = sum - result;
                                    t_Remaining_sum.Text = r_sum.ToString() + " руб.";
                                    break;
                            }
                        }
                    }
                }
            }
        }
        public void calculationIncome(Regex regex,TextBox t_work,TextBlock t_Tax,int D, int P, int CT)
        {
            if (t_work.Text == string.Empty)
            {
                var result = System.Math.Round((double)((D - P) * CT / 100));
                t_Tax.Text = result.ToString() + " руб.";
            }
            else
            {
                if (!regex.IsMatch(t_work.Text))
                {
                    MessageBox.Show("Ошибка, введите сумму", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    int W = Convert.ToInt32(t_work.Text);
                    var result = System.Math.Round((double)((D - W - P) * CT / 100));
                    t_Tax.Text = result.ToString() + " руб.";
                }
            }
        }
        public void calculationNDS(ComboBox combo_choice, Label sum, TextBlock t_sum, int p, int r, Label NDS_result, TextBlock t_NDS_result)
        {
            if (combo_choice.Text == combo_choice.Items[0].ToString().Replace("System.Windows.Controls.ComboBoxItem:", "").Trim())
            {
                var result = System.Math.Round((double)p * r / (r + 100));
                sum.Content = "НДС из цены " + p.ToString() + " руб.";
                t_sum.Text = result.ToString() + " руб.";
                NDS_result.Content = "";
                t_NDS_result.Text = "";
            }
            else if (combo_choice.Text == combo_choice.Items[1].ToString().Replace("System.Windows.Controls.ComboBoxItem:", "").Trim())
            {
                var result = System.Math.Round((double)p * (r + 100) / 100);
                Console.WriteLine(result);
                sum.Content = "Начисление НДС к цене " + p.ToString() + " руб.";
                t_sum.Text = result.ToString() + " руб.";
                NDS_result.Content = "цена НДС ";
                result = result - p;
                t_NDS_result.Text = result.ToString() + " руб.";
            }
        }
    }
}
