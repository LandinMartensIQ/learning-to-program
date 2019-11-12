using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace ListsLogicAndIterations.Code
{
	public static class LogicAndInterations
	{
		public static int For_SumTwoListsAndAllValueThatAreNotFour(int[] numberArray, List<int> numberList)
        {
            var total = 0;
            foreach (var rTotal in numberList)
            {
                if (numberList.Contains(4))
                {
                    total += 0;
                }
                else
                {
                    total += rTotal;
                }
            }

            for (var count = 0; count < numberArray.Length; count++)
            {
                if (numberArray[count] == 4)
                {
                    total += 0;
                }
                else
                {
                    total += numberArray[count];
                }
            }
            return total;
        }

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            var total = 0;
            foreach (var rTotal in numberList)
            {
                if (rTotal == 4)
                {
                    total += 0;
                }
                else
                {
                    total += rTotal;
                }
            }
            return total;
        }

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
        {
            var total = 0;
            var expected = 0;
            var counter = 0;
            do
            {
                total = numberList[counter];
                expected += total;
            } while (++counter < numberList.Count && numberList[counter-1] != 4);

            return expected;
            //throw new NotImplementedException();
        }

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
        {
            var counter = 0;
            var total = 0;
  
            while (counter < numberList.Count)
            {
                if (numberList[counter] != 4)
                {
                    total += numberList[counter];
                    counter++;
                }
                else
                {
                    total += numberList[counter];
                    break;
                }
            }
            return total;
        }

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
        {
            var total = 0;
            
            var myLinqQuery = from number in numberList where number != 4 select number;

            foreach (var number in myLinqQuery)
            {
                total += number;
            }

            return total;

            //throw new NotImplementedException();
        }
	}
}
 
 
 
 