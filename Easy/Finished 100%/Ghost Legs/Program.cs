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
        string[] inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);

        Dictionary<string, string> dict = new Dictionary<string, string>();
        List<string> topRef = new List<string>();
        List<string> top = new List<string>();
        List<string> bottom = new List<string>();
        for (int i = 0; i < H; i++)
        {
            string line = Console.ReadLine();
            var lineArr = line.ToArray();
            if (i == 0)//fist line
            {
                for (int j = 0; j < lineArr.Length; j += 3)
                {
                    top.Add(lineArr[j].ToString());
                    topRef.Add(lineArr[j].ToString());
                }
                foreach (var v in top)
                    Console.Error.WriteLine("Debug messages top..." + v);

            }
            if (i == H - 1)//last line
            {
                int val = 0;
                for (int j = 0; j < lineArr.Length; j += 3)
                {
                    bottom.Add(lineArr[j].ToString());
                    dict.Add(top[val], lineArr[j].ToString());
                    val++;
                }
                foreach (var v in bottom)
                    Console.Error.WriteLine("Debug messages bottom..." + v);
            }
            else //in between
            {
                for (int k = 1, l = 0; k < lineArr.Length; k += 3, l++)
                {
                    if (lineArr[k] == '-')//swap the columns if the is a link
                    {
                        string temp = "";
                        temp = top[l];
                        top[l] = top[l + 1];
                        top[l + 1] = temp;

                    }
                }
            }
        }

        //rearrange due to top line swapping
        Dictionary<string, string> result = new Dictionary<string, string>();
        foreach (var key in topRef)
        {
            string value = dict[key];
            result.Add(key, value);
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        foreach (var v in result)
            Console.WriteLine(v.Key + v.Value);
    }
}