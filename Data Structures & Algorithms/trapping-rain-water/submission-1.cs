public class Solution {
    public int Trap(int[] height) 
    {
        int area = 0;
        int left = 0;
        int right = height.Length-1;

        int leftMax = -1;
        int rightMax = -1;

        while(left < right)
        {
            if(height[left] > leftMax)
                leftMax = height[left];
            
            if(height[right] > rightMax)
                rightMax = height[right]; 

            if(height[left] < height[right])
                area += (leftMax - height[left++]);
            
            else
                area += (rightMax - height[right--]);
            
        }
        return area;
    }
}
