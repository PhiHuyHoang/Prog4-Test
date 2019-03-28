using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4_zh1_rep_1.VM
{
    public class ComputerPart: Binable
    {
        private string identifer;
        private string brand;
        private int price;
        private string category;

        public string Identifer { get => identifer; set => SetField(ref identifer,value); }
        public string Brand { get => brand; set => SetField(ref brand, value); }
        public int Price { get => price; set => SetField(ref price, value); }
        public string Category { get => category; set => SetField(ref category, value); }

        public ComputerPart(string identifer, string brand, int price, string category)
        {
            this.identifer = identifer;
            this.brand = brand;
            this.price = price;
            this.category = category;
        }
    }
}
