using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] one = new int[5] {1, 2, 3, 4, 5};
        int[] two = new int[8] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] three = new int[10] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] count = new int[3] {0, 0, 0};
        List<int> ans = new List<int>();
        
        for(int i=0; i<answers.Length; i++){
            if(answers[i] == one[i%one.Length]) count[0]++;
            if(answers[i] == two[i%two.Length]) count[1]++;
            if(answers[i] == three[i%three.Length]) count[2]++;
        }
        
        int max = 0;
        for(int i=0; i<3; i++){
            if(count[i] > max) max = count[i];
        }
        for(int i=0; i<3; i++){
            if(count[i] == max) ans.Add(i+1);
        }
                
        return ans.ToArray();
    }
}