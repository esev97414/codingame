using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string x = Console.ReadLine();
            BigInteger x1 = BigInteger.Parse(x);
            List<BigInteger> l1 = new List<BigInteger>();
            l1.Add(x1);
            bool happy = false;
            while (true)
            {
                if (x1.Equals(1))
                {
                    happy = true;
                    break;
                }
                x1 = ParseNumber(x1);
                if (l1.Contains(x1))
                    break;
                l1.Add(x1);
            }
            if (happy)
                Console.WriteLine(x + " :)");
            else
                Console.WriteLine(x + " :(");
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

    }

    static BigInteger ParseNumber(BigInteger number)
    {
        BigInteger temp = 0;
        var charArray = Convert.ToString(number).ToCharArray();
        foreach (char c in charArray)
            temp += BigInteger.Parse(c.ToString()) * BigInteger.Parse(c.ToString());
        return temp;
    }
}