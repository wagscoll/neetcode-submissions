public class Solution {
    public bool IsPalindrome(string s) 
    {
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower().Trim(); 
        int r = s.Length-1;

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != s[r])
                return false;
                
            else
            {
                r--;
                continue;
            }
        }
        return true;
    }
}
