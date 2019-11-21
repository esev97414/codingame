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
        string MESSAGE = Console.ReadLine();

        bool markAsZero = false;
        bool markAsOne = false;
        string result = "";
        //string MESSAGE = "C";
        var charArray = MESSAGE.ToCharArray();
        List<char> lc = new List<char>();
        foreach (var c in charArray)
        {
            var s = Convert.ToString(c, 2).PadLeft(8, '0');
            var binArray = s.ToCharArray();
            if (binArray[0] == '0')
            {
                for (int i = 0; i < binArray.Length - 1; i++)
                {
                    lc.Add(binArray[i + 1]);
                }

            }
            else
            {
                for (int i = 0; i < binArray.Length - 1; i++)
                {
                    lc.Add(binArray[i]);
                }
            }
        }

        foreach (char c in lc)
        {
            int v = int.Parse(c.ToString());
            if (v == 0)
            {
                if (!markAsZero)
                {
                    result += " 00 ";
                    markAsZero = true;
                    markAsOne = false;
                }
                result += "0";
            }
            if (v == 1)
            {
                if (!markAsOne)
                {
                    result += " 0 ";
                    markAsOne = true;
                    markAsZero = false;
                }
                result += "0";
            }
        }

        if (result.StartsWith(""))
        {
            Console.WriteLine(result.Substring(1));
        }
        else
            Console.WriteLine(result);
    }
}