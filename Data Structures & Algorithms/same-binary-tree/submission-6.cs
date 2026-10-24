/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if(p is not null || q is not null)
        {
            if(p is null || q is null)
                return false;
                
            stack.Push(p);
            stack.Push(q);
        }
         else
            return true;

        while(stack.Count > 0)
        {
            q = stack.Pop();
            p = stack.Pop();

            if(p.val == q.val)
            {
                if(p.left is not null || q.left is not null)
                {
                    if(p.left is null || q.left is null)
                        return false;
                    
                    stack.Push(p.left);
                    stack.Push(q.left);
                }
                
                if(p.right is not null || q.right is not null)
                {
                    if(p.right is null || q.right is null)
                        return false;
                    
                    stack.Push(p.right);
                    stack.Push(q.right);
                }
            }
            else
                return false;    
        }
        return true;
    }
}
