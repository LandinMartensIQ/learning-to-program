using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Code
{
	public static class LogicAndInterations
	{
		public static int For_SumTwoListsAndAllValueThatAreNotFour(int[] numberArray, List<int> numberList)
		{
			// using For Loop
			var sumArray = 0;
            var sumList = 0;

            for (int i = 0; i < numberArray.Count(); i++)
			{
				if (numberArray[i] != 4)
                    sumArray += numberArray[i];
			}

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] != 4)
                    sumList += numberList[i];
            }


            //return sumArray + numberList.Where(x => x != 4).Sum();

            return sumArray + sumList;

            // using Linq and storing in a variable
            //var arraySum = numberArray.Where(x => x != 4).Sum();
            //arraySum += numberList.Where(x => x != 4).Sum();
            //return arraySum;

            // using Linq and returning in ONE line
            //return numberArray.Where(x => x != 4).Sum() + numberList.Where(x => x != 4).Sum();
        }

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
			// Foreach Loop
			int sum = 0;
			foreach (int num in numberList)
				if (num != 4)
					sum += num;
			return sum;
		}

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
			//Do While
			int counter = 0;
			int sum = 0;
			bool shouldContinue = true;

			do
			{
				sum += numberList[counter];
				if (numberList[counter] == 4 || (counter + 1) >= numberList.Count)
					shouldContinue = false;
				counter++;
			}
			while (shouldContinue);

			return sum;
		}

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
			//While
			int counter = 0;
			int sum = 0;
			bool shouldContinue = true;

			while (shouldContinue)
			{
				sum += numberList[counter];
				if (numberList[counter] == 4 || (counter + 1) >= numberList.Count)
					shouldContinue = false;
				counter++;
			}

			return sum;
		}

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
			//LINQ
			var result = numberList.Where(x => x != 4).Sum();

			return result;
		}
	}
}
 
 
 
 