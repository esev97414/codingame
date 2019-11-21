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
        long r1 = long.Parse(Console.ReadLine());
        long r2 = long.Parse(Console.ReadLine());

        List<long> l1 = new List<long>();
        List<long> l2 = new List<long>();
        l1.Add(r1);
        l2.Add(r2);
        int count = 0;
        long result = 0;
        bool meet = false;
        while (!meet)
        {
            l1.Add(r1 = parseRiver(r1));
            l2.Add(r2 = parseRiver(r2));
            if (count % 200 == 0 && count != 0)
            {
                meet = l2.Intersect(l1).Any(c => (result = c) > 0);
                if (meet)
                    Console.WriteLine(result);
            }
            count++;
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        //Console.WriteLine(result);
    }

    static long parseRiver(long river)
    {
        long temp = river;
        var charArray = Convert.ToString(river).ToCharArray();
        foreach (char c in charArray)
            temp += Convert.ToInt32(c.ToString());
        return temp;
    }
}