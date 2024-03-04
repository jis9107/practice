using System;
using System.Linq;

class Solution
{
    public int solution(int n)
    {

        string num1 = Convert.ToString(n, 2);
        int freq = num1.Count(x => (x == '1'));
        int temp = n;
        int freq2 = 0;

        while (freq != freq2)
        {
            temp++;
            string num2 = Convert.ToString(temp, 2);
            freq2 = num2.Count(x => (x == '1'));
        }

        return temp;
    }
}