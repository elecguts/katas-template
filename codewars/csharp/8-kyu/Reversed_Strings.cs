// Complete the solution so that it reverses the string passed into it.

// 'world'  =>  'dlrow'
// 'word'   =>  'drow'

using System;

public static class Kata
{
    public static string Solution(string str)
    {
        var strArray = str.ToCharArray();
        Array.Reverse(strArray);
        return new string(strArray);
    }
}