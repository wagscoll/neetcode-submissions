public class Solution {
    public int CalPoints(string[] operations) 
    {
        Stack<int> s = new Stack<int>();
        int score = 0;

        for(int i = 0; i < operations.Length; i++)
        {
            if(operations[i] == "D")
            {
                int v = s.Peek();
                v = v*2;
                s.Push(v);
            }
            else if(operations[i] == "C")
                s.Pop();
            
            else if(operations[i] == "+")
            {
                int v2 = s.Pop();
                int v1 = s.Pop();

                s.Push(v1);
                s.Push(v2);
                s.Push(v1+v2);

            }
            else
            {
                int v = Convert.ToInt32(operations[i]);
                s.Push(v);
            }
        }

        while(s.Count > 0)
        {
            score += s.Peek();
            s.Pop();
        }

        return score;
    }
}