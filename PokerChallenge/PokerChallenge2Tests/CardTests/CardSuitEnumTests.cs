using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2.Enums;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class CardSuitEnumTests
    {
        [TestMethod]
        public void CardSuit_HeartsIs0()
        {
            //Arrange
            var hearts = CardSuit.Hearts;

            //Act
            var result = (int)hearts;

            //Assert
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void CardSuit_SpadesIs1()
        {
            //Assert
            var spades = CardSuit.Spades;
            
            //Act
            var result = (int)spades;

            //Assert
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void CardSuit_DiamondsIs2()
        {
            //Assert
            var diamonds = CardSuit.Diamonds;
            
            //Act
            var result = (int)diamonds;

            //Assert
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void CardSuit_ClubsIs3()
        {
            //Assert
            var clubs = CardSuit.Clubs;
            
            //Act
            var result = (int)clubs;

            //Assert
            Assert.IsTrue(result == 3);
        }
    }
}
