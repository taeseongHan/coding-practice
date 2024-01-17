public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int phoneLength = phone_number.Length;
        for(int i = 0; i < phoneLength-4; i++)
        {        
            answer += '*';                  
        }
        
        answer += phone_number.Substring(phoneLength - 4, 4);
        return answer;
    }
}