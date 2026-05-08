public class Solution {
    public bool IsValid(string s) 
    {
        int itteration = 0;

        for(int i = 0; i < s.Length*2; i++)
        {
            if(s.Contains("()"))
            {
                Console.WriteLine("() DETECTED!");
                s= s.Replace("()","");
            }
            else if (s.Contains("[]"))
            {
                Console.WriteLine("[] DETECTED!");
                s= s.Replace("[]","");
            }
            else if(s.Contains("{}"))
            {
                Console.WriteLine("{} DETECTED!");
                s = s.Replace("{}","");
            }
        }

        Console.WriteLine(s);
        if (s.Length == 0)
            return true;
        else
            return false;
        
    }
}
