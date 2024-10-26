public class Solution {
    public string solution(int a, int b) {
        int[] month = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int day = 0;
        for(int i=0; i<a-1; i++){
            day += month[i];
        }
        day += b-1;
        
        string[] week = new string[] {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        string answer = week[day % 7];
        return answer;
    }
}