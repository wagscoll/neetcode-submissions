public class Solution {
    public bool IsValid(string s) 
    {
        for(int i = 0; i < s.Length*2; i++)
        {
            if(s.Contains("()"))      
                s = s.Replace("()","");            
            else if (s.Contains("[]"))            
                s = s.Replace("[]","");           
            else if(s.Contains("{}"))           
                s = s.Replace("{}","");           
        }

        if (s.Length == 0)
            return true;
        else
            return false;
        
    }
}
