using System.Windows.Input;
using PlanningPoker.Core.Model;
using PlanningPoker.Core.UI.Pages;
using Xamarin.Forms;

namespace PlanningPoker.Core.ViewModel
{
    public class CardOverviewViewModel
        : ViewModelBase
    {
        private Deck _deck;
        public Deck Deck
        {
            get { return _deck; }
            set
            {
                SetProperty(ref _deck, value);
            }
        }

        public CardOverviewViewModel(INavigation navigation, Deck deck)
            : base(navigation)
        {
            Deck = deck;
        }

        private ICommand _cardSelectedCommand;

        public ICommand CardSelectedCommand
        {
            get
            {
                return _cardSelectedCommand ?? new Command<Card>(card =>
                {
                    Navigation.PushAsync(new CardPage(card));
                });
            }
        }
    }
}