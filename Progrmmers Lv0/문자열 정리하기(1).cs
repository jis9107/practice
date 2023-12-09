using System;
using System.Text.RegularExpressions;
public class Solution
{
    public int[] solution(string my_string)
    {

        my_string = Regex.Replace(my_string, @"\D", "");

        int[] answer = new int[my_string.Length];

        for (int i = 0; i < my_string.Length; i++)
        {
            answer[i] = my_string[i] - 48;
        }

        Array.Sort(answer);

        return answer;
    }
}