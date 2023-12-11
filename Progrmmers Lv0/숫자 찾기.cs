using System;

public class Solution
{
    public int solution(int num, int k)
    {
        int answer = 0;

        string numbers = num.ToString();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (int.Parse(numbers[i].ToString()) == k)
            {
                answer = i + 1;
                break;
            }
            else
                answer = -1;
        }
        return answer;

        //int answer = num.ToString().IndexOf(k.ToString()) + 1;
        //return answer == 0 ? answer - 1 : answer;
    }
}