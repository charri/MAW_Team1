namespace PlanningPoker.Core.Model
{
    public class Card
    {
        public string Value { get; set; }

        public Card()
        {

        }

        public Card(string value)
        {
            Value = value;
        }
    }
}