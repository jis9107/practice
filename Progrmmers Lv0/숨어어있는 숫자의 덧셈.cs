using System;
using System.Text.RegularExpressions;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;

        string s = Regex.Replace(my_string, @"\D", ""); // my_string에서 숫자만 추출
        for (int i = 0; i < s.Length; i++)
        {
            answer += (int)s[i] - 48; // 아스키 코드 값 빼기
        }


        return answer;
    }
}
