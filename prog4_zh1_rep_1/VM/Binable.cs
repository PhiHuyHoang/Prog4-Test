﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prog4_zh1_rep_1.VM
{
    public class Binable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        protected void SetField<T>(ref T field, T value, [CallerMemberName]string name = null)
        {
            field = value;
            OnPropertyChanged(name);
        }
    }
}
