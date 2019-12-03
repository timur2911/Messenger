using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Interface
{
    interface ISaver
    {
        void SaveCars(IEnumerable<Car> cars);
    }
}
