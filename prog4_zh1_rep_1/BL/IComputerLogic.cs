using prog4_zh1_rep_1.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4_zh1_rep_1.BL
{
    interface IComputerLogic
    {
        void AddNewComputerPart(IList<ComputerPart> computerParts);
        void ModifyComputerPart(ComputerPart computerPart);
        void AddComputerPartToComputer(IList<ComputerPart> computerPartsSource, IList<ComputerPart> computerPartsDes, ComputerPart computerPart);
        void DelComputerPartFromComputer(IList<ComputerPart> computerPartsSource, IList<ComputerPart> computerPartsDes, ComputerPart computerPart);
        void SaveComputer(IList<Computer> computers, Computer computer);
        int TotalPrice(Computer computer);
    }
}
