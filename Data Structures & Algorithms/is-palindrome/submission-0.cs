public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        s = s.Trim().Normalize().ToLower();
        StringBuilder tempString = new StringBuilder();
        string reverseString = "";

        for(int i = 0; i < s.Length; i++){

            if(Char.IsLetterOrDigit(s[i]))
            {
                tempString.Append(s[i]);
            }
        }

        s = tempString.ToString();
        reverseString = new string(s.Reverse().ToArray());
        
        Console.WriteLine("reverseString: " + reverseString + "\n" + "s - (removed spaces): " + s );


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

    

