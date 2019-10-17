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
			foreach(int num in numberArray)
            {
                if (num != 4)
                {
                    result += num;
                }
            }
            result += ForEach_SumTwoListsAndAllValueThatAreNotFour(numberList);
            return result;
        }

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            int result = 0;
            foreach (int num in numberList)
            {
                if (num != 4)
                {
                    result += num;
                }
            }
            return result;
        }

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int value = 0;
            int sum = 0;
            int counter = 0;
            
            do
            {
                value = numberList[counter];
                sum += value;                
                counter++;
                if (counter == numberList.Count())
                {
                    break;
                }
                
            }
            while (value != 4);
            

            return sum;
        }

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int value = 0;
            int sum = 0;
            int counter = 0;
            while (value != 4)
            {
                value = numberList[counter];
                sum += value;
                counter++;
                if (counter == numberList.Count())
                {
                    break;
                }
            }

            return sum;
		}

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            var query = from num in numberList
                        where num != 4
                        select num;

            return query.Sum();

		}
	}
}
 
 
 
 