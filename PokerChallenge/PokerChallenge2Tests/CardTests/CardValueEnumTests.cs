using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2.Enums;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class CardValueEnumTests
    {
        [TestMethod]
        public void CardValue_TwoIs2()
        {
            //Arrange
            var value = CardValue.Two;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CardValue_ThreeIs3()
        {
            //Arrange
            var value = CardValue.Three;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CardValue_FourIs4()
        {
            //Arrange
            var value = CardValue.Four;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CardValue_FiveIs5()
        {
            //Arrange
            var value = CardValue.Five;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CardValue_SixIs6()
        {
            //Arrange
            var value = CardValue.Six;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void CardValue_SevenIs7()
        {
            //Arrange
            var value = CardValue.Seven;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void CardValue_EightIs8()
        {
            //Arrange
            var value = CardValue.Eight;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void CardValue_NineIs9()
        {
            //Arrange
            var value = CardValue.Nine;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void CardValue_TenIs10()
        {
            //Arrange
            var value = CardValue.Ten;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void CardValue_JackIs11()
        {
            //Arrange
            var value = CardValue.Jack;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void CardValue_QueenIs12()
        {
            //Arrange
            var value = CardValue.Queen;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void CardValue_KingIs13()
        {
            //Arrange
            var value = CardValue.King;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void CardValue_AceIs14()
        {
            //Arrange
            var value = CardValue.Ace;

            //Act
            var result = (int)value;

            //Assert
            Assert.AreEqual(14, result);
        }
    }
}
