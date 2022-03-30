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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        Int32 n = arr.Count;
        int sumFirstDiag = 0;
        int sumSecondDiag = 0;
        int absoluteDiff;


        for (int i = 0; i < n; i++)
        {
            sumFirstDiag += arr[i][i];
            sumSecondDiag += arr[n - i - 1][i];
        }

        absoluteDiff = Math.Abs(sumFirstDiag - sumSecondDiag);
        return absoluteDiff;
    }

}

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List of List Initialization
        List<List<int>> arr = new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
        Console.WriteLine(result);
    }
}