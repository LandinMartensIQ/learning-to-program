using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;

namespace PokerChallenge2Tests
{
    public static class SamplePokerRounds
    {
        public static PokerRound ReturnStandardExample1()
        {
            var player1 = new Player("Joe")
            {
                Hand = new PokerHand(SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree())
            };
            var player2 = new Player("Jen")
            {
                Hand = new PokerHand(SampleCardLists.ReturnStandardExample1_JensHand_ThreeOfAKind_TenEightThreeThreeThree())
            };
            var player3 = new Player("Bob")
            {
                Hand = new PokerHand(SampleCardLists.ReturnStandardExample1_BobsHand_HighCard_AceTenSevenFiveTwo())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnStandardExample2()
        {
            var player1 = new Player("Joe")
            {
                Hand = new PokerHand(SampleCardLists.ReturnStandardExample2_JoesHand_Pair_QueenNineNineFourThree())
            };
            var player2 = new Player("Jen")
            {
                Hand = new PokerHand(SampleCardLists.ReturnStandardExample2_JensHand_Pair_QueenNineNineSevenFive())
            };
            var player3 = new Player("Bob")
            {
                Hand = new PokerHand(SampleCardLists.ReturnStandardExample2_BobsHand_Pair_AceTenFiveTwoTwo())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnHighCardExample()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_HighCard1_WorstHighCard_SevenFiveFourThreeTwo())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_HighCard4_BestHighCard_AceKingQueenJackNine())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_HighCard3_TieHighCard_AceJackTenEightSeven())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnHighCardExample_TieRound()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_HighCard1_WorstHighCard_SevenFiveFourThreeTwo())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_HighCard2_TieHighCard_AceJackTenEightSeven())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_HighCard3_TieHighCard_AceJackTenEightSeven())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }
        
        public static PokerRound ReturnOnePairExample()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_OnePair4_BestPair_AceAceKingQueenJack())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_OnePair2_TiePair_AceJackTenSevenSeven())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_OnePair1_WorstOnePair_TwoTwoThreeFourFive())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnOnePairExample_TieRound()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_OnePair2_TiePair_AceJackTenSevenSeven())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_OnePair3_TiePair_AceJackTenSevenSeven())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_OnePair1_WorstOnePair_TwoTwoThreeFourFive())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnThreeOfAKindExample()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_ThreeOfAKind1_WorstThree_FourThreeTwoTwoTwo())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_ThreeOfAKind2_TieThree_JackEightEightEightFive())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_ThreeOfAKind4_BestThree_AceAceAceKingQueen())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnThreeOfAKindExample_TieRound()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_ThreeOfAKind1_WorstThree_FourThreeTwoTwoTwo())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_ThreeOfAKind2_TieThree_JackEightEightEightFive())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_ThreeOfAKind3_TieThree_JackEightEightEightFive())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnFlushExample()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_Flush1_WorstFlush_TwoThreeFourFiveSeven())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_Flush2_TieFlush_AceKingJackTenThree())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_Flush4_BestFlush_AceKingJackQueenThree())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }

        public static PokerRound ReturnFlushExample_TieRound()
        {
            var player1 = new Player("player1")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_Flush1_WorstFlush_TwoThreeFourFiveSeven())
            };
            var player2 = new Player("player2")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_Flush2_TieFlush_AceKingJackTenThree())
            };
            var player3 = new Player("player3")
            {
                Hand = new PokerHand(SampleCardLists.ReturnExample_Flush3_TieFlush_AceKingJackTenThree())
            };
            var round = new PokerRound()
            {
                Players =
                {
                    player1,
                    player2,
                    player3
                }
            };
            return round;
        }
    }
}
