using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPoker.Core.Model
{
    class FibonnaciDeck : Deck
    {
        public FibonnaciDeck():base()
        {
            Cards.Add(new Card("1"));
            Cards.Add(new Card("2"));
            Cards.Add(new Card("3"));
            Cards.Add(new Card("5"));
            Cards.Add(new Card("8"));
            Cards.Add(new Card("13"));
            Cards.Add(new Card("21"));
            Cards.Add(new Card("34"));
            Cards.Add(new Card("55"));
        }
    }
}
