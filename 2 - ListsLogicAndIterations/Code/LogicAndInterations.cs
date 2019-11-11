using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Code
{
	public static class LogicAndInterations
	{
		public static int For_SumTwoListsAndAllValueThatAreNotFour(int[] numberArray, List<int> numberList)
		{
            var sum = 0;
            for (var i = 0; i < numberArray.Length; i++)
            {
                var number = numberArray[i];   
                if (number !=4)
                {
                    sum = sum + number;
                }
            }
            for (var i = 0; i < numberList.Count; i++)
            {
                var number = numberList[i];
                if (number != 4)
                {
                    sum = sum + number;
                }
            }
            return sum;
		}

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            var sum = 0;

			foreach (var number in numberList)
            {
                if (number !=4)
                {
                    sum = sum + number;
                }
            }
            return sum;
		}

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            var index = 0;
            var sum = 0;
            var currentValue = 0;
            do
            {
                currentValue = numberList[index];
                sum = sum + numberList[index];
                index++;
            }
            while (index < numberList.Count && currentValue !=4);
            return sum;
        }

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            var index = 0;
            var sum = 0;
            var currentValue = 0;
            while (index < numberList.Count && currentValue != 4) 
            {
                currentValue = numberList[index];
                sum = sum + numberList[index];
                index++;
            }
            
            return sum;
        }

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            return numberList.Where(number => number != 4).Sum();

		}
	}
}
 
 
 
 