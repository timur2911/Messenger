﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure
{
    class BaseNotify : INotifyPropertyChanged
    {
        public void Notify([CallerMemberName]string propName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
