public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;

        for(int i = 0; i < heights.Length; i++)
        {
            while(stack.Count > 0 && heights[i] < heights[stack.Peek()])
            {
                int popped = stack.Pop();
                int height = heights[popped];
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, height*width);
            }
            stack.Push(i);
        }

        while(stack.Count > 0)
        {
            int popped = stack.Pop();
            int height = heights[popped];
            int width = stack.Count == 0 ? heights.Length : heights.Length - stack.Peek() - 1;            
            maxArea = Math.Max(maxArea, height*width);
        }

        return maxArea;
    }
}
