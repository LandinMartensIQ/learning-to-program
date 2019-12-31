using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Builder
{
    public class ValidateCharacter
    {
            public int HeadRoundness { get; private set; }
            public string FitnessLevel { get; private set; }
            public Height Height { get; private set; }
            public int Intelligence { get; private set; }
            public int Wisdom { get; private set; }
            public int Dexterity { get; private set; }
            public int Strength { get; private set; }
            public int Charisma { get; private set; }
            public int Constitution { get; private set; }

            private string _validationMessage;

            public string ValidationMessage
            {
                get { return _validationMessage; }
                set
                {
                    if (_validationMessage == null)
                    {
                        _validationMessage += value;
                    }
                    else
                    {
                        _validationMessage += Environment.NewLine + value;
                    }
                }
            }

            public void ValidatedStep1(int headRoundness, string fitness, string height)
            {
                ValidateHeadRoundness(headRoundness);
                ValidateFitness(fitness);
                ValidateHeight(height);
            }
            public void ValidateHeadRoundness(int headRoundness)
            {
                if (headRoundness > 100)
                {
                    ValidationMessage = "Head roundness cannot be above 100%";
                }
                else if (headRoundness < 0)
                {
                    ValidationMessage = "Head roundness cannot be below 0%";
                }
                else
                {
                    HeadRoundness = headRoundness;
                }
            }

            public void ValidateFitness(string fitness)
            {
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                string fitnessCheck = myTI.ToTitleCase(fitness);
                //string fitnessCheck="";
                foreach (char character in fitness)
                {
                    fitnessCheck = string.Join("", fitnessCheck.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                }
                if (Enum.IsDefined(typeof(FitnessLevel), fitnessCheck))
                {
                    FitnessLevel = fitness;
                }
                else
                {
                    ValidationMessage = "This is not a valid fitness type";
                }
            }


            public void ValidateHeight(string height)
            {
            var Height = new Height();
                var size = height.Split('\'').Select(a => a.Trim()).ToArray();
                if (size.Length == 1 && int.TryParse(size[0], out var foot))
                {
                    int numfoot = Convert.ToInt32(foot);
                    if (foot > 0)
                    {
                        Height.Feet = foot;
                        Height.Inches = 0;
                    }
                    else
                    {
                        ValidationMessage = "This is an invalid height";
                    }
                }
                else if (size.Length == 2 && int.TryParse(size[0], out var feet) && int.TryParse(size[1], out var inches))
                {
                    if (feet > 0 && inches >= 0)
                    {
                        while (inches >= 12)
                        {
                            inches -= 12;
                            feet++;
                        }
                        Height.Feet = feet;
                        Height.Inches = inches;
                    }
                    else
                    {
                        ValidationMessage = "This is an invalid height";
                    }
                }
                else
                {
                    ValidationMessage = "This is an invalid height";
                }

            }
            public void ValidateIntelligence(int value)
            {
                if (value < 5)
                {
                    ValidationMessage = "Intelligence is set too low, it must be at least 5";
                }
                else if (value > 20)
                {
                    ValidationMessage = "Intelligence is set above the maximum value of 20";
                }
                else
                {
                    Intelligence = value;                  
                }
            }

            public void ValidateWisdom(int value)
            {
                if (value < 5)
                {
                    ValidationMessage = "Wisdom is set too low, it must be at least 5";
                }
                else if (value > 20)
                {
                    ValidationMessage = "Wisdom is set above the maximum value of 20";
                }
                else
                {
                    Wisdom = value;
                }
            }

            public void ValidateDexterity(int value)
            {
                if (value < 1)
                {
                    ValidationMessage = "Dexterity is set too low, it must be at least 1";
                }
                else if (value > 20)
                {
                    ValidationMessage = "Dexterity is set above the maximum value of 20";
                }
                else
                {
                    Dexterity = value;
                }
            }

            public void ValidateStrength(int value)
            {
                if (value < 1)
                {
                    ValidationMessage = "Strength is set too low, it must be at least 1";
                }
                else if (value > 20)
                {
                    ValidationMessage = "Strength is set above the maximum value of 20";
                }
                else
                {
                    Strength = value;
                }
            }

            public void ValidateCharisma(int value)
            {
                if (value < 0)
                {
                    ValidationMessage = "Charisma is set too low, it must be at least 0";
                }
                else if (value > 20)
                {
                    ValidationMessage = "Charisma is set above the maximum value of 20";
                }
                else
                {
                    Charisma = value;
                }
            }

            public void ValidateConstitution(int value)
            {
                if (value < 10)
                {
                    ValidationMessage = "Constitution is set too low, it must be at least 10";
                }
                else if (value > 20)
                {
                    ValidationMessage = "Constitution is set above the maximum value of 20";
                }
                else
                {
                    Constitution = value;
                }
            }


            public void ValidateStep2(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
            {
                ValidateIntelligence(intelligence);
                ValidateWisdom(wisdom);
                ValidateDexterity(dexterity);
                ValidateStrength(strength);
                ValidateCharisma(charisma);
                ValidateConstitution(constitution);
                if (intelligence + wisdom + dexterity + strength + charisma + constitution != 60)
                {
                    ValidationMessage = "Your bases stats do not add to 60";
                }
                if (ValidationMessage == null)
                {
                    ValidationMessage = "Character made";
                }
            
        }
    }
}