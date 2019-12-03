using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure
{
    class ViewModelLocator
    {
        public ViewModelLocator() => MainViewModel = new StandardKernel(new ViewModelModule()).Get<MainViewModel>();

        public object MainViewModel { get; }
    }
}
