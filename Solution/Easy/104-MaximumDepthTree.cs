using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Solution.Helpers;

namespace LeetCode.Solution.Easy;
public class MaximumDepthTree
{
    public int MaxDepthDFSIterative(TreeNode root)
    {
        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, 1));
        var result = 0;

        while (stack.Count > 0)
        {
             var (node, depth) = stack.Pop();

             if (node != null)
             {
                 result = Math.Max(result, depth);
                stack.Push((node.left, depth+ 1));
                stack.Push((node.right, depth+ 1));
             }
        }

        return result;
    }

    public int MaxDepthDFSRecursive(TreeNode root)
    {
        return 1 + Math.Max(MaxDepthDFSRecursive(root.left), MaxDepthDFSRecursive(root.right));
    }

    public int MaxDepthBFS(TreeNode root)
    {
        if (root == null) return 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int depth = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count; // Number of nodes at current level

            // Process all nodes at this level
            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            // Increment depth after finishing a level
            depth++;
        }

        return depth;
    }


}
