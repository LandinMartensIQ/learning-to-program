using PokerChallenge2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerChallenge2
{
    public class Card
    {
        public CardSuit Suit { get;  set; }
        public CardValue Value { get;  set; }
        public Card(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
