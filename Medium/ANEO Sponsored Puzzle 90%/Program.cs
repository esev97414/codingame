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
        int speed = int.Parse(Console.ReadLine());
        int lightCount = int.Parse(Console.ReadLine());
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int result = 0;
        for (int i = 0; i < lightCount; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int distance = int.Parse(inputs[0]);
            int duration = int.Parse(inputs[1]);
            dict.Add(distance, duration);
        }
        int count = 0;
        result = ParseAll(dict, speed, count);
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }

    static int ParseAll(Dictionary<int, int> dict, int speed, int count)
    {
        while (lightIsRed(speed, dict.ElementAt(count).Key, dict.ElementAt(count).Value))
        {
            speed--;
        }

        count++;
        if (count == dict.Count) return speed;
        else
            return ParseAll(dict, speed, count);
    }

    static bool lightIsRed(int speed, int distance, int duration)
    {
        var secondsToLight = distance / (speed / 3.6);

        secondsToLight = Math.Round(secondsToLight, 4);

        var period = secondsToLight / duration;
        if (Math.Floor(period) % 2 != 0)
            return true;
        else
            return false;
    }
}