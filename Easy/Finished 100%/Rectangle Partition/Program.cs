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
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int w = int.Parse(inputs[0]);
        int h = int.Parse(inputs[1]);
        int countX = int.Parse(inputs[2]);
        int countY = int.Parse(inputs[3]);
        inputs = Console.ReadLine().Split(' ');
        int[] axisX = new int[countX + 1];
        int[] axisY = new int[countY + 1];
        List<int> squaresX = new List<int>();
        List<int> squaresY = new List<int>();
        for (int i = 0; i < countX; i++)
        {
            int x = int.Parse(inputs[i]);
            axisX[i] = x;
            squaresX.Add(x);
        }
        axisX[countX] = w;
        squaresX.Add(w);

        inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < countY; i++)
        {
            int y = int.Parse(inputs[i]);
            axisY[i] = y;
            squaresY.Add(y);
        }
        axisY[countY] = h;
        squaresY.Add(h);

        for (int i = 0; i < axisX.Length; i++)
        {
            for (int j = i + 1; j < axisX.Length; j++)
            {
                squaresX.Add(Math.Abs(axisX[i] - axisX[j]));

            }
        }

        for (int i = 0; i < axisY.Length; i++)
        {
            for (int j = i + 1; j < axisY.Length; j++)
            {
                squaresY.Add(Math.Abs(axisY[i] - axisY[j]));
            }
        }

        var commonList = squaresX.Intersect(squaresY).ToList();
        Dictionary<int, int> commonX = new Dictionary<int, int>();
        Dictionary<int, int> commonY = new Dictionary<int, int>();

        //find number of common elements in each list
        //for list quaresX
        for (int i = 0; i < squaresX.Count; i++)
        {
            if (commonX.ContainsKey(squaresX[i]))
                commonX[squaresX[i]] += 1;
            else
                commonX.Add(squaresX[i], 1);
        }

        //for squaresY
        for (int i = 0; i < squaresY.Count; i++)
        {
            if (commonY.ContainsKey(squaresY[i]))
                commonY[squaresY[i]] += 1;
            else
                commonY.Add(squaresY[i], 1);
        }

        int result = 0;
        foreach (int key in commonList)
        {
            result += commonY[key] * commonX[key];
        }

        //better way
        //result = squaresX.Count(c => commonY.Contains(c));
        //to be worked on, not sure if should use squares or ?

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}