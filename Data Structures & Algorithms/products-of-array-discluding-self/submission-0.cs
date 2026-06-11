public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] answer = new int[nums.Length];



        //itterating pointer
        for(int itterator = 0; itterator < nums.Length; itterator++)
        {
            int result = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                if(itterator == i) 
                    continue;

                result *= nums[i];
            }

            answer[itterator] = result;
        }





        return answer;
    }
}
