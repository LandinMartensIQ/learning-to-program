using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Card_HoldsSuitAndValue()
        {
            //Arrange
            var card = new Card(CardSuit.Clubs, CardValue.Ace);
            var expectedSuit = CardSuit.Clubs;
            var expectedValue = CardValue.Ace;

            //Act
            var resultSuit = card.Suit;
            var resultValue = card.Value;

            //Assert
            Assert.AreEqual(expectedSuit, resultSuit);
            Assert.AreEqual(expectedValue, resultValue);
        }
    }
}
