using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        List<long> listArr = new List<long>();

        long smallestSum = 0;
        long largestSum = 0;
        foreach (long num in arr)
        {
            listArr.Add(num);
        }

        long smallestNum = listArr.Min();
        long largestNum = listArr.Max();

        int indexOfSmallestNum = listArr.IndexOf(smallestNum, 0, listArr.Count);

        int indexOfLargestNum = listArr.IndexOf(largestNum, 0, listArr.Count);

        for (int i = 0; i < listArr.Count; i++)
        {
            if (i != indexOfSmallestNum)
            {
                largestSum += listArr[i];
            }
        }
        for (int i = 0; i < listArr.Count; i++)
        {
            if (i != indexOfLargestNum)
            {
                smallestSum += listArr[i];
            }
        }
        Console.WriteLine($"{smallestSum} {largestSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
