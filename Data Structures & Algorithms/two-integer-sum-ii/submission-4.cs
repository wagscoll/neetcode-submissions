public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {

        int x = -1;
        int y = -1;

        int numbersLength = numbers.Length;
        
        for(int i = 0; i < numbersLength; i++)
        {
            for(int j = i+1; j < numbersLength; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    x = i+1;
                    y = j+1;
                }
            }
        } 
            int[] answer = {x, y};
            return answer;  
    }
}
