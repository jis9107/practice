using System;
using System.Linq;

public class Solution
{
    public int solution(int[,] dots)
    {
        int answer = 0;

        int[] width = new int[dots.GetLength(0)];
        int[] height = new int[dots.GetLength(0)];

        for (int i = 0; i < dots.GetLength(0); i++)
        {
            width[i] = dots[i, 0];
            height[i] = dots[i, 1];
        }

        int maxWidth = width.Max();
        int minWidth = width.Min();
        int maxHeight = height.Max();
        int minHeight = height.Min();


        //가로 최대 - 가로 최소 = (가로 길이) 세로 최대 - 세로 최소 = (세로 길이)
        return (maxWidth - minWidth) * (maxHeight - minHeight);
    }
}