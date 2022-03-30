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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int arrLength = arr.Count();
        decimal decArrLength = Convert.ToDecimal(arrLength);
        int positiveNumbers = 0;
        int negativeNumbers = 0;
        int zeroNumbers = 0;

        string[] ratios = new string[] { };
        Array.Resize(ref ratios, arrLength);

        foreach (int value in arr)
        {
            if (value > 0)
            {
                positiveNumbers++;
            }
            if (value < 0)
            {
                negativeNumbers--;
            }
            if (value == 0)
            {
                zeroNumbers++;
            }
        }

        

        var positiveRatio = Math.Abs(Convert.ToDecimal(positiveNumbers) / decArrLength);
        var negativeRatio = Math.Abs(Convert.ToDecimal(negativeNumbers) / decArrLength);
        var zeroRatio = Math.Abs(Convert.ToDecimal(zeroNumbers) / decArrLength);

        ratios[0] = positiveRatio.ToString("N6");
        ratios[1] = negativeRatio.ToString("N6");
        ratios[2] = zeroRatio.ToString("N6");

        //Console.WriteLine(ratios[0]);
        //Console.WriteLine(ratios[1]);
        //Console.WriteLine(ratios[2]);

        foreach (var ratio in ratios)
        {
            Console.WriteLine(ratio);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
