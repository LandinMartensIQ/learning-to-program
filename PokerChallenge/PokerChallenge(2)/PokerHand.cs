using PokerChallenge2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerChallenge2
{
    public class PokerHand
    {
        public List<Card> Cards { get; set; }
        public HandType Type { get { return EvaluateHand(); } }
        public PokerHand()
        {
            Cards = new List<Card>();
        }
        public PokerHand(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();
        }
        public void SortHand()
        {
            Cards = Cards.OrderByDescending(c => c.Value).ToList();
        }
        private HandType EvaluateHand()
        {
            if(Cards.Count != 5)
            {
                return HandType.Unevaluated;
            }

            var result = HandType.HighCard;

            SortHand();

            //Additional if statements added in definite order for every hand type

            if(this.IsFlush())
            {
                result = HandType.Flush;
            }
            else if(this.IsThreeOfAKind())
            {
                result = HandType.ThreeOfAKind;
            }
            else if(this.IsOnePair())
            {
                result = HandType.OnePair;
            }

            return result;
        }
    }
}
