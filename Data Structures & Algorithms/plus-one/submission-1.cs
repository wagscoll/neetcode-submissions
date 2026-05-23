public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        int last = digits[digits.Length-1];

        


        //digits[digits.Length-1] = ++last;

       
        string nums = "";
        foreach(int n in digits)
        {
            n.ToString();
            nums += n.ToString();
        }

        //converts to int and increments
        var val = (Convert.ToInt64(nums)+1);
        string s = val.ToString();
        char[] c = s.ToCharArray();

        int[] answer = new int[s.Length];
        for(int i = 0; i < s.Length; i++)
            answer[i] = (int)char.GetNumericValue(c[i]);

        return answer;

        
    }
}
