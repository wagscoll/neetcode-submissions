public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        int ans_length = nums.Length *2;
        int[] ans = new int[ans_length];

        for(int i = 0; i < ans_length; i++)
        {
            if(i < nums.Length)
                ans[i] = nums[i];
            
            else{
                ans[i] = nums[i-nums.Length];
            }
        }

        return ans;
    }
}