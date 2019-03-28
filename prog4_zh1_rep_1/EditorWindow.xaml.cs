using prog4_zh1_rep_1.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prog4_zh1_rep_1
{
    /// <summary>
    /// Interaction logic for EditorWindow.xaml
    /// </summary>
    public partial class EditorWindow : Window
    {
        EditorViewModel VM;
        public ComputerPart ComputerPart { get { return VM.ComputerPart; } }

        public EditorWindow()
        {
            InitializeComponent();
            VM = FindResource("VM") as EditorViewModel;
        }

        public EditorWindow(ComputerPart computerPart) : this()
        {
            VM.ComputerPart = computerPart;
        }

        private void OkClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void IdentiferInput(object sender, TextCompositionEventArgs e)
        {
            int textLength = Identifer.Text.Length;

            if(textLength == 1)
            {
                e.Handled = !char.IsDigit(Identifer.Text[0]);
            }
            if(textLength == 2)
            {
                e.Handled = !char.IsDigit(Identifer.Text[1]);
            }
            if (textLength == 3)
            {
                e.Handled = !char.IsLetter(Identifer.Text[2]);
            }
            if (textLength == 4)
            {
                e.Handled = !char.IsLetter(Identifer.Text[3]);
            }
            if (textLength == 5)
            {
                e.Handled = !char.IsDigit(Identifer.Text[4]);
            }
            if (textLength == 6)
            {
                e.Handled = !char.IsDigit(Identifer.Text[5]);
            }
            if (textLength > 6)
            {
                e.Handled = true;
            }
        }
    }
}
