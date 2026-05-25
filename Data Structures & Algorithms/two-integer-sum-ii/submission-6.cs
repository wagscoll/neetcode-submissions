public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {

        int left = 0;
        int right = numbers.Length-1;
        int[] answer = {-1,-1};
        
        while(left < right)
        {
            if(numbers[left] + numbers[right] == target)
            {
                Console.WriteLine($"Match found.\nLeft: {numbers[left]}\nRight: {numbers[right]}");
                answer[0] = ++left;
                answer[1] = ++right;
                return answer;
            }

            else if(numbers[left] + numbers[right] < target)
                left++;
            else if(numbers[left] + numbers[right] > target)
                right--;
        }
        return answer;
    }
}
