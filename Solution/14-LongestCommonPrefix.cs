namespace LeetCode;
public class LongestCommonPrefix
{
    // flower, flow, flight - "fl"
    // https://www.youtube.com/watch?v=SiNDN2M4dtQ
    public string LongestCommonPrefixSolution(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        var baseWord = strs[0];

        for (int i = 0; i < baseWord.Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                var word = strs[j];
                if (i == word.Length || word[i] != baseWord[i])
                {
                    return baseWord[..i];
                }
            }
        }

        return baseWord;
    }

    public string LongestCommonPrefixSolution2(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        var prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            // While the current string does not start with the prefix,
            // remove the last character from the prefix and try again
            while (!strs[i].StartsWith(prefix))  // equivalent to prefix.Substring(0, prefix.Length - 1)
            {
                prefix = prefix[..^1];

                // If prefix becomes empty, there is no common prefix
                if (prefix.Length == 0)
                    return string.Empty;
            }
        }

        return prefix;
    }
}
