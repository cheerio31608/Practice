using System;

public class Solution {
    public int solution(int n) {
        if (n < 2) return 0;

        // 에라토스테네스의 체를 사용하여 소수 판별
        bool[] isPrime = new bool[n + 1];
        Array.Fill(isPrime, true); // 모든 숫자를 소수로 가정
        isPrime[0] = isPrime[1] = false; // 0과 1은 소수가 아님

        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // 소수 개수 세기
        int answer = 0;
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i]) answer++;
        }

        return answer;
    }
}