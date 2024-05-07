using System;

public class Solution {
    public int solution(int[] d, int budget) {
        Array.Sort(d);
        int answer = 0;
        for(int i = 0; i<d.Length; i++){
            if(budget - d[i] >= 0){
                budget -= d[i];
                answer++;
            }
        }
        return answer;
    }
}