public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int current = 0;
        int left = current + 1;
        int right = nums.Length - 1;

        List<List<int>> answer = new List<List<int>>();
        Array.Sort(nums);

        while (left < right && (current <= nums.Length - 2)) 
        {
            while ((right > left)) 
            {
                int sum = (nums[current] + nums[left] + nums[right]);

                if (sum == 0) 
                {
                    List<int> temp = new List<int>();
                    if (!answer.Any(t => t.SequenceEqual( new List<int> {nums[left], nums[current], nums[right]} )))
                        answer.Add(new List<int> { nums[left], nums[current], nums[right] });

                    left++;
                } 
                else if (sum < 0) // sum < 0 -> increment left
                    left++;
                else // sum is > 0 -> decrement right
                    right--;
            }
            current++;
            left = current + 1;
            right = nums.Length-1;
        }
        return answer;
    }
}
