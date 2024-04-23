using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        if(num1 >= -50000 && num1<= 50000 && num1 >= -50000 && num1<= 50000 ){
            return num1-num2;
        }
        else{
            throw new Exception("error");
        }
    }
}