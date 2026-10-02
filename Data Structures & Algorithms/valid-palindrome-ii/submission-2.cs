public class Solution 
{

    public bool Palindrome(string s)
    {
        int p1 = 0;
        int p2 = s.Length-1;

        while(p1 <= p2)
        {
            if(s[p2] != s[p1])
                return false;

            p1++;
            p2--;
        }
        return true;
    }

    public bool ValidPalindrome(string s) 
    {
        if(Palindrome(s))
            return true;

        for(int i = 0; i <= s.Length-1; i++)
        {
            string s_temp = s.Remove(i, 1);
            if(Palindrome(s_temp))
                return true;
        }

        return false;
    }
}