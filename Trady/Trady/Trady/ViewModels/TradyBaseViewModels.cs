using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using MvvmHelpers;

namespace Trady.ViewModels
{

    public class TradyBaseViewModels : BaseViewModel
    {
        private string userName;

        public TradyBaseViewModels()
        {
            
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                if (userName == value)
                {
                    return;
                }
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
    }
}
