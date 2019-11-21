using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        ulong basicX = (ulong)n + 1;
        ulong basicY = (ulong)n * ((ulong)n + 1);

        while (basicX != (ulong)n * 2)
        {
            printFraction((ulong)n, basicX);
            basicX += 1;
        }

        Console.WriteLine("1/" + n + " = 1/" + basicX + " + " + "1/" + basicX);

        //Console.WriteLine("1/n = 1/x + 1/y");
    }

    static void printFraction(ulong refZ, ulong x)
    {
        ulong y = (refZ * x) / (x - refZ);
        if (refZ * (x + y) == (x * y))
            Console.WriteLine("1/" + refZ + " = 1/" + y + " + " + "1/" + x);
    }
}