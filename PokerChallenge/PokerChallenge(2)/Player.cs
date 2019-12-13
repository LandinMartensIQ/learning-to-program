using PokerChallenge2;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerChallenge2
{
    public class Player
    {
        public string Name { get; set; }
        public PokerHand Hand { get; set; } = new PokerHand();
        public Player()
        {
            Name = "Anonymous";
        }
        public Player(string name)
        {
            Name = name;
        }
    }
}
