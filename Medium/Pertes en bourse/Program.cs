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
        string[] inputs = Console.ReadLine().Split(' ');
        int maxValue = 0;
        int drop = 0;
        List<int> drops = new List<int>();
        List<int> values = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int v = int.Parse(inputs[i]);
            values.Add(v);
            if (v >= maxValue)
            {
                maxValue = v;
                drop = 0;

            }
            else
            {
                drop += v - values[i - 1];
            }
            drops.Add(drop);
        }
        drops.Sort();//increasing order

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(drops[0]);//output smallest value
    }
}