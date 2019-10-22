using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Code
{
	public static class LogicAndInterations
	{
		public static int For_SumTwoListsAndAllValueThatAreNotFour(int[] numberArray, List<int> numberList)
		{
            int result = 0;
            for(int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] != 4)
                {
                    result += numberArray[i];
                }
            }
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] != 4)
                {
                    result += numberList[i];
                }
            }
            return result;
        }

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            int result = 0;
            foreach (var number in numberList)
            {
                if (number != 4)
                {
                    result += number;
                }
            }
            return result;
        }

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int result = 0;
            int current = 0;
            int i = 0;
            do
            {
                current = numberList[i];
                result += current;
                i++;

            } while (current != 4 && i < numberList.Count);
            return result;
		}

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int result = 0;
            int current = 0;
            int i = 0;
            while(current != 4 && i < numberList.Count)
            {
                current = numberList[i];
                result += current;
                i++;
            }
            return result;
        }

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            int result = 0;
            var notfour = from number in numberList
                          where number != 4
                          select number;
            foreach (var i in notfour)
            {
                result += i;
            }
            return result;
        }
	}
}