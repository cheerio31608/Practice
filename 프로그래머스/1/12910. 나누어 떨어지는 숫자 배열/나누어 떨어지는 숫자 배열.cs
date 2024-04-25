using System;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[arr.Length];
        int count = 0;
        for(int i=0; i<arr.Length; i++){
            if(arr[i]%divisor == 0){
                answer[count] = arr[i];
                count++;
            }
        }
        if(count == 0){
            return new int[]{-1};
        }
        else{
            Array.Resize(ref answer, count);
            Array.Sort(answer);
            return answer;
        }

    }
}