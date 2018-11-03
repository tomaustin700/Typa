using Typa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Typa.ViewModels
{
    public abstract class BaseViewModel : BaseNotify
    {
       
        public BaseViewModel()
        {
            Loaded();
        }

        public abstract void Loaded();
    }
}
