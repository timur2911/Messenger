using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure
{
   internal class StandardKernel
    {
        private ViewModelModule viewModelModule;

        public StandardKernel(ViewModelModule viewModelModule)
        {
            this.viewModelModule = viewModelModule;
        }

        internal object Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}
