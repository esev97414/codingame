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
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, double> defibs = new Dictionary<string, double>();
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            string[] defibData = DEFIB.Split(';');
            string defibLON = defibData[4].Replace(',', '.');
            string defibLAT = defibData[5].Replace(',', '.');
            double longitudeB = Math.PI * (Convert.ToDouble(defibLON)) / 180.0;
            double latitudeB = Math.PI * (Convert.ToDouble(defibLAT)) / 180.0;

            double longitudeA = Math.PI * (Convert.ToDouble(LON.Replace(',', '.'))) / 180.0;
            double latitudeA = Math.PI * (Convert.ToDouble(LAT.Replace(',', '.'))) / 180.0;

            double x = (longitudeB - longitudeA) * Math.Cos((latitudeA + latitudeB) / 2);
            double y = latitudeB - latitudeA;
            double distance = Math.Sqrt((x * x) + (y * y)) * 6371;

            defibs.Add(defibData[0] + ";" + defibData[1], distance);
        }

        var d = defibs.FirstOrDefault();
        double shortestDist = 0.0;
        //if(d != null)
        shortestDist = d.Value;
        var name = d.Key.Split(';')[1];

        foreach (var item in defibs)
        {
            if (item.Value < shortestDist)
            {
                shortestDist = item.Value;
                name = item.Key.Split(';')[1];
                //Console.Error.WriteLine(name);
            }
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(name);
    }
}