using System;

class Solution
{
    public long solution(long price, long money, int count)
    {
        for(int i=0; i<count; i++){
            money -= price*(i+1);
        }
        if(money>=0) return 0;
        else return Math.Abs(money);
    }
}