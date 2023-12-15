using System;
using System.Linq;

public class Solution
{
    public int solution(int[] arr1, int[] arr2)
    {
        int answer = 0;

        if (arr1.Length > arr2.Length)
            return 1;
        else if (arr1.Length < arr2.Length)
            return -1;
        else
        {
            int arr1_sum = arr1.Sum();
            int arr2_sum = arr2.Sum();

            if (arr1_sum > arr2_sum)
                return 1;
            else if (arr1_sum < arr2_sum)
                return -1;
            else
                return 0;

        }

    }
}