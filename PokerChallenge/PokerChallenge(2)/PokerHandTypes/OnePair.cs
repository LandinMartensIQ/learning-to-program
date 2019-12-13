using PokerChallenge2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerChallenge2
{
    public static class OnePair
    {
        public static bool IsOnePair(this PokerHand hand)
        {
            var result = false;

            foreach(var card in hand.Cards)
            {
                if(hand.Cards.Where(c => c.Value == card.Value).Count() == 2)
                {
                    result = true;
                }
            }

            return result;
        }
        public static List<Player> BreakTie(List<Player> players)
        {
            var result = BreakTieByPairValue(players);

            if(result.Count == 1)
            {
                return result;
            }

            result = HighCard.BreakTie(result);

            return result;
        }
        private static List<Player> BreakTieByPairValue(List<Player> players)
        {
            var result = new List<Player>() { players[0] };

            var bestPair = ReturnPairValue(players[0].Hand);

            for (var i = 1; i < players.Count; i++)
            {
                var handPair = ReturnPairValue(players[i].Hand);
                if (handPair > bestPair)
                {
                    result = new List<Player>() { players[i] };
                    bestPair = handPair;
                }
                else if (handPair == bestPair)
                {
                    result.Add(players[i]);
                }
            }

            return result;
        }
        private static CardValue ReturnPairValue(PokerHand hand)
        {
            var result = CardValue.Two;

            foreach(var card in hand.Cards)
            {
                if (hand.Cards.Where(c => c.Value == card.Value).Count() == 2)
                {
                    result = card.Value;
                }
            }

            return result;
        }
    }
}
