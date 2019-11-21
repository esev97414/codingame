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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');

        if (n == 0)
            Console.WriteLine("0");
        else
        {
            int temp = int.Parse(inputs[0]);
            for (int i = 0; i < n - 1; i++)
            {
                int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526

                if (Math.Abs(t) == Math.Abs(temp))//same values nog or pos
                {
                    if (t < 0 && temp < 0)//same negative numbers
                        temp = t;//return neg number
                    else
                        temp = Math.Abs(t);
                }
                else if (Math.Abs(t) < Math.Abs(temp))
                {
                    temp = t;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(temp);
        }
    }
}