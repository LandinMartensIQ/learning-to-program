using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class PokerHandTests
    {
        [TestMethod]
        public void PokerHand_EmptyConstructor_EmptyListOfCards()
        {
            //Arrange
            var expected = 0;

            //Act
            var hand = new PokerHand();

            //Assert
            Assert.AreEqual(expected, hand.Cards.Count);
        }

        [TestMethod]
        public void PokerHand_5CardsInConstructor_ListContains5Cards()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree();
            var expectedCount = 5;

            //Act
            var hand = new PokerHand(cards);

            //Assert
            Assert.AreEqual(expectedCount, hand.Cards.Count);
        }

        [TestMethod]
        public void PokerHand_5CardsInConstructor_ListContainsCorrectCards()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree();
            var expectedCard1 = cards[0];
            var expectedCard2 = cards[1];
            var expectedCard3 = cards[2];
            var expectedCard4 = cards[3];
            var expectedCard5 = cards[4];

            //Act
            var hand = new PokerHand(cards);

            //Assert

            Assert.IsTrue(hand.Cards.Contains(expectedCard1));
            Assert.IsTrue(hand.Cards.Contains(expectedCard2));
            Assert.IsTrue(hand.Cards.Contains(expectedCard3));
            Assert.IsTrue(hand.Cards.Contains(expectedCard4));
            Assert.IsTrue(hand.Cards.Contains(expectedCard5));

            Assert.AreEqual(1, hand.Cards.Where(c => c.Suit == expectedCard1.Suit && c.Value == expectedCard1.Value).Count());
            Assert.AreEqual(1, hand.Cards.Where(c => c.Suit == expectedCard2.Suit && c.Value == expectedCard2.Value).Count());
            Assert.AreEqual(1, hand.Cards.Where(c => c.Suit == expectedCard3.Suit && c.Value == expectedCard3.Value).Count());
            Assert.AreEqual(1, hand.Cards.Where(c => c.Suit == expectedCard4.Suit && c.Value == expectedCard4.Value).Count());
            Assert.AreEqual(1, hand.Cards.Where(c => c.Suit == expectedCard5.Suit && c.Value == expectedCard5.Value).Count());
        }

        [TestMethod]
        public void PokerHand_Evaluate_FourCardsReturnsUnevaluted()
        {
            //Arrange
            var card1 = new Card(CardSuit.Clubs, CardValue.Two);
            var card2 = new Card(CardSuit.Diamonds, CardValue.Two);
            var card3 = new Card(CardSuit.Hearts, CardValue.Two);
            var card4 = new Card(CardSuit.Spades, CardValue.Two);
            var cards = new List<Card>() { card1, card2, card3, card4 };
            var expectedType = HandType.Unevaluated;

            //Act
            var hand = new PokerHand(cards);

            //Assert
            Assert.AreEqual(expectedType, hand.Type);
        }

        [TestMethod]
        public void PokerHand_Evaluate_SixCardsReturnsUnevaluted()
        {
            //Arrange
            var card1 = new Card(CardSuit.Clubs, CardValue.Two);
            var card2 = new Card(CardSuit.Diamonds, CardValue.Two);
            var card3 = new Card(CardSuit.Hearts, CardValue.Two);
            var card4 = new Card(CardSuit.Spades, CardValue.Two);
            var card5 = new Card(CardSuit.Hearts, CardValue.Three);
            var card6 = new Card(CardSuit.Spades, CardValue.Three);
            var cards = new List<Card>() { card1, card2, card3, card4, card5, card6 };
            var expectedType = HandType.Unevaluated;

            //Act
            var hand = new PokerHand(cards);

            //Assert
            Assert.AreEqual(expectedType, hand.Type);
        }

        [TestMethod]
        public void PokerHand_Evaluate_ReturnsFlushForFlush()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JoesHand_Flush_KingJackEightSixThree();
            var expectedType = HandType.Flush;

            //Act
            var hand = new PokerHand(cards);

            //Assert
            Assert.AreEqual(expectedType, hand.Type);
        }

        [TestMethod]
        public void PokerHand_Evaluate_ReturnsOnePairForOnePair()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample2_JensHand_Pair_QueenNineNineSevenFive();
            var expectedType = HandType.OnePair;

            //Act
            var hand = new PokerHand(cards);

            //Assert
            Assert.AreEqual(expectedType, hand.Type);
        }

        [TestMethod]
        public void PokerHand_Evaluate_ReturnsThreeOfAKindForThreeOfAKind()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_JensHand_ThreeOfAKind_TenEightThreeThreeThree();
            var expectedType = HandType.ThreeOfAKind;

            //Act
            var hand = new PokerHand(cards);

            //Assert
            Assert.AreEqual(expectedType, hand.Type);
        }

        [TestMethod]
        public void PokerHand_Evaluate_ReturnsHighCardForHighCard()
        {
            //Arrange
            var cards = SampleCardLists.ReturnStandardExample1_BobsHand_HighCard_AceTenSevenFiveTwo();
            var expectedType = HandType.HighCard;

            //Act
            var hand = new PokerHand(cards);

            //Assert
            Assert.AreEqual(expectedType, hand.Type);
        }
        
        [TestMethod]
        public void PokerHand_SortHand()
        {
            //Arrange
            var card1 = new Card(CardSuit.Hearts, CardValue.Three);
            var card2 = new Card(CardSuit.Hearts, CardValue.Six);
            var card3 = new Card(CardSuit.Hearts, CardValue.Eight);
            var card4 = new Card(CardSuit.Hearts, CardValue.Jack);
            var card5 = new Card(CardSuit.Hearts, CardValue.Two);
            var cards = new List<Card>() { card1, card2, card3, card4, card5 };
            var hand = new PokerHand(cards);

            //Act
            hand.SortHand();

            //Assert
            Assert.AreEqual(CardValue.Jack, hand.Cards[0].Value);
            Assert.AreEqual(CardValue.Eight, hand.Cards[1].Value);
            Assert.AreEqual(CardValue.Six, hand.Cards[2].Value);
            Assert.AreEqual(CardValue.Three, hand.Cards[3].Value);
            Assert.AreEqual(CardValue.Two, hand.Cards[4].Value);
        }

        [TestMethod]
        public void PokerHand_SortHand_CheckingTypeSortsHand()
        {
            //Arrange
            var card1 = new Card(CardSuit.Hearts, CardValue.Three);
            var card2 = new Card(CardSuit.Hearts, CardValue.Six);
            var card3 = new Card(CardSuit.Hearts, CardValue.Eight);
            var card4 = new Card(CardSuit.Hearts, CardValue.Jack);
            var card5 = new Card(CardSuit.Hearts, CardValue.Two);
            var cards = new List<Card>() { card1, card2, card3, card4, card5 };
            var hand = new PokerHand(cards);

            //Act
            var x = hand.Type;

            //Assert
            Assert.AreEqual(CardValue.Jack, hand.Cards[0].Value);
            Assert.AreEqual(CardValue.Eight, hand.Cards[1].Value);
            Assert.AreEqual(CardValue.Six, hand.Cards[2].Value);
            Assert.AreEqual(CardValue.Three, hand.Cards[3].Value);
            Assert.AreEqual(CardValue.Two, hand.Cards[4].Value);
        }
    }
}
