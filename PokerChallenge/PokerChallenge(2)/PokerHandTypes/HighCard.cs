using PokerChallenge2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerChallenge2
{
    public static class HighCard
    {
        public static List<Player> BreakTie(List<Player> players)
        {
            var result = new List<Player>();

            foreach(var player in players)
            {
                player.Hand.SortHand();
            }

            for(var i = 0; i < 5; i++)
            {
                //The purpose of this if statement is a round resetter that should only execute after the first round
                if(i > 0)
                {
                    players = result.ToList();
                    result = new List<Player>();
                }
                
                var highCardValue = CardValue.Two;

                foreach (var player in players)
                {
                    if (player.Hand.Cards[i].Value > highCardValue)
                    {
                        result = new List<Player>() { player };
                        highCardValue = player.Hand.Cards[i].Value;
                    }
                    else if (player.Hand.Cards[i].Value == highCardValue)
                    {
                        result.Add(player);
                    }
                }
                if(result.Count == 1)
                {
                    break;
                }
            }

            return result;
        }
    }
}
