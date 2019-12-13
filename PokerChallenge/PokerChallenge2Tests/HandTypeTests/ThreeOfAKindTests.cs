using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class ThreeOfAKindTests
    {
        [TestMethod]
        public void ThreeOfAKind_IsThreeOfAKindReturnsTrue_WhenHandIsThreeOfAKind()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JensHand_ThreeOfAKind_TenEightThreeThreeThree();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsThreeOfAKind();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ThreeOfAKind_IsThreeOfAKindReturnsFalse_WhenHandIsNotThreeOfAKinds()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsThreeOfAKind();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ThreeOfAKind_IsThreeOfAKindReturnsFalse_WhenHandIsPair()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample2_JensHand_Pair_QueenNineNineSevenFive();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsThreeOfAKind();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
