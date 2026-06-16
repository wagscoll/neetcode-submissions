public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        int count = (nums.Length > 0) ? count = 1 : count = 0;
        int maxCount = (nums.Length > 0) ? maxCount = 1 : maxCount = 0;
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            if(i < nums.Length - 1)
            {
                int next = nums[i+1];
                int current = nums[i];

                if((current + 1) == next)               // if ((2+1) == 3)
                {
                    count++;
                    continue;
                }

                else if(next == current) {continue;}    //skips duplicates
            }
            
            if(count > maxCount)
                maxCount = count;

            count = (nums.Length > 0) ? count = 1 : count = 0;       
        }
        return maxCount;
    }
}
