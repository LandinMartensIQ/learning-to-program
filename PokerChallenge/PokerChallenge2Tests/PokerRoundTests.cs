using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerChallenge2;
using PokerChallenge2.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PokerChallenge2Tests
{
    [TestClass]
    public class PokerRoundTests
    {
        [TestMethod]
        public void PokerRound_EvaluateRound_StandardExample1()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnStandardExample1();
            var expectedName = "Joe";
            var expectedCount = 1;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedName, result.First().Name);
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_StandardExample2()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnStandardExample2();
            var expectedName = "Jen";
            var expectedCount = 1;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedName, result.First().Name);
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_HighCardRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnHighCardExample();
            var expectedCount = 1;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);

        }

        [TestMethod]
        public void PokerRound_EvaluateRound_HighCardTieRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnHighCardExample_TieRound();
            var expectedCount = 2;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_OnePairRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnOnePairExample();
            var expectedCount = 1;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_OnePairTieRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnOnePairExample_TieRound();
            var expectedCount = 2;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_ThreeOfAKindRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnThreeOfAKindExample();
            var expectedCount = 1;
            

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_ThreeOfAKindTieRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnThreeOfAKindExample_TieRound();
            var expectedCount = 2;


            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_FlushRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnFlushExample();
            var expectedCount = 1;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void PokerRound_EvaluateRound_FlushTieRound()
        {
            //Arrange
            var round = SamplePokerRounds.ReturnFlushExample_TieRound();
            var expectedCount = 2;

            //Act
            var result = round.EvaluateRound();

            //Assert
            Assert.AreEqual(expectedCount, result.Count);
        }
    }
}
