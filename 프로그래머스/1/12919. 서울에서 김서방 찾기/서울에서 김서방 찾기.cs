public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
       int index = -1; // 왜 -1로 초기화시킴? : 배열이 0 부터 시작이기 때문에
       
        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
                index = i;
                break; 
            }
        }

       
        answer = $"김서방은 " + index + "에 있다"; // $ = 문자열 사이에 변수를 넣고싶을때 {}와 함께 사용

        return answer;
    }
}