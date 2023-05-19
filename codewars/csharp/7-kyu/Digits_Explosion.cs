// Given a string made of digits [0-9], return a string where each digit is 
//repeated a number of times equals to its value.

// Examples
// explode("312")
// should return :

// "333122"

using System;
using System.Linq;

public class Digits
{
    public static string Explode(string s)
    {
        var sArray = s.ToArray();
        var exploded = "";
        foreach (var c in sArray)
        {
            var numberOfExplosions = Char.GetNumericValue(c);
            for (var counter = 0; counter < numberOfExplosions; counter++)
            {
                exploded = exploded + c;
            }
        }
        return exploded;
    }
}