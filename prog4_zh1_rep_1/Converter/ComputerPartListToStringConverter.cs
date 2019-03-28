using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace prog4_zh1_rep_1.VM
{
    class ComputerPartListToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable<ComputerPart> computerParts = value as IEnumerable<ComputerPart>;
            string output = string.Empty;
            if(computerParts !=null)
            {
                output = string.Join(", ", computerParts.Select(x => $"{x.Identifer} {x.Category} {x.Price}"));
            }
            return output;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
