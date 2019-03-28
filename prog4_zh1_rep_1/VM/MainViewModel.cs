using prog4_zh1_rep_1.BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4_zh1_rep_1.VM
{
    class MainViewModel: Binable
    {
        public ObservableCollection<ComputerPart> ComputerParts { get; private set; }
        public ObservableCollection<Computer> Computers { get; private set; }
        
        private ComputerPart selectedComputerPart;
        private ComputerPart selectedComputerPartFromComputer;
        public ComputerPart SelectedComputerPart { get => selectedComputerPart; set => SetField(ref selectedComputerPart,value); }
        public ComputerPart SelectedComputerPartFromComputer { get => selectedComputerPartFromComputer; set => SetField(ref selectedComputerPartFromComputer, value); }

        private Computer oneComputer;
        public Computer OneComputer { get => oneComputer; set => SetField(ref oneComputer,value); }
        

        public RelayCommand AddNewComputerPartCommand { get; private set; }
        public RelayCommand ModifyComputerPartCommand { get; private set; }
        public RelayCommand AddComputerPartToComputerCommand { get; private set; }
        public RelayCommand RemoveComputerPartFromCputerCommand { get; private set; }
        public RelayCommand SaveComputerCommand { get; private set; }
        
        private IComputerLogic logic = new ComputerLogic();

        void LoadComputerPartFromTextFile(ObservableCollection<ComputerPart> collection, string url)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + url;
            StreamReader streamReader = new StreamReader(path);
            string lines = String.Empty;
            while ((lines = streamReader.ReadLine()) != null)
            {
                string[] MaterialComputerPart = lines.Split('/');
                collection.Add(new ComputerPart(MaterialComputerPart[0], MaterialComputerPart[1], int.Parse(MaterialComputerPart[2]), MaterialComputerPart[3]));
            }
        }

        public MainViewModel()
        {
            ComputerParts = new ObservableCollection<ComputerPart>();
            //ComputerParts.Add(new ComputerPart("hoang", "hoang", 1000, "hoang"));
            LoadComputerPartFromTextFile(ComputerParts, @"/TextFiles/initialList.txt");
            Computers = new ObservableCollection<Computer>();
            oneComputer = new Computer();

            AddNewComputerPartCommand = new RelayCommand((obj) => { logic.AddNewComputerPart(ComputerParts); });
            ModifyComputerPartCommand = new RelayCommand((obj) => { logic.ModifyComputerPart(selectedComputerPart); });
            AddComputerPartToComputerCommand = new RelayCommand((obj) => { logic.AddComputerPartToComputer(ComputerParts,OneComputer.computerParts,selectedComputerPart); });
            RemoveComputerPartFromCputerCommand = new RelayCommand((obj) => { logic.DelComputerPartFromComputer(ComputerParts,OneComputer.computerParts,selectedComputerPartFromComputer); });
            SaveComputerCommand = new RelayCommand((obj) => { logic.SaveComputer(Computers, oneComputer); });

        }


    }
}
