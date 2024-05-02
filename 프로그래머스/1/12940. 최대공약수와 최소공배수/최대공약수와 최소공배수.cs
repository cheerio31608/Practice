public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = 0;
            int max = 0;

            if (n >= m)
            {
                max = n;
                min = m;
            }
            else
            {
                max = m;
                min = n;
            }

            int num = 0;

            while (true)
            {
                num = max % min;
                max = min;

                if (num == 0)
                    break;

                min = num;
            }
        answer[0] = min;
        answer[1] = n * m / answer[0];
        return answer;
    }
}