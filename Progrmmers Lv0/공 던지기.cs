using System;

public class Solution
{
    public int solution(int[] numbers, int k)
    {
        int answer = 0;

        for (int i = 0; i < k - 1; i++)
        {
            answer = numbers[i];
        }

        return answer;
    }
}