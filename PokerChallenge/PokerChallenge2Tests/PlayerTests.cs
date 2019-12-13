using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Player_EmptyConstructor_AssignsDefaultName()
        {
            //Arrange
            var expected = "Anonymous";

            //Act
            var player = new Player();

            //Assert
            Assert.AreEqual(expected, player.Name);
        }

        [TestMethod]
        public void Player_EmptyConstructor_CreatesEmptyCardsList()
        {
            //Arrange
            var expected = 0;

            //Act
            var player = new Player();

            //Assert
            Assert.AreEqual(expected, player.Hand.Cards.Count);
        }

        [TestMethod]
        public void Player_NameInConstructor_AssignsName()
        {
            //Arrange
            var inputName = "Steve";

            //Act
            var player = new Player(inputName);

            //Assert
            Assert.AreEqual(inputName, player.Name);
        }

        [TestMethod]
        public void Player_NameInConstructor_CreatesEmptyCardsList()
        {
            //Arrange
            var inputName = "Steve";
            var expected = 0;

            //Act
            var player = new Player(inputName);

            //Assert
            Assert.AreEqual(expected, player.Hand.Cards.Count);
        }

        [TestMethod]
        public void Player_AddHand_CanHoldHand()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree();
            var hand = new PokerHand(cards);

            //Act
            var player = new Player();
            player.Hand = hand;

            //Assert
            Assert.AreEqual(hand, player.Hand);
        }
    }
}
