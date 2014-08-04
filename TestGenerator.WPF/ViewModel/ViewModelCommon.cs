using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.WPF.ViewModel
{
    public class ViewModelCommon: ViewModelBase
    {
        private string tilte;

        public string Title
        {
            get { return tilte; }
            set { tilte = value; RaisePropertyChanged<string>("Title"); }
        }

    }
}
