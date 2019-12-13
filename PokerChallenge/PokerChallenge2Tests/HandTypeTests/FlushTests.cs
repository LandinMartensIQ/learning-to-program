using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class FlushTests
    {
        [TestMethod]
        public void Flush_IsFlushReturnsTrue_WhenHandIsFlush()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsFlush();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Flush_IsFlushReturnsFalse_WhenHandIsNotFlushs()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_BobsHand_HighCard_AceTenSevenFiveTwo();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsFlush();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Flush_IsFlushReturnsFalse_WhenHandIsPair()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample2_JensHand_Pair_QueenNineNineSevenFive();
            var hand = new PokerHand(cards);

            //Act
            var result = hand.IsFlush();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
