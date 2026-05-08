public class MinStack {

    private List<int> stack;
    private List<int> tempStack;

    public MinStack() {
        stack = new List<int>();
    }
    
    public void Push(int val) {
        stack.Add(val);
    }
    
    public void Pop() {

        if (stack.Count == 0) return;

        stack.RemoveAt(stack.Count - 1);
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        tempStack = new List<int>();

        foreach (int value in stack){
            tempStack.Add(value);
        }

        tempStack.Sort();

        return tempStack[0];
    }
}
