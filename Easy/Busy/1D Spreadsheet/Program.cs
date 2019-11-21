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
        //Console.Error.WriteLine("Debug messages..." + N);
        int[] values = new int[N];
        int[] finalValues = new int[N];
        List<string> inputLines = new List<string>();
        for (int i = 0; i < N; i++)
        {
            string inputLine = Console.ReadLine();
            inputLines.Add(inputLine);
            string[] inputs = inputLine.Split(' ');
            string operation = inputs[0];
            string arg1 = inputs[1];
            string arg2 = inputs[2];
            //Console.Error.WriteLine("Debug messages..." + operation);
            //Console.Error.WriteLine("Debug messages..." + arg1);
            //Console.Error.WriteLine("Debug messages..." + arg2);
            int result = 0;
            int index = 0;
            if (operation == "VALUE")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
            }
            if (operation == "ADD")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
                if (arg2.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg2.Substring(1, 1));
                    result += values[index];
                }
                else
                {
                    result += Convert.ToInt32(arg2);
                }
            }

            if (operation == "SUB")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
                if (arg2.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg2.Substring(1, 1));
                    result -= values[index];
                }
                else
                {
                    result -= Convert.ToInt32(arg2);
                }
            }

            if (operation == "MULT")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
                if (arg2.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg2.Substring(1, 1));
                    result *= values[index];
                }
                else
                {
                    result *= Convert.ToInt32(arg2);
                }
            }
            values[i] = result;

        }

        finalValues = Process(N, values, inputLines);
        for (int i = 0; i < N; i++)
        {

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(finalValues[i]);
        }
    }

    public static int[] Process(int N, int[] values, List<string> input)
    {
        for (int i = 0; i < N; i++)
        {
            string[] inputs = input[i].Split(' ');
            string operation = inputs[0];
            string arg1 = inputs[1];
            string arg2 = inputs[2];
            //Console.Error.WriteLine("Debug messages..." + operation);
            //Console.Error.WriteLine("Debug messages..." + arg1);
            //Console.Error.WriteLine("Debug messages..." + arg2);
            int result = 0;
            int index = 0;
            if (operation == "VALUE")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
            }
            if (operation == "ADD")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
                if (arg2.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg2.Substring(1, 1));
                    result += values[index];
                }
                else
                {
                    result += Convert.ToInt32(arg2);
                }
            }

            if (operation == "SUB")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
                if (arg2.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg2.Substring(1, 1));
                    result -= values[index];
                }
                else
                {
                    result -= Convert.ToInt32(arg2);
                }
            }

            if (operation == "MULT")
            {
                if (arg1.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg1.Substring(1, 1));
                    result = values[index];
                }
                else
                {
                    result = Convert.ToInt32(arg1);
                }
                if (arg2.StartsWith("$"))
                {
                    index = Convert.ToInt32(arg2.Substring(1, 1));
                    result *= values[index];
                }
                else
                {
                    result *= Convert.ToInt32(arg2);
                }
            }
            values[i] = result;

        }
        return values;
    }
}