public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[] {};
        long x = n;
        int y = 0; 
        while(x > 0)
        {
          x /=10;
            y++;
        }
         answer = new int[y];
           
        for(int i = 0; i<answer.Length; i++)
           {
             answer[i] = (int)(n%10);
             n = n/10;
            
           }
        
        return answer;
    }
}