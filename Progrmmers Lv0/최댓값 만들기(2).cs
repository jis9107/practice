using System;

public class Solution
{
    public int solution(int[] numbers)
    {

        Array.Sort(numbers); // 오름차순 정렬

        //배열의 제일 작은 수 2개의 곱과 제일 큰 수 2개의 곱을 구한다.
        int num1 = numbers[numbers.Length - 2] * numbers[numbers.Length - 1]; 
        int num2 = numbers[0] * numbers[1];
        
        //둘 중에 큰 값을 return
        return Math.Max(num1, num2);
    }
}