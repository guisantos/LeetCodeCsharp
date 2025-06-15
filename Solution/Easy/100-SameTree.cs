using LeetCode.Solution.Helpers;

namespace LeetCode.Solution.Easy;
public class SameTree
{
    public bool IsSameTreeRecursive(TreeNode p, TreeNode q)
    {
        return Traverse(p, q);
    }

    public bool Traverse(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null || q == null)
        {
            return false;
        }

        if (p.val != q.val)
        {
            return false;
        }

        return Traverse(p.left, q.left) && Traverse(p.right, q.right);
    }

    public bool IsSameTreeIterative(TreeNode p, TreeNode q)
    {
        var stack = new Stack<(TreeNode, TreeNode)>();
        stack.Push((p, q));

        while (stack.Count > 0)
        {
            var (nodeP, nodeQ) = stack.Pop();
            if (nodeP == null && nodeQ == null)
            {
                continue;
            }

            if (nodeP == null || nodeQ == null)
            {
                return false;
            }

            if (nodeP.val != nodeQ.val)
            {
                return false;
            }

            stack.Push((nodeP.left, nodeQ.left));
            stack.Push((nodeP.right, nodeQ.right));
        }

        return true;
    }
}
