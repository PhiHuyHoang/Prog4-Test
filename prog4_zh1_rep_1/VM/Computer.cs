using prog4_zh1_rep_1.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4_zh1_rep_1.VM
{
    class Computer : Binable
    {
        public BindingList<ComputerPart> computerParts { get; private set; }
        private IComputerLogic logic = new ComputerLogic();
        public int SumPrice { get => logic.TotalPrice(this); }

        public Computer()
        {
            computerParts = new BindingList<ComputerPart>();
            computerParts.ListChanged += ComputerParts_ListChanged;
        }

        private void ComputerParts_ListChanged(object sender, ListChangedEventArgs e)
        {
            OnPropertyChanged(nameof(sender));
        }  
        
        public Computer(Computer other)
        {
            computerParts = new BindingList<ComputerPart>();
            foreach (var item in other.computerParts)
            {
                computerParts.Add(item);
            }
        }
    }
}
