public class Solution
 {
    public int[] TwoSum(int[] nums, int target)
     {
        int index1 = -1;
        int index2 = -1;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = (i + 1); j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    index1 = i;
                    index2 = j;
                    break;
                }
            }
        }
        int[] sums = {index1,index2};
        return sums;
    }
 }
