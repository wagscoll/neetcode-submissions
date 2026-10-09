public class Solution
{
    // The only collision case: stack stack_asteroid moving right, incoming moving left
    private bool OnCollisionCourse(Stack<int> s, int incoming)
    {
        return s.Count > 0 && s.Peek() > 0 && incoming < 0;
    }

    private void Collide(Stack<int> s, int incoming)
    {
        int stack_asteroid = Math.Abs(s.Peek());
        int incoming_asteroid = Math.Abs(incoming);

        if (stack_asteroid == incoming_asteroid)
        {
            s.Pop();            // both destroyed
        }
        else if (stack_asteroid > incoming_asteroid)
        {
            return;             // incoming destroyed
        }
        else
        {
            s.Pop();            // stack_asteroid destroyed

            if(OnCollisionCourse(s, incoming))
            {
                Collide(s, incoming);
            }
            else
                s.Push(incoming);   // TODO: incoming may still hit the new stack_asteroid
        }
    }

    private void Process(Stack<int> s, int incoming)
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
            Process(s, a);


        return s.Reverse().ToArray();
    }
}