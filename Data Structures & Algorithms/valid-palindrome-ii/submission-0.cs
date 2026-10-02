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
        Console.WriteLine($"{s} is a valid palindrome.");
        return true;
    }

    public bool ValidPalindrome(string s) 
    {
        if(Palindrome(s))
            return true;

        for(int i = 0; i <= s.Length-1; i++)
        {
            Console.WriteLine($"charToRemove - {s[i]}");
            string s_temp = s.Remove(i, 1);
            Console.WriteLine($"s_temp - {s_temp}");

            if(Palindrome(s_temp))
                return true;
        }

        return false;
    }
}