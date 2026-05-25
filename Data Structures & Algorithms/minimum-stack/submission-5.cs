public class MinStack {

    List<int> stack = new List<int>();
    List<int> minValue = new List<int>();

    public MinStack() 
    {
    }
    
    public void Push(int val) {
        stack.Add(val);

        //if minValue is empty OR val <= the most recent list entry
        if(minValue.Count == 0 || val <= minValue[minValue.Count - 1]) 
            minValue.Add(val);
    }
    
    public void Pop() {
        if(stack[stack.Count - 1] == minValue[minValue.Count - 1])
            minValue.RemoveAt(minValue.Count - 1);
        
        stack.RemoveAt(stack.Count - 1);
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return minValue[minValue.Count - 1];
    }
}
