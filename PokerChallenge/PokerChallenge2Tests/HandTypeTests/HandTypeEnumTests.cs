using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2.Enums;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class HandTypeEnumTests
    {
        [TestMethod]
        public void HandType_UnevalutatedIs0()
        {
            //Arrange
            var value = HandType.Unevaluated;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void HandType_HighCardIs1()
        {
            //Arrange
            var value = HandType.HighCard;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void HandType_OnePairIs2()
        {
            //Arrange
            var value = HandType.OnePair;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void HandType_TwoPairIs3()
        {
            //Arrange
            var value = HandType.TwoPair;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void HandType_ThreeOfAKindIs4()
        {
            //Arrange
            var value = HandType.ThreeOfAKind;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void HandType_StraightIs5()
        {
            //Arrange
            var value = HandType.Straight;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void HandType_FlushIs6()
        {
            //Arrange
            var value = HandType.Flush;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void HandType_FullHouseIs7()
        {
            //Arrange
            var value = HandType.FullHouse;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void HandType_FourOfAKindIs8()
        {
            //Arrange
            var value = HandType.FourOfAKind;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void HandType_StraightFlushIs9()
        {
            //Arrange
            var value = HandType.StraightFlush;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void HandType_RoyalFlushIs10()
        {
            //Arrange
            var value = HandType.RoyalFlush;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(10, result);
        }
    }
}
