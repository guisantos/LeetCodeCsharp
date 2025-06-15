using LeetCode.Solution.Helpers;

namespace LeetCode.Solution.Easy;
public class BinaryTreeInorderTraversal
{
    public IList<int> InorderTraversalRecursive(TreeNode root)
    {
        var result = new List<int>();

        Traverse(root, result);

        return result;
    }

    public void Traverse(TreeNode root, List<int> result)
    {
        if (root == null)
        {
            return;
        }

        Traverse(root.left, result);
        result.Add(root.val);
        Traverse(root.right, result);
    }

    public IList<int> InorderTraversalIterative(TreeNode root)
    {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var current = root;

        while (current != null || stack.Count > 0)
        {
            // Reach the leftmost node of the current node
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            // current is null here; process the top of the stack
            current = stack.Pop();
            result.Add(current.val);

            // Visit the right subtree
            current = current.right;
        }

        return result;
    }
}
