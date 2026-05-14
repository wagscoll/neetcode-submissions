public class Solution {
    public int Search(int[] nums, int target) {
        int lower = 0;
        int upper = nums.Length - 1;
        int middle = nums.Length / 2;
        bool found = false;

        if (!nums.Contains(target)) 
            return -1;

        while (!found) {
            if (target == nums[upper]) {
                found = true;
                return Array.IndexOf(nums, nums[upper]);
            } else if (target == nums[middle]) {
                found = true;
                return Array.IndexOf(nums, nums[middle]);
            } else if (target == nums[lower]) {
                found = true;
                return Array.IndexOf(nums, nums[lower]);
            }

            if (target < nums[middle]) {
                upper = middle;
                middle = (((upper - lower) / 2) + lower);
            }

            else if (target > nums[middle]) {
                lower = middle;
                middle = (((upper - lower) / 2) + lower);
            }
        }
        return 0;
    }
}
