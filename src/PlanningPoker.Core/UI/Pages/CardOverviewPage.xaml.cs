using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanningPoker.Core.ViewModel;
using Xamarin.Forms;

namespace PlanningPoker.Core.UI.Pages
{
    public partial class CardOverviewPage : ContentPage
    {

        public CardOverviewViewModel ViewModel { get; set; }

        public CardOverviewPage()
        {
            InitializeComponent();

            BindingContext = ViewModel = new CardOverviewViewModel(Navigation);
        }
    }
}
