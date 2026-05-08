public class Solution {
    public int LongestConsecutive(int[] nums) {

        int count;
        int[] numsDistinct = nums.Distinct().ToArray();

        if(nums.Length == 0) {return 0;}
        else {count = 1;}
        
        Array.Sort(numsDistinct);

        int maxCount = 1;
        string s = "";
        string spacing = ", ";
        string numbers = "";

        List<int> seqCount = new List<int>();

        for(int i = 1; i < numsDistinct.Length; i++)
        {
            int x1 = numsDistinct[i];
            int x2 = numsDistinct[i-1]+1;

            if(x1 == x2) //checks to see if num[i] == num[i+1]
            {
                count++; //if so increment count
                s += (numsDistinct[i].ToString() + spacing);
            }
            else{ //when not consecutive, then update maxCount to be the highest value b/w current and count
                maxCount = Math.Max(maxCount, count);
                count = 1;
            }
        }   
        return Math.Max(maxCount, count);
    }
}
