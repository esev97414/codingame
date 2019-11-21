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
        int R = int.Parse(Console.ReadLine());
        int V = int.Parse(Console.ReadLine());
        double result = 0;
        double[] combinationTimes = new double[R];
        for (int i = 0; i < V; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int C = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            int nbrChars = C - N;
            double time = Math.Pow(5, nbrChars) * Math.Pow(10, N);
            //Console.Error.WriteLine("Debug messages..." + time);

            int indexOfFirstAvailableRobber = i;
            if (i < R)
            {   //allocate combination time to available robber
                combinationTimes[indexOfFirstAvailableRobber] = time;
            }
            else
            {
                //no more robber available
                //allocate the new combination time to the robber who will finish first
                indexOfFirstAvailableRobber = Array.IndexOf(combinationTimes, combinationTimes.Min());
                combinationTimes[indexOfFirstAvailableRobber] += time;
            }

            //max time  is total heist time
            result = combinationTimes.Max();

            //Console.Error.WriteLine("Debug messages..." + result);
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}