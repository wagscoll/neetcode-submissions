public class Solution {
    public bool IsValid(string s) {

        string bracket = "[]"; 
        string parenthesis = "()";
        string curlyBracket = "{}"; 

        while (s.Contains(bracket) || s.Contains(parenthesis) || s.Contains(curlyBracket))
        {
            s = s.Replace(bracket, "");
            s = s.Replace(parenthesis, "");
            s = s.Replace(curlyBracket, "");
        } 

        Console.WriteLine("S.Length = " + s.Length);

       return s.Length == 0;
    }
}

