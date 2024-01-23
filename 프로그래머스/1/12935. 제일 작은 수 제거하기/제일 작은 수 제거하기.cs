public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        
      
        if (arr.Length == 1)
        {
            return new int[] { -1 };
        }

        int smallest = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
            }
        }

        answer = new int[arr.Length - 1];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != smallest)
            {
                answer[index] = arr[i];
                index++;
            }
        }
        return answer;
    }
}