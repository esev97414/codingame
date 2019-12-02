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
    static Dictionary<string, int> letterPower = new Dictionary<string, int>
    {
        {"eaionrtlsu", 1 },
        {"dg", 2 },
        {"bcmp", 3 },
        {"fhvwy", 4 },
        {"k", 5 },
        {"jx", 8 },
        {"qz", 10 },
    };
    static void Main(string[] args)
    {
        //var test = letterPower.OrderByDescending(w => w.Value);
        //int i = 0;
        //i = 1;
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, int> wordPower = new Dictionary<string, int>();
        for (int i = 0; i < N; i++)
        {
            string W = Console.ReadLine();
            var wordArray = W.ToArray();
            var power = 0;
            foreach (var c in wordArray)
            {
                foreach (var lp in letterPower)
                {
                    if (lp.Key.Contains(c))
                        power += lp.Value;
                }
            }
            wordPower.Add(W, power);
        }
        string LETTERS = Console.ReadLine();

        //sort wordpower by power descending
        var wordPowerDescending = wordPower.OrderByDescending(w => w.Value);

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        //check if dict word letters are all in the LETTERS
        foreach (var word in wordPowerDescending)
        {
            if (wordFound(LETTERS, word.Key))
            {
                Console.WriteLine(word.Key);
                break;
            }
        }
    }

    static bool wordFound(string letters, string word)
    {
        var wordArray = word.ToArray();
        foreach (char c in wordArray)
        {
            char[] arr = { c };
            if (!letters.Contains(c))
                return false;

            //handle doublons and likes    
            letters = letters.Remove(letters.IndexOf(c), 1);
        }
        return true;
    }
}