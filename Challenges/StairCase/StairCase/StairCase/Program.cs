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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        //int n = 4;
        string asdf = "";
        int numSpaces = n - 1;
        int numHash = 0;
        int charactersInRow = 0;
        for (int i = 0; i < n; i++)
        {
            while ((numSpaces > 0) && (charactersInRow < n))
            {
                asdf = asdf + " ";
                numSpaces--;
                charactersInRow++;
            }
            while ((n > numHash) && (charactersInRow < n))
            {
                asdf = asdf + "#";
                numHash++;
                charactersInRow++;
            }
            Console.WriteLine(asdf);
            asdf = "";
            charactersInRow = 0;
            numHash = 0;
            numSpaces = n - 2 - i;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
