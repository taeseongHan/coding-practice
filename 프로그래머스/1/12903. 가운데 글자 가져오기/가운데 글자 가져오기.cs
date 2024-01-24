public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] arr = s.ToCharArray();
        
        if(arr.Length % 2 == 0)
        {
            answer = $"{arr[arr.Length/2-1]}{arr[arr.Length/2]}";
        }
        else if(arr.Length % 2 != 0)
        {
            answer = $"{arr[(arr.Length/2)]}";
        }
        
        return answer;
    }
}