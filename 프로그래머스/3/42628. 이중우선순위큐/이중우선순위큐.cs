using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    private List<int> list = new List<int>();
    
    public int[] solution(string[] operations) {
        foreach(string oper in operations){
            //숫자 삽입 명령 I
            if(oper.Contains("I")){
                string reOper = oper.Substring(1,oper.Length-1);
                int num = int.Parse(reOper);
                list.Add(num);
            }
            //큐 삭제 명령 D
            else{
                //최소값 삭제
                if(oper.Contains("-")){
                    Remove(1);
                }
                //최대값 삭제
                else{
                    Remove(2);
                }
            }
        }       
        return list.Count==0 ? new int[2]{0,0} : new int[2]{list.Max(),list.Min()};
    }
    //삭제 메소드    
    private void Remove(int _num){
        if(list.Count()!=0){
            switch(_num){
            case 1:  //최소값 삭제
                list.Remove(list.Min());
                break;
                
            case 2: //최대값 삭제
                list.Remove(list.Max());
                break;
            }   
        }
    }
}
