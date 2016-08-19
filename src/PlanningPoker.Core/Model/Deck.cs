using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPoker.Core.Model
{
    public class Deck
    {
        private List<Card> _cards;

        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
        }
        public void Add(Card card)
        {
            _cards.Add(card);
        }
    }
}
