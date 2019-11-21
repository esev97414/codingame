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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        const int A = 65;
        const int Z = 90;
        string Input = T.ToUpper();
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            string val = string.Empty;
            foreach (char c in Input)
            {
                if ((int)c >= A && (int)c <= Z)
                    val += ROW.Substring((((int)c - A + 1) * L) - L, L);
                else
                    val += ROW.Substring(((ROW.Length)) - L, L);
            }

            Console.WriteLine(val);
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
    }
}