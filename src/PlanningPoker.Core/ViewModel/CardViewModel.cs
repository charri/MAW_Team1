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
        private bool _showBack = true;

        public Card Card
        {
            get { return _card; }
            set { SetProperty(ref _card, value); }
        }

        public bool ShowBack
        {
            get { return _showBack; }
            set
            {
                SetProperty(ref _showBack, value);
                OnPropertyChanged(nameof(ShowFront));
            }
        }

        public bool ShowFront
        {
            get { return !_showBack; }
        }

        
        public ICommand ShowFrontCommand
        {
            get { return new Command(() => ShowBack = false);}
        }

        public CardViewModel(INavigation navigation, Card card)
            : base(navigation)
        {
            Card = card;
        }

    }
}
