public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {

        if(strs.Length == 0)
            return "";
        
        string temp_str = strs[0];
        
        for(int i = 1; i < strs.Length; i++)
        {
            if(strs[i].Contains(temp_str))
            {
                Console.WriteLine("Continue has been selected.");
                continue;
            }
            while(!strs[i].Contains(temp_str))
            {
                temp_str = temp_str.Substring(0, temp_str.Length-1);
                Console.WriteLine($"While Loop has been entered . . . \n\n temp_str == {temp_str}");
            }
        }
     
        return temp_str;
    }
}