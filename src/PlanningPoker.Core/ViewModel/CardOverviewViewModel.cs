using System.Windows.Input;
using PlanningPoker.Core.Model;
using PlanningPoker.Core.UI.Pages;
using Xamarin.Forms;

namespace PlanningPoker.Core.ViewModel
{
    public class CardOverviewViewModel
        : ViewModelBase
    {
        public CardOverviewViewModel(INavigation navigation)
            : base(navigation)
        {
            
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