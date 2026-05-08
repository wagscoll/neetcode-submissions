public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        StringBuilder sb = new StringBuilder();
        string reverseString = "";

        for(int i = 0; i < s.Length; i++)   //this simply eliminates whitespace from s -> sb
        {
            if(Char.IsLetterOrDigit(s[i]))
            {
                sb.Append(s[i]);
            }
        }

        s = sb.ToString().Trim().Normalize().ToLower(); //sb -> s AND cleans

        reverseString = new string(s.Reverse().ToArray()); //reverses s
        
        Console.WriteLine("reverseString: " + reverseString + "\n" + "s - (removed spaces): " + s ); //debugging


        if (reverseString == s) 
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}

    

