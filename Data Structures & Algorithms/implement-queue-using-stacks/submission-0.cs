public class MyQueue 
{

    Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();

    public MyQueue() { }
    
    public void Push(int x) 
    {
        while(s1.Count > 0)
        {
            int top = s1.Peek();
            s2.Push(top);
            s1.Pop();
        }

        s1.Push(x);

        while(s2.Count > 0)
        {
            int top = s2.Peek();
            s1.Push(top);
            s2.Pop();
        }
    }
    
    public int Pop() 
    {
        int top = s1.Peek();
        s1.Pop();
        return top;
    }
    
    public int Peek() 
    {
        return s1.Peek();
    }
    
    public bool Empty() 
    {
        if(s1.Count == 0)
            return true;
        return false;
    }
}