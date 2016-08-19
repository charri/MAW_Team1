using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanningPoker.Core.Model;
using PlanningPoker.Core.ViewModel;
using Xamarin.Forms;

namespace PlanningPoker.Core.UI.Pages
{
    public partial class CardPage : ContentPage
    {

        public CardViewModel ViewModel { get; set; }

        public CardPage(Card card)
        {
            InitializeComponent();


            BindingContext = ViewModel = new CardViewModel(Navigation, card);
        }
    }
}
