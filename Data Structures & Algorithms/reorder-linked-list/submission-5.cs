public class Solution 
{
    public void PrintStack(Stack<ListNode> s)
    {
        Stack<ListNode> s_copy = new Stack<ListNode>(s);
        Console.WriteLine("\n+-- Stack --+");

        while(s_copy.Count > 0)
        {
            ListNode temp = s_copy.Peek();
            Console.WriteLine($"|\t  {temp.val}\t\t|");
            s_copy.Pop();
        }
        Console.WriteLine("~~~~~~~~~~~~~\n");
    }


    public void ReorderList(ListNode head) 
    {
        int i = 0;
        ListNode dummy = head;
        Stack<ListNode> s = new Stack<ListNode>();
        int length = -1;
        int j = 0;

        while(j<=3)
        {
            if(head is null)
            {
                length = i;
                head = dummy;
                j++;
                i = 0;
            }

            if(i > (length/2) && j == 2)
                s.Push(head);

            if(j == 3 && i == length/2)
            {
                head.next = null;
                break;
            }

            head = head.next;
            i++;
        }

        i = 0;
        head = dummy;
        int halfwaypoint = (length / 2);

        PrintStack(s);       

        
        while(i <= halfwaypoint && s.Count > 0)
        {
            dummy = head.next;

            head.next = s.Pop(); //should insert the stack node 
            head = head.next;

            head.next = dummy;
            head = head.next;
            i++;
        }
        
        PrintStack(s);
    }
}
