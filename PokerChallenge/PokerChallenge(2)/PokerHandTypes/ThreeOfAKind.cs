using PokerChallenge2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerChallenge2
{
    public static class ThreeOfAKind
    {
        public static bool IsThreeOfAKind(this PokerHand hand)
        {
            var result = false;

            foreach(var card in hand.Cards)
            {
                if(hand.Cards.Where(c => c.Value == card.Value).Count() == 3)
                {
                    result = true;
                }
            }

            return result;
        }

        public static List<Player> BreakTie(List<Player> players)
        {
            var result = BreakTieByThreeSetValue(players);

            if (result.Count == 1)
            {
                return result;
            }

            result = HighCard.BreakTie(result);

            return result;
        }

        private static List<Player> BreakTieByThreeSetValue(List<Player> players)
        {
            var result = new List<Player>() { players[0] };

            var bestThree = ReturnThreeOfAKindValue(players[0].Hand);

            for (var i = 1; i < players.Count; i++)
            {
                var handPair = ReturnThreeOfAKindValue(players[i].Hand);
                if (handPair > bestThree)
                {
                    result = new List<Player>() { players[i] };
                    bestThree = handPair;
                }
                else if (handPair == bestThree)
                {
                    result.Add(players[i]);
                }
            }

            return result;
        }

        private static CardValue ReturnThreeOfAKindValue(PokerHand hand)
        {
            var result = CardValue.Two;
            
            foreach (var card in hand.Cards)
            {
                if (hand.Cards.Where(c => c.Value == card.Value).Count() == 3)
                {
                    result = card.Value;
                }
            }

            return result;
        }
    }
}
