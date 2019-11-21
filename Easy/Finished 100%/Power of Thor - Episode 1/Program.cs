using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position


        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            Console.Error.WriteLine("Debug lightX: {0}", lightX);
            Console.Error.WriteLine("Debug lightY: {0}", lightY);
            Console.Error.WriteLine("Debug initialTx: {0}", initialTx);
            Console.Error.WriteLine("Debug initialTy: {0}", initialTy);
            string s = string.Empty;

            if (initialTy > lightY)
            {
                initialTy--;
                s += "N";
            }

            if (initialTy < lightY)
            {
                initialTy++;
                s += "S";
            }

            if (initialTx > lightX)
            {
                initialTx--;
                s += "W";
            }

            if (initialTx < lightX)
            {
                initialTx++;
                s += "E";
            }

            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(s);
        }
    }
}