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
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        Console.Error.WriteLine("Debug messages...W " + W);
        Console.Error.WriteLine("Debug messages...H " + H);
        Console.Error.WriteLine("Debug messages...N " + N);
        Console.Error.WriteLine("Debug messages...X0 " + X0);
        Console.Error.WriteLine("Debug messages...Y0 " + Y0);

        var top = 0;
        var bottom = H - 1;
        var left = 0;
        var right = W - 1;

        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            Console.Error.WriteLine("Debug messages...bombDir " + bombDir);

            switch (bombDir)
            {
                case "U":
                    bottom = Y0 - 1;
                    break;
                case "UR":
                    left = X0 + 1;
                    bottom = Y0 - 1;
                    break;
                case "R":
                    left = X0 + 1;
                    break;
                case "DR":
                    left = X0 + 1;
                    top = Y0 + 1;
                    break;
                case "D":
                    top = Y0 + 1;
                    break;
                case "DL":
                    right = X0 - 1;
                    top = Y0 + 1;
                    break;
                case "L":
                    right = X0 - 1;
                    break;
                case "UL":
                    right = X0 - 1;
                    bottom = Y0 - 1;
                    break;
            }

            PrintOutput(top, bottom, left, right, out X0, out Y0);
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // the location of the next window Batman should jump to.
            //Console.WriteLine(output);
        }
    }

    static void PrintOutput(int top, int bottom, int left, int right, out int x0, out int y0)
    {
        x0 = (left + right) / 2;
        y0 = (top + bottom) / 2;
        Console.WriteLine(x0 + " " + y0);
    }
}