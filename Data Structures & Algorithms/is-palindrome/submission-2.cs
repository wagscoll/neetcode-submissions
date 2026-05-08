public class Solution {
    public bool IsPalindrome(string s) 
    {
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower().Trim(); 
        int r = s.Length-1;

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != s[r])
            {
                Console.WriteLine(s);
                Console.WriteLine($"i = {i}");
                Console.WriteLine($"r = {r}");
                Console.WriteLine($"Length = {s.Length}");
                Console.WriteLine($"S[i] = {s[i]}");
                Console.WriteLine($"S[r] = {s[r]}");

                return false;
            }
                
            else
            {
                Console.WriteLine(s);
                Console.WriteLine($"i = {i}");
                Console.WriteLine($"r = {r}");
                Console.WriteLine($"Length = {s.Length}");
                Console.WriteLine($"S[i] = {s[i]}");
                Console.WriteLine($"S[r] = {s[r]}");
                r--;
                continue;
            }
            //r = r-1;
        }
        return true;
    }
}
