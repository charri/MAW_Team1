using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlanningPoker.Core.Model;
using Xamarin.Forms;

namespace PlanningPoker.Core.ViewModel
{
    public class CardViewModel : ViewModelBase
    {
        private Card _card;
        public Card Card
        {
            get { return _card; }
            set { SetProperty(ref _card, value); }
        }

        public CardViewModel(INavigation navigation, Card card)
            : base(navigation)
        {
            Card = card;
        }
    }
}
