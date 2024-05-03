using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        Array.Sort(A);
        Array.Sort(B, (a, b) => b.CompareTo(a));
        
        int answer = 0;
        for(int i = 0; i < A.Length; i++)
        {
            answer += A[i] * B[i];
        }
        return answer;
    }
}