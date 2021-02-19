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
        public void fillCompletion(string[] listTax,ComboBox combo)
        {
            for (int i = 0; i<listTax.Length; i++)
            {
                combo.Items.Add(listTax[i]);
            }
        }
    }
}
