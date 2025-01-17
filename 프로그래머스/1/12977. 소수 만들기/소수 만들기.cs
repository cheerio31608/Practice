using System;

class Solution
{
    public int solution(int[] nums)
        {
            int answer = 0;

            // 배열의 각 자릿수를 참조
            for(int i = 0; i < nums.Length - 2; ++i)
            {
                for(int j = i + 1; j < nums.Length - 1; ++j)
                {
                    for(int k = j + 1; k < nums.Length; ++k)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (IsPrimeNumber(sum))
                        {
                            answer++;
                        }
                    }
                }
            }

            return answer;
        }

        // 소수 판별 메서드
        bool IsPrimeNumber(int number)
        {
            // 검사하려는 숫자의 절반 값까지만 검사해도
            // 소수 판별이 가능하므로 절반 값을 구해놓는다.
            int check_number = number / 2;

            // 나누어 떨어지는 숫자가 있다면 소수가 아님
            for(int i = 2; i < check_number; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
}