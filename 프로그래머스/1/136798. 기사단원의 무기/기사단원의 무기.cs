using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i=1; i<number+1; i++)
        {
            int count = 0;
            for(int j=1; j<= (int)Math.Sqrt(i); j++)
            {
                if(j * j == i) count++;
                else if(i % j == 0) count += 2;
            }
            if(count <= limit) answer += count;
            else answer += power;
        }
        
        return answer;
    }
}