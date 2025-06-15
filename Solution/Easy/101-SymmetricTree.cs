using LeetCode.Solution.Helpers;

namespace LeetCode.Solution.Easy;
public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root)
    {
        return Traverse(root.left, root.right);
    }

    public bool Traverse(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
        {
            return true;
        }

        if (left == null || right == null)
        {
            return false;
        }

        return left.val == right.val && Traverse(left.left, right.right) && Traverse(left.right, right.left);
    }


    public bool IsSymmetricIterative(TreeNode root)
    {
        if (root == null) return true;

        // Queue stores pairs of nodes to compare
        Queue<(TreeNode, TreeNode)> queue = new();
        queue.Enqueue((root.left, root.right));

        while (queue.Count > 0)
        {
            var (left, right) = queue.Dequeue();

            // If both nodes are null, continue to next pair
            if (left == null && right == null) continue;

            // If only one is null or values mismatch → not symmetric
            if (left == null || right == null || left.val != right.val)
                return false;

            // Add the mirrored children to the queue
            queue.Enqueue((left.left, right.right));
            queue.Enqueue((left.right, right.left));
        }

        return true;
    }
}
