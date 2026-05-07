public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        for(int i = 0; i < nums.Length; i++)
        {
            int answer = (target - (int)nums[i]);

            if(nums.Contains(answer))
            {
                int num2 = Array.IndexOf(nums, answer, i+1);

                if(num2 != -1)
                {
                    int[] array_answer = [i, num2];
                    return array_answer;
                }
            }
        }
                      
        int[] _false = [-1,-1];
        return _false;
    }
}
