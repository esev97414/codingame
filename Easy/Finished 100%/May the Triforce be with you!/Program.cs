using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = 5;
        int totalNumberOfRows = N * 2;
        int totalNumberOfColumnsPerTriangle = N + (N - 1);
        int totalNunberOfColums = (totalNumberOfColumnsPerTriangle * 2) + 1;
        char[] stars = new char[totalNunberOfColums];
        char[] temp = new char[totalNunberOfColums];
        for (int i = 0; i < totalNunberOfColums; i++)
            stars[i] = ' ';

        var count = totalNumberOfColumnsPerTriangle;

        for (int i = 0; i < totalNumberOfRows; i++)
        {
            string output = string.Empty;

            if (i == 0)
                stars[i] = '.';
            else
                stars[0] = ' ';

            stars[totalNumberOfColumnsPerTriangle + i] = '*';
            stars[totalNumberOfColumnsPerTriangle - i] = '*';

            for (int l = 0; l < totalNunberOfColums; l++)
                temp[l] = stars[l];

            if (i >= N)
            {

                for (int j = 0; j < count; j++)
                {
                    stars[i+j] = ' ';
                }
                count -= 2;
            }

            for (int m = 0; m <= totalNumberOfColumnsPerTriangle + i; m++)
                output += stars[m].ToString();
            Console.WriteLine(output);

            for (int l = 0; l < totalNunberOfColums; l++)
                stars[l] = temp[l];
        }
    }
}