using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4_zh1_rep_1.VM
{
    class EditorViewModel: Binable
    {
        private ComputerPart computerPart;

        public ComputerPart ComputerPart { get => computerPart; set => SetField(ref computerPart,value); }

        private ObservableCollection<ComputerPart> ComputerParts = new MainViewModel().ComputerParts;

        public IEnumerable<string> Category { get => ComputerParts.Select(x => $"{x.Category}").Distinct(); set => OnPropertyChanged(nameof(ComputerParts)); }

        public EditorViewModel()
        {
            computerPart = new ComputerPart(null,null,0, Category.ElementAt(0));
        }
    }
}
