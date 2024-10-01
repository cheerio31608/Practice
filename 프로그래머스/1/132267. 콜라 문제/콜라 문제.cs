using System;

public class Solution
{
    public int solution(int a, int b, int n)
    {
        int answer = 0;

        while (n >= a)
        {
            int num = n / a;

            answer += num * b;
            n += num * (b - a);
        }

        return answer;
    }
}