using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using prog4_zh1_rep_1.VM;

namespace prog4_zh1_rep_1.BL
{
    class ComputerLogic : IComputerLogic
    {

        public void AddComputerPartToComputer(IList<ComputerPart> computerPartsSource, IList<ComputerPart> computerPartsDes, ComputerPart computerPart)
        {
            if (computerPartsSource.Contains(computerPart) && !computerPartsDes.Select(x => x.Category).Contains(computerPart.Category))
            {
                computerPartsDes.Add(computerPart);
            }
        }

        public void AddNewComputerPart(IList<ComputerPart> computerParts)
        {
            EditorWindow editorWindow = new EditorWindow();
            if (editorWindow.ShowDialog() == true)
            {
                var temp = editorWindow.ComputerPart.Identifer;
                if ( temp == null || temp.Length != 6 || (temp.Length == 6 && char.IsLetter(temp[5])))
                {
                    MessageBox.Show("Your Identifer is not in correct format");
                }
                else
                {
                    computerParts.Add(editorWindow.ComputerPart);
                }
            }
        }

        public void DelComputerPartFromComputer(IList<ComputerPart> computerPartsSource, IList<ComputerPart> computerPartsDes, ComputerPart computerPart)
        {

            if (computerPartsDes.Contains(computerPart))
            {
                computerPartsDes.Remove(computerPart);
            }
        }

        public void ModifyComputerPart(ComputerPart computerPart)
        {
            EditorWindow editorWindow = new EditorWindow(computerPart);
            if(editorWindow.ShowDialog() == true)
            {
                //Do nothing
            }
        }

        public void SaveComputer(IList<Computer> computers, Computer computer)
        {
            if (computer.SumPrice > 0)
            {
                computers.Add(new Computer(computer));
                computer.computerParts.Clear();
            }
        }

        public int TotalPrice(Computer computer)
        {
            return computer.computerParts.Sum(x => x.Price);
        }
    }
}
