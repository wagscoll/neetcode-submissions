public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int slow = 0;
        int max_length = 0;
        HashSet<char> h = new HashSet<char>();

        for(int fast = 0; fast <= s.Length-1; fast++)
        {   
            while(h.Contains(s[fast]))
                h.Remove(s[slow++]);
            
            h.Add(s[fast]);
            
            if(((fast-slow)+1) > max_length)
                max_length = (fast-slow)+1;
        }  
        return max_length;
    }
}
