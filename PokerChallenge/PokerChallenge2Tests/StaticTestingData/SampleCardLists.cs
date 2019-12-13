using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;

namespace PokerChallenge2Tests
{
    public static class SampleCardLists
    {
        public static List<Card> ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Three),
                new Card(CardSuit.Hearts, CardValue.Six),
                new Card(CardSuit.Hearts, CardValue.Eight),
                new Card(CardSuit.Hearts, CardValue.Jack),
                new Card(CardSuit.Hearts, CardValue.King)
            };
        }

        public static List<Card> ReturnStandardExample1_JensHand_ThreeOfAKind_TenEightThreeThreeThree()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Three),
                new Card(CardSuit.Diamonds, CardValue.Three),
                new Card(CardSuit.Spades, CardValue.Three),
                new Card(CardSuit.Clubs, CardValue.Eight),
                new Card(CardSuit.Diamonds, CardValue.Ten)
            };
        }

        public static List<Card> ReturnStandardExample1_BobsHand_HighCard_AceTenSevenFiveTwo()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Two),
                new Card(CardSuit.Clubs, CardValue.Five),
                new Card(CardSuit.Spades, CardValue.Seven),
                new Card(CardSuit.Clubs, CardValue.Ten),
                new Card(CardSuit.Clubs, CardValue.Ace)
            };
        }

        public static List<Card> ReturnStandardExample2_JoesHand_Pair_QueenNineNineFourThree()
        {
            return new List<Card>()
            {   new Card(CardSuit.Hearts, CardValue.Three),
                new Card(CardSuit.Diamonds, CardValue.Four),
                new Card(CardSuit.Clubs, CardValue.Nine),
                new Card(CardSuit.Diamonds, CardValue.Nine),
                new Card(CardSuit.Hearts, CardValue.Queen)
            };
        }

        public static List<Card> ReturnStandardExample2_JensHand_Pair_QueenNineNineSevenFive()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Five),
                new Card(CardSuit.Diamonds, CardValue.Seven),
                new Card(CardSuit.Hearts, CardValue.Nine),
                new Card(CardSuit.Spades, CardValue.Nine),
                new Card(CardSuit.Spades, CardValue.Queen)
            };
        }

        public static List<Card> ReturnStandardExample2_BobsHand_Pair_AceTenFiveTwoTwo()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Two),
                new Card(CardSuit.Spades, CardValue.Two),
                new Card(CardSuit.Spades, CardValue.Five),
                new Card(CardSuit.Clubs, CardValue.Ten),
                new Card(CardSuit.Hearts, CardValue.Ace)
            };
        }

        public static List<Card> ReturnExample_HighCard1_WorstHighCard_SevenFiveFourThreeTwo()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Seven),
                new Card(CardSuit.Spades, CardValue.Two),
                new Card(CardSuit.Spades, CardValue.Four),
                new Card(CardSuit.Clubs, CardValue.Three),
                new Card(CardSuit.Hearts, CardValue.Five)
            };
        }

        public static List<Card> ReturnExample_HighCard2_TieHighCard_AceJackTenEightSeven()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Seven),
                new Card(CardSuit.Spades, CardValue.Ace),
                new Card(CardSuit.Spades, CardValue.Ten),
                new Card(CardSuit.Clubs, CardValue.Eight),
                new Card(CardSuit.Hearts, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_HighCard3_TieHighCard_AceJackTenEightSeven()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Seven),
                new Card(CardSuit.Hearts, CardValue.Ace),
                new Card(CardSuit.Hearts, CardValue.Ten),
                new Card(CardSuit.Diamonds, CardValue.Eight),
                new Card(CardSuit.Clubs, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_HighCard4_BestHighCard_AceKingQueenJackNine()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Queen),
                new Card(CardSuit.Hearts, CardValue.King),
                new Card(CardSuit.Hearts, CardValue.Nine),
                new Card(CardSuit.Diamonds, CardValue.Ace),
                new Card(CardSuit.Clubs, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_OnePair1_WorstOnePair_TwoTwoThreeFourFive()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Two),
                new Card(CardSuit.Hearts, CardValue.Three),
                new Card(CardSuit.Hearts, CardValue.Four),
                new Card(CardSuit.Diamonds, CardValue.Two),
                new Card(CardSuit.Clubs, CardValue.Five)
            };
        }

        public static List<Card> ReturnExample_OnePair2_TiePair_AceJackTenSevenSeven()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Seven),
                new Card(CardSuit.Hearts, CardValue.Ace),
                new Card(CardSuit.Hearts, CardValue.Ten),
                new Card(CardSuit.Diamonds, CardValue.Seven),
                new Card(CardSuit.Clubs, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_OnePair3_TiePair_AceJackTenSevenSeven()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Seven),
                new Card(CardSuit.Clubs, CardValue.Ace),
                new Card(CardSuit.Clubs, CardValue.Ten),
                new Card(CardSuit.Spades, CardValue.Seven),
                new Card(CardSuit.Hearts, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_OnePair4_BestPair_AceAceKingQueenJack()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.King),
                new Card(CardSuit.Hearts, CardValue.Ace),
                new Card(CardSuit.Hearts, CardValue.Queen),
                new Card(CardSuit.Diamonds, CardValue.Ace),
                new Card(CardSuit.Clubs, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_ThreeOfAKind1_WorstThree_FourThreeTwoTwoTwo()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Two),
                new Card(CardSuit.Hearts, CardValue.Three),
                new Card(CardSuit.Hearts, CardValue.Two),
                new Card(CardSuit.Diamonds, CardValue.Four),
                new Card(CardSuit.Spades, CardValue.Two)
            };
        }

        public static List<Card> ReturnExample_ThreeOfAKind2_TieThree_JackEightEightEightFive()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Eight),
                new Card(CardSuit.Hearts, CardValue.Jack),
                new Card(CardSuit.Hearts, CardValue.Eight),
                new Card(CardSuit.Diamonds, CardValue.Five),
                new Card(CardSuit.Spades, CardValue.Eight)
            };
        }

        public static List<Card> ReturnExample_ThreeOfAKind3_TieThree_JackEightEightEightFive()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Eight),
                new Card(CardSuit.Diamonds, CardValue.Jack),
                new Card(CardSuit.Diamonds, CardValue.Eight),
                new Card(CardSuit.Clubs, CardValue.Five),
                new Card(CardSuit.Clubs, CardValue.Eight)
            };
        }

        public static List<Card> ReturnExample_ThreeOfAKind4_BestThree_AceAceAceKingQueen()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Ace),
                new Card(CardSuit.Hearts, CardValue.King),
                new Card(CardSuit.Hearts, CardValue.Ace),
                new Card(CardSuit.Diamonds, CardValue.Queen),
                new Card(CardSuit.Spades, CardValue.Ace)
            };
        }

        public static List<Card> ReturnExample_Flush1_WorstFlush_TwoThreeFourFiveSeven()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Seven),
                new Card(CardSuit.Clubs, CardValue.Two),
                new Card(CardSuit.Clubs, CardValue.Four),
                new Card(CardSuit.Clubs, CardValue.Three),
                new Card(CardSuit.Clubs, CardValue.Five)
            };
        }

        public static List<Card> ReturnExample_Flush2_TieFlush_AceKingJackTenThree()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Clubs, CardValue.Three),
                new Card(CardSuit.Clubs, CardValue.Ace),
                new Card(CardSuit.Clubs, CardValue.Ten),
                new Card(CardSuit.Clubs, CardValue.King),
                new Card(CardSuit.Clubs, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_Flush3_TieFlush_AceKingJackTenThree()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Three),
                new Card(CardSuit.Hearts, CardValue.Ace),
                new Card(CardSuit.Hearts, CardValue.Ten),
                new Card(CardSuit.Hearts, CardValue.King),
                new Card(CardSuit.Hearts, CardValue.Jack)
            };
        }

        public static List<Card> ReturnExample_Flush4_BestFlush_AceKingJackQueenThree()
        {
            return new List<Card>()
            {
                new Card(CardSuit.Hearts, CardValue.Three),
                new Card(CardSuit.Hearts, CardValue.Ace),
                new Card(CardSuit.Hearts, CardValue.Queen),
                new Card(CardSuit.Hearts, CardValue.King),
                new Card(CardSuit.Hearts, CardValue.Jack)
            };
        }
    }
}
