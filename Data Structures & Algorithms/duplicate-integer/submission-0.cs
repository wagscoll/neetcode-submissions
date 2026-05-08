public class Solution {
    public bool hasDuplicate(int[] nums) {

        List<int> numbers = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numbers.Contains(nums[i]))
            {
                return true;
                break;
            }
            numbers.Add(nums[i]);
        }
        return false;


    }
}
