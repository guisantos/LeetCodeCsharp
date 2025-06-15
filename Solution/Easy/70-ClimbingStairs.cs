namespace LeetCode.Solution.Easy;
public class ClimbingStairs
{
    //https://www.youtube.com/watch?v=4ikxUxiEB10
    /// <summary>
    /// Returns the number of ways to climb n stairs, taking 1 or 2 steps at a time.
    /// Time Complexity: O(n)
    /// Space Complexity: O(1)
    /// </summary>
    public int ClimbStairs(int n)
    {
        // Base case: only one way to climb 1 stair
        if (n == 1)
        {
            return 1;
        }

        // Initialize the two previous values:
        // ways to climb 0 and 1 stairs are both 1
        var oneBefore = 1;
        var twoBefore = 1;
        var result = 0;

        // Build the solution from the bottom up
        for (var i = 2; i <= n; i++)
        {
            result = oneBefore + twoBefore; // dp[i] = dp[i - 1] + dp[i - 2]
            twoBefore = oneBefore;          // Shift for next iteration
            oneBefore = result;
        }

        return result;
    }

    /// <summary>
    /// Returns the number of ways to climb n stairs using recursion with memoization.
    /// Time Complexity: O(n)
    /// Space Complexity: O(n) for recursion stack and memo array
    /// </summary>
    public int ClimbStairsRecursive(int n)
    {
        var memo = new int[n + 1]; // Stores previously computed values
        return Climb(n, memo);
    }

    /// <summary>
    /// Helper method for top-down recursion with memoization.
    /// </summary>
    private int Climb(int n, int[] memo)
    {
        // Base case: 0 or 1 stair has only one way to climb
        if (n <= 1) return 1;

        // Return memoized value if it exists
        if (memo[n] > 0) return memo[n];

        // Compute and store result
        memo[n] = Climb(n - 1, memo) + Climb(n - 2, memo);
        return memo[n];
    }

    /// <summary>
    /// Returns the number of ways to climb n stairs using bottom-up dynamic programming.
    /// Time Complexity: O(n)
    /// Space Complexity: O(n)
    /// </summary>
    public int ClimbStairsDynamicProgrammingArray(int n)
    {
        // Base cases
        if (n <= 1) return 1;

        // dp[i] = number of ways to reach step i
        var dp = new int[n + 1];
        dp[0] = 1; // 1 way to do nothing
        dp[1] = 1; // 1 way to climb 1 step

        // Fill the dp array from 2 to n
        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2]; // Choose 1 or 2 steps
        }

        return dp[n];
    }
}
