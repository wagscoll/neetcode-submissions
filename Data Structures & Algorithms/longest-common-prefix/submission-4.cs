public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {

        if(strs.Length == 0)
            return "";
        
        string temp_str = strs[0];
        
        for(int i = 1; i < strs.Length; i++)
        {
            while(!strs[i].Contains(temp_str))
            {
                temp_str = temp_str.Substring(0, temp_str.Length-1);
            }
        }
     
        return temp_str;
    }
}