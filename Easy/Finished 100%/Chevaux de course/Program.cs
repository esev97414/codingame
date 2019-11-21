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
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            arr[i] = pi;
        }
        Array.Sort(arr);
        int temp = arr[0];
        var closest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            var diff = Math.Abs(temp - arr[i]);
            if (diff < closest)
            {
                closest = diff;
            }
            temp = arr[i];
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(closest);
    }
}