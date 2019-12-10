//using System;
//using System.Collections.Generic;
//using System.Text;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json;
//using System.IO;
//using Characters;

//namespace DiskOperations
//{
//    public static class DirectOperations
//    {
//        public static bool WriteToDisk(string contents, string filePath)
//        {
//            try
//            {
//                System.IO.File.WriteAllText(filePath, contents);
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        public static JObject LoadFromDisk(string filePath)
//        {
//            try
//            {
//                var textString = System.IO.File.ReadAllText(@"c:\temp\character.json");
//                return JObject.Parse(textString);
//            }
//            catch
//            {
//                //errors reading or parsing file
//                return null;
//            }
//        }

//    }
//    public static class Character
//    {
//        public static bool Save(Characters.Character myChar)
//        {
//            var temp=JsonConvert.SerializeObject(myChar);

//            return DirectOperations.WriteToDisk(temp, @"c:\temp\character.json");
//        }

       

//        public static Characters.Character Load()
//        {
//            JObject jsonData = DirectOperations.LoadFromDisk(@"c:\temp\character.json");
            
//            if (jsonData is null)
//            {
//                return null;
//            }

//            var head = (int)jsonData["headShape"];
//            var height = (string)jsonData["stringHeight"];
//            var fitness=Enum.Parse(typeof(Characters.FitnessLevel),(string)jsonData["fitnessLevel"]);
            
//            Characters.AbilityPoints abilityPoints = new Characters.AbilityPoints();
//            JObject abilityData=(JObject)jsonData["AbilityStats"];
//            abilityPoints.charisma = (int)abilityData["charisma"];
//            abilityPoints.constitution= (int)abilityData["constitution"];
//            abilityPoints.dexterity= (int)abilityData["dexterity"];
//            abilityPoints.intelligence= (int)abilityData["intelligence"];
//            abilityPoints.strength= (int)abilityData["strength"];
//            abilityPoints.wisdom= (int)abilityData["wisdom"];

//            Characters.CharacterBuilder newBuilder = new Characters.CharacterBuilder();
//            var fixedHeight=Utilities.convertFeetAndInchestoInt(height);
//            try
//            {
//                return newBuilder.BuildCharacter(head, (Characters.FitnessLevel)fitness, fixedHeight, abilityPoints);
//            }
//            catch
//            {
//                //errors because the loaded stats can't be used to create a new character
//                return null;
//            }
//        }        
//    }
//}
