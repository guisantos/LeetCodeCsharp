namespace LeetCode.Solution.Easy;
public class LengthOfLastWord
{
    // https://www.youtube.com/watch?v=rxb7umOJScc
    public int LengthOfLastWordSolution(string s)
    {
        // hold the length of the last word in the string
        var length = 0;
        // use this to traverse the string from last character to beginning
        var i = s.Length - 1;
        // skip trailing spaces
        // finding the last character of the last word
        while (i >= 0 && s[i] == ' ')
        {
            i--;
        }

        // iterate backwards until we find a space or reach the beginning of the string
        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }

    // Easier to understand but less efficient and maybe not accepted because of the Reverse()
    public int LengthOfLastWordSolution2(string s)
    {
        int length = 0;

        foreach (char c in s.Reverse())
        {
            if (c == ' ')
            {
                if (length > 0)
                    break;
            }
            else
            {
                length++;
            }
        }

        return length;
    }
}
