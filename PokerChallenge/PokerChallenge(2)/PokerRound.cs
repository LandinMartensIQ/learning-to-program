using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PokerChallenge2.Enums;

namespace PokerChallenge2
{
    public class PokerRound
    {
        public List<Player> Players = new List<Player>();
        public List<Player> EvaluateRound()
        {
            var result = new List<Player>();
            var maxHandType = Players.OrderByDescending(p => p.Hand.Type).Select(p => p.Hand.Type).First();
            var maxHandTypePlayers = Players.Where(p => p.Hand.Type == maxHandType).ToList();

            if (maxHandTypePlayers.Count == 1)
            {
                result = maxHandTypePlayers;
            }
            else
            {
                result = BreakTieByHandType(maxHandType, maxHandTypePlayers);
            }

            return result;
        }
        private List<Player> BreakTieByHandType(HandType maxHandType, List<Player> players)
        {
            var result = new List<Player>();

            switch (maxHandType)
            {
                case HandType.HighCard:
                    result = HighCard.BreakTie(players);
                    break;
                case HandType.OnePair:
                    result = OnePair.BreakTie(players);
                    break;
                case HandType.ThreeOfAKind:
                    result = ThreeOfAKind.BreakTie(players);
                    break;
                case HandType.Flush:
                    result = Flush.BreakTie(players);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
