using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tax_calculator
{
    class Module
    {
        public void fillCompletion(Face obj_json, ComboBox combo)
        {
            for (int i = 0; i<obj_json.Tax.Length; i++)
            {
                combo.Items.Add(obj_json.Tax[i]);
            }
        }

        public void content(string[] Tax,ComboBox combo_rate)
        {
            for (int i = 0; i<Tax.Length; i++)
            {
                combo_rate.Items.Add(Tax[i] + "%");
            }
        }

        public void calculationNDFL(TextBox t_Sum,ComboBox combo_rate,TextBlock t_Tax_fee, TextBlock t_Remaining_sum)
        {
            int Sum = Convert.ToInt32(t_Sum.Text);
            int rate = Convert.ToInt32(combo_rate.Text.Trim('%'));
            double result = System.Math.Round((double)(Sum * rate / 100));
            t_Tax_fee.Text = result.ToString() + " руб";
            t_Remaining_sum.Text = (Convert.ToInt32(Sum) - result).ToString() + " руб";
        }
    }
}
