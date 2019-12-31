using Microsoft.VisualStudio.TestTools.UnitTesting;
using Builder;

namespace CharacterBuilderTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void ValidateStep1_HappyPath()
            {
            var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "very fit", "7'1");
                newInput.ValidateStep2(10, 10, 10, 10, 10, 10);
                Assert.AreEqual("Character made", newInput.ValidationMessage);
            }

            [TestMethod]
            public void ValidateStep1_HeadBelow0()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(-5, "very fit", "7");
                Assert.AreEqual("Head roundness cannot be below 0%", newInput.ValidationMessage);
            }

            [TestMethod]
            public void ValidateStep1_HeadAbove100()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(105, "very fit", "7'1");
                Assert.AreEqual("Head roundness cannot be above 100%", newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_BadFitness()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "very unfit", "7'1");
                Assert.AreEqual("This is not a valid fitness type", newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_ExtremelyFit()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "extremely fit", "7'1");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }

            [TestMethod]
            public void ValidateStep1_VeryFit()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "very fit", "7'1");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_SomewhatFit()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "somewhat fit", "7'1");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_NotFit()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "not fit", "7'1");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_FarFromFit()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "far from fit", "7'1");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_JustFeet()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "far from fit", "7");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_BadFeet()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "far from fit", "-7");
                Assert.AreEqual("This is an invalid height", newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_BadHeight()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "far from fit", "abc");
                Assert.AreEqual("This is an invalid height", newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_ReduceInches()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "far from fit", "7'13");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }
            [TestMethod]
            public void ValidateStep1_0InchCheck()
            {
                var newInput = new ValidateCharacter();
                newInput.ValidatedStep1(55, "far from fit", "7'0");
                Assert.AreEqual(null, newInput.ValidationMessage);
            }
        }
    }
