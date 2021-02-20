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
    }
}
