namespace LeetCode;
public class RomanToInteger
{
    public int RomanToInt(string s)
    {
        var romanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        var total = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            // if the current roman numeral is less than the next one, we subtract it from the total
            // handles case like IV (4) or IX (9) etc.
            if (romanMap[s[i]] < romanMap[s[i + 1]])
            {
                total -= romanMap[s[i]];
            }
            // if the current roman numeral is greater than or equal to the next one, we add it to the total
            else
            {
                total += romanMap[s[i]];
            }
        }

        return total + romanMap[s[s.Length - 1]];
    }

    public int RomanToIntReversed(string s)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = romanMap[s[i]];

            if (currentValue < prevValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }

    public int RomanToIntWithReplace(string s)
    {
        var romanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        var total = 0;
        s = s.Replace("IV", "IIII")
            .Replace("IX", "VIIII")
            .Replace("XL", "XXXX")
            .Replace("XC", "LXXXX")
            .Replace("CD", "CCCC")
            .Replace("CM", "DCCCC");

        foreach (var character in s)
        {
            total += romanMap[character];
        }

        return total;
    }
}