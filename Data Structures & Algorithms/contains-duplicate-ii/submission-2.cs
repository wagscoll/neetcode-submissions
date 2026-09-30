public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        for(int j = nums.Length-1; j >= 0; j--)
        {
            for(int i = 0; i < nums.Length-1; i++)
            {
                if(j<=i)
                    break;
                
                if(nums[i] == nums[j] && (Math.Abs(i-j) <= k))
                {
                    Console.WriteLine($"i = {i}, j = {j}, {Math.Abs(i-j)} <= {k}");
                    return true;
                }
            }
        }

        return false;
    }
}