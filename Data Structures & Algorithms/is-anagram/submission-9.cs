public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        List<char> _list = new List<char>();
        int s1_sum = 0;
        int s2_sum = 0;

        if(s.Length != t.Length)
            return false;

        for(int i = 0; i < s.Length; i++) { _list.Add(s[i]); }

        for(int i = 0; i < s.Length; i++)
        {
            s1_sum += Convert.ToInt32(s[i]);
            s2_sum += Convert.ToInt32(t[i]); 

            if(_list.Contains(t[i]))
                continue;
            else
                return false;   
        }

        if(s1_sum == s2_sum)
            return true;      
        

        return false;
    }
}
