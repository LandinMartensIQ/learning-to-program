using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class HighCardTests
    {
        [TestMethod]
        public void HighCard_BreakTie_ReturnsWinningPlayer()
        {
            //Arrange
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
                Hand = new PokerHand(SampleCardLists.ReturnExample_HighCard4_BestHighCard_AceKingQueenJackNine())
            };
            var players = new List<Player> { player1, player2, player3 };

            var expectedCount = 1;
            var expectedWinner = player3;

            //Act
            var result = HighCard.BreakTie(players);

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
            Assert.AreEqual(expectedWinner, result[0]);
        }

        [TestMethod]
        public void HighCard_BreakTie_ReturnsTwoWinningPlayers()
        {
            //Arrange
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
            var players = new List<Player> { player1, player2, player3 };

            var expectedCount = 2;
            var expectedWinner1 = player2;
            var expectedWinner2 = player3;

            //Act
            var result = HighCard.BreakTie(players);

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
            Assert.IsTrue(result.Contains(expectedWinner1));
            Assert.IsTrue(result.Contains(expectedWinner2));
        }
    }
}
