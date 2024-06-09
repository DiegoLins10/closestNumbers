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
     * Complete the 'closestNumbers' function below.
     *
     * The function accepts INTEGER_ARRAY numbers as parameter.
     */

    public static void closestNumbers(List<int> numbers)
    {

        if (numbers == null || numbers.Count < 2)
        {
            return;
        }

        numbers.Sort();

        // encontrar a diferença minima
        int minDiff = int.MaxValue;
        for (int i = 1; i < numbers.Count; i++)
        {
            int diff = numbers[i] - numbers[i - 1];
            if (diff < minDiff)
            {
                minDiff = diff;
            }
        }

        List<(int, int)> pairs = new List<(int, int)>();

        for (int i = 1; i < numbers.Count(); i++)
        {
            int diff = numbers[i] - numbers[i - 1];
            if (diff == minDiff)
            {
                pairs.Add((numbers[i - 1], numbers[i]));
            }
        }

        foreach (var pair in pairs)
        {
            Console.WriteLine($"{pair.Item1} {pair.Item2}");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int numbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersCount; i++)
        {
            int numbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            numbers.Add(numbersItem);
        }

        Result.closestNumbers(null);
    }
}
