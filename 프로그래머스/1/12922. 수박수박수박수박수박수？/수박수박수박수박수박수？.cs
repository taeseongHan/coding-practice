public class Solution {
    public string solution(int n) {
        string answer = "";
        
        for(int i = 1; i < n+1; i++)
        {
            if(i % 2 != 0)
            {
              answer += "수";
            }
            else if(i % 2 == 0)
            {
              answer += "박";
            }
        }
        
        return answer;
    }
}