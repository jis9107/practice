using System;

public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        int[] answer = new int[arr.Length];

        if (k % 2 == 1) // K는 홀수
        {
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] * k;
            }
        }

        else if (k % 2 == 0) // K는 짝수
        {
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] + k;
            }
        }

        return answer;
    }
}