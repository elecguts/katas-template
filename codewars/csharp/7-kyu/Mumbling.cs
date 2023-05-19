// This time no story, no theory. The examples below show you how to write function accum:

// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.

using System;

public class Accumul
{
    public static String Accum(string s)
    {
        var sArray = s.ToLower().ToCharArray();
        var stopArray = sArray.Length;
        var mumbling = "";
        var index = 0;
        foreach (var c in sArray)
        {
            mumbling = mumbling + c.ToString().ToUpper();
            for (var repeat = 0; repeat < index; repeat++)
            {
                mumbling = mumbling + c.ToString();
            }
            if (index != stopArray - 1)
            {
                mumbling = mumbling + "-";
            }
            index = index + 1;
        }
        return mumbling;
    }
}