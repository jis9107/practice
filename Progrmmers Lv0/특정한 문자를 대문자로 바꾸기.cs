using System;
using System.Linq;

public class Solution
{
    public string solution(string my_string, string alp)
    {

        my_string = my_string.Replace(alp, alp.ToUpper());

        return my_string;
    }
}