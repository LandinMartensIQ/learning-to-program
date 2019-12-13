using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerChallenge2
{
    public static class Flush
    {
        public static bool IsFlush(this PokerHand hand)
        {
            var result = false;

            //if( hand.Cards[0].Suit == hand.Cards[1].Suit &&
            //    hand.Cards[1].Suit == hand.Cards[2].Suit &&
            //    hand.Cards[2].Suit == hand.Cards[3].Suit &&
            //    hand.Cards[3].Suit == hand.Cards[5].Suit)
            //{
            //    result = true;
            //}

            var query = hand.Cards.Select(c => c.Suit);

            if (query.Distinct().Count() == 1)
            {
                result = true;
            }

            return result;
        }
        public static List<Player> BreakTie(List<Player> players)
        {
           return HighCard.BreakTie(players);
        }
    }
}
