using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int alicePoints = 0;
        int benPoints = 0;

        List<int> lsScoreBoard = new List<int>(2) { 1, 2 };

        if (a[0] > b[0])
        {
            alicePoints++;
        }
        if (a[0] < b[0])
        {
            benPoints++;
        }
        if (a[1] > b[1])
        {
            alicePoints++;
        }
        if (a[1] < b[1])
        {
            benPoints++;
        }
        if (a[2] > b[2])
        {
            alicePoints++;
        }
        if (a[2] < b[2])
        {
            benPoints++;
        }

        lsScoreBoard[0] = alicePoints;
        lsScoreBoard[1] = benPoints;

        return lsScoreBoard;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
