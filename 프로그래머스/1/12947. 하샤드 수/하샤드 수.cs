public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int n = 0;
        int originalX = x;
        
        while(x > 0)
        {
           n += x % 10;
            x = x / 10;           
        }
        if (n == 0 || originalX % n != 0)
        {
            answer = false;
        }
        
        return answer;
    }
}