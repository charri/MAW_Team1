using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using PlanningPoker.Core.Helpers;
using Xamarin.Forms;

namespace PlanningPoker.Core.ViewModel
{
    public abstract class ViewModelBase
        : BaseViewModel
    {

        protected INavigation Navigation { get; }

        public ViewModelBase(INavigation navigation = null)
        {
            Navigation = navigation;
        }

        public Settings Settings
        {
            get { return Helpers.Settings.Current; }
        }
    }
}
