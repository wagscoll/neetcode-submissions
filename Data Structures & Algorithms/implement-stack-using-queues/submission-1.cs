public class MyStack 
{
    Queue<int> q1 = new Queue<int>();
    Queue<int> q2 = new Queue<int>();

    public MyStack() { }
    
    public void Push(int x) 
    {

        while(q1.Count > 0)
        {
            int top = q1.Peek();
            q1.Dequeue();
            q2.Enqueue(top);
        }
        
        q1.Enqueue(x);

        while(q2.Count > 0)
        {
            int top = q2.Peek();
            q2.Dequeue();
            q1.Enqueue(top);
        }
    }
    
    public int Pop() 
    {
        int top = q1.Peek();
        q1.Dequeue();

        return top;
    }
    
    public int Top() 
    {
        return q1.Peek();
    }
    
    public bool Empty() 
    {
        if(q1.TryPeek(out int next))
            return false;
        return true;
    }
}