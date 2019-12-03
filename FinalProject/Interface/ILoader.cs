using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Interface
{
    interface ILoader
    {
        void LoadCars(out ObservableCollection<Car> cars);
    }
}
