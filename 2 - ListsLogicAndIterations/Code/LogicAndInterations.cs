using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Code
{
	public static class LogicAndInterations
	{
		public static int For_SumTwoListsAndAllValueThatAreNotFour(int[] numberArray, List<int> numberList)
		{
            int sum = 0;
            for (int interval=0; interval< numberList.Count; interval++)
            {
                if(numberList[interval]!=4)
                    {
                    sum += numberList[interval];
                }
            }
            for (int interval = 0; interval < numberArray.Length; interval++)
            {
                if (numberArray[interval] != 4)
                {
                    sum += numberArray[interval];
                }
            }

            //other ways I found out how to do it before realizing you wanted a for loop
            //int sum=0;
            //foreach (var number in numberArray.Where(e => !e.Equals(4))) sum += number;
            //foreach (var number in numberList.Where(e => !e.Equals(4))) sum += number;

            //foreach (int number in numberArray) { if (number != 4) sum += number; }
            //foreach (int number in numberList) { if (number != 4) sum += number; }

            return sum;
		}

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            int sum = 0;
            foreach (var number in numberList.Where(e => !e.Equals(4))) sum += number;
            return sum;
		}

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int sum=0;
            int increment = 0;
            do
            {
                sum += numberList[increment];
                increment++;
            } while (numberList[increment-1] != 4 && increment<numberList.Count);

            return sum;

        }

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int sum = 0;
            int increment = 0;
            while (numberList[increment] != 4 && increment < numberList.Count-1)
            {
                sum += numberList[increment];
                increment++;
            }
            sum += numberList[increment];
            return sum;
            throw new NotImplementedException();
		}

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            int sum = 0;
            foreach (var number in numberList.Where(e => !e.Equals(4))) sum += number;
            return sum;
            throw new NotImplementedException();
		}
	}
}
 
 
 
 