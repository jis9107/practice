using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(int age)
    {
        string answer = "";

        List<char> list = new List<char>();

        for (char i = 'a'; i <= 'z'; i++)
        {
            list.Add(i);
        }

        foreach (var item in age.ToString())
        {
            answer += list[int.Parse(item.ToString())];
        }

        return answer;
    }
}