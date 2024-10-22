using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> klist = new List<int>();
        for(int i=0; i<score.Length; i++){
            if(klist.Count < k) 
            {
                klist.Add(score[i]);
            }
            else
            {
                if(score[i] > klist[0])
                {
                    klist[0] = score[i];
                }
            }
            
            klist.Sort();
            answer[i] = klist[0];
        }
        return answer;
    }
}