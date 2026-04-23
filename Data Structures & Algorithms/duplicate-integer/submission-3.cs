public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        
        List<int> _list = new List<int>(); 

        for(int i = 0; i < nums.Length; i++)
        {
            if(!_list.Contains(nums[i]))
                _list.Add(nums[i]);
            else
                return true;
        }
        return false;
    }
}
