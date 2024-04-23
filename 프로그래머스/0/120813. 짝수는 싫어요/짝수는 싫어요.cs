using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[(n+1)/2];
        for(int i=0; i<answer.Length; i++){
            answer[i] = 1 + i*2;
        }
        return answer;
    }
}