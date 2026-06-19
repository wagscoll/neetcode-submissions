public class Solution {
    public int MaxArea(int[] heights) 
    {
        int left = 0;
        int right = heights.Length-1;

        int maxHeight = 0;
        int minHeight = -1;

        int distance = 0;

        int area = -1;
        int maxArea = -1;

        while(left <= right || right >= left)
        {
            minHeight = Math.Min(heights[left], heights[right]);

            distance = (right - left); 
            area = minHeight * distance;

            if(maxArea < area)
                maxArea = area;

            if(heights[left] <= heights[right])
                left++;
            
            else
                right--;
        }

        return maxArea;
    }
}

 































