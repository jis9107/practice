using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 1;
        int temp = 1;

        while (true)
        {
            answer++;
            temp *= answer;

            if (temp > n)
                return answer - 1;
            if (temp == n)
                return answer;
        }

    }
}