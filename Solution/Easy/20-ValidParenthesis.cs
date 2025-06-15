namespace LeetCode.Solution.Easy;
public class ValidParenthesis
{
    // https://www.youtube.com/watch?v=YwvHeouhy6s
    // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
    // determine if the input string is valid.
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (var bracket in s)
        {
            // if dictionary contains the opening bracket, push it onto the stack
            if (pairs.ContainsKey(bracket))
            {
                stack.Push(bracket);
            }
            // if the stack is empty or the current closing bracket does not match the last opening bracket
            else if (stack.Count == 0 || bracket != pairs[stack.Pop()])
            {
                return false;
            }
        }
        return stack.Count == 0;
    }


    // Alternative implementation using an array as a stack
    public bool IsValidArray(string s)
    {
        // Early exit if string length is odd (can't be valid)
        if (s.Length % 2 != 0)
            return false;

        char[] stack = new char[s.Length];
        int top = -1;

        foreach (char c in s)
        {
            // Push if opening
            if (c == '(' || c == '{' || c == '[')
            {
                stack[++top] = c;
            }
            else
            {
                // If stack is empty or top doesn't match opening pair
                if (top < 0 ||
                    c == ')' && stack[top] != '(' ||
                    c == '}' && stack[top] != '{' ||
                    c == ']' && stack[top] != '[')
                {
                    return false;
                }
                top--; // Pop the stack
            }
        }

        // Valid if stack is empty
        return top == -1;
    }
}
