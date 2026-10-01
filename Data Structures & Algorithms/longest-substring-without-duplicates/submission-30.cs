public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int slow = 0;
        int current_length = 0;
        int max_length = 0;
        HashSet<char> h = new HashSet<char>();

        for(int fast = 0; fast <= s.Length-1; fast++)
        {   
            while(h.Contains(s[fast]))
            {   
                h.Remove(s[slow]);
                slow++;                
            }
            h.Add(s[fast]);
            
            current_length = ((fast - slow) +1);
            if(current_length > max_length)
                max_length = current_length;
        }  
        return max_length;
    }
}
