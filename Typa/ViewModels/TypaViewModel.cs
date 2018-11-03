using Microsoft.Win32;
using Typa.Classes;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Typa.ViewModels
{
    public class TypaViewModel : BaseViewModel
    {
        #region Fields


        #endregion

        #region Properties

        #endregion

        #region Constructor
        public TypaViewModel()
        {
            SampleCommand = new DelegateCommand(SampleMethod, CanSampleMethod);


        }
        #endregion

        #region Commands

        public DelegateCommand SampleCommand { get; set; }



        #endregion

        #region Methods

        public override void Loaded()
        {

        }

        void SampleMethod()
        {

        }

        bool CanSampleMethod()
        {
            return true;
        }

       

        #endregion
    }
}
