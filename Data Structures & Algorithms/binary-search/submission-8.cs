public class Solution {
    public int Search(int[] nums, int target) {
        int length = nums.Length;

        int lower = 0;
        int upper = length - 1;
        int middle = length / 2;
        

        bool found = false;

        if (!nums.Contains(target)) {
            return -1;
        }

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
