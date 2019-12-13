using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class PairTests
    {
        [TestMethod]
        public void Pair_IsPairReturnsTrue_WhenHandIsPair()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample2_JensHand_Pair_QueenNineNineSevenFive();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsOnePair();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Pair_IsPairReturnsFalse_WhenHandHasNoPairs()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsOnePair();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Pair_IsPairReturnsFalse_WhenHandIsThreeOfAKind()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JensHand_ThreeOfAKind_TenEightThreeThreeThree();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsOnePair();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
