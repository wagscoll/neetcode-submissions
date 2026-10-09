public class Solution
{
    private bool OnCollisionCourse(Stack<int> s, int incoming)
    {
        return s.Count > 0 && s.Peek() > 0 && incoming < 0;
    }

    private void Collide(Stack<int> s, int incoming)
    {
        int stack_asteroid = Math.Abs(s.Peek());
        int incoming_asteroid = Math.Abs(incoming);

        if (stack_asteroid == incoming_asteroid)
            s.Pop();            
        
        else if (stack_asteroid > incoming_asteroid)
            return;    
        
        else
        {
            s.Pop();           

            if(OnCollisionCourse(s, incoming))
                Collide(s, incoming);

            else
                s.Push(incoming);
        }
    }

    private void Comparison(Stack<int> s, int incoming)
    {
        if (OnCollisionCourse(s, incoming))
            Collide(s, incoming);
        else
            s.Push(incoming);
    }


    public int[] AsteroidCollision(int[] asteroids)
    {
        var s = new Stack<int>();
        foreach (int a in asteroids)
            Comparison(s, a);

        return s.Reverse().ToArray();
    }
}