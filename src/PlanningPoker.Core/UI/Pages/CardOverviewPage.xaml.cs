using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanningPoker.Core.ViewModel;
using Xamarin.Forms;
using PlanningPoker.Core.Model;

namespace PlanningPoker.Core.UI.Pages
{
    public partial class CardOverviewPage : ContentPage
    {

        public CardOverviewViewModel ViewModel { get; set; }

        public CardOverviewPage()
        {
            InitializeComponent();

            Deck fibonnaciDeck = new FibonnaciDeck();
            BindingContext = ViewModel = new CardOverviewViewModel(Navigation, fibonnaciDeck);
        }
    }
}
