public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {        
        List<int> temp = new List<int>();
        List<List<int>> answer = new List<List<int>>();

        Array.Sort(nums);

        for(int i = 1; i < nums.Length - 1; i++)
        {
            int b = i;
            int a = 0;

            while(a < b)
            {
                int c = b + 1;
                while(c < nums.Length)
                {
                    if(nums[a] + nums[b] + nums[c] == 0)
                    {
                        temp.Add(nums[a]);
                        temp.Add(nums[b]);
                        temp.Add(nums[c]);
                        
                        if(!AnswerContains(answer, temp))
                            answer.Add(new List<int>(temp));
                        temp.Clear();
                    }
                    c++;
                }
                a++;
            }
        }
        return answer;
    }
    
    private bool AnswerContains(List<List<int>> answer, List<int> temp)
    {
        foreach(List<int> lst in answer)
        {
            if(lst.Count != temp.Count) continue;
            bool match = true;
            for(int i = 0; i < lst.Count; i++)
            {
                if(lst[i] != temp[i]) { match = false; break; }
            }
            if(match) return true;
        }
        return false;
    }
}