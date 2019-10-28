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
            foreach(int i in numberArray)
            {
                if (i != 4)
                    result += i;
            }
            foreach(int i in numberList)
            {
                if (i != 4)
                    result += i;
            }
            return result;
            
            //throw new NotImplementedException();
		}

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            int result = 0;

            foreach (int i in numberList)
            {
                if (i != 4)
                result += i;
            }
            return result;

            //throw new NotImplementedException();
		}

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int result = 0;
            int i = 0;
            do
            {
                result += numberList[i];
                if (numberList[i] == 4)
                    i = numberList.Count;
                else i++;
            }
            while (i < numberList.Count);

            return result;


           // throw new NotImplementedException();
		}

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int i = 0;
            int result = 0;
            while (i < numberList.Count)
            {
                result += numberList[i];
                if (numberList[i] != 4)
                    i++;
                else
                    i = numberList.Count;
            }
            return result;

            //throw new NotImplementedException();
		}

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{

            int result = 0;

            var filteredlist = from i in numberList
                               where i != 4
                               select i;
            
            foreach (int i in filteredlist)
                result += i;

            return result;
            //throw new NotImplementedException();
		}
	}
}
 
 
 
 