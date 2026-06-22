public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int[] answer = new int[temperatures.Length];
        
        //Stack<int> stack = new Stack<int>();
        for(int i = 0; i < temperatures.Length; i++)
        {
            int next = 0;

            for(int j = i+1; j < temperatures.Length; j++)
            {
                if(temperatures[j] > temperatures[i])
                {
                    next = (j-i);
                    break;
                }
            }

            answer[i] = next;

        }



        return answer;


    }
}
