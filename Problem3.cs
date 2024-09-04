using System.Runtime.InteropServices;

namespace Problem3;
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seenChars = [];
        int length = 0;
        int startIndex = 0;
        char[] chars = s.ToCharArray();
        for (int endIndex=0; endIndex<chars.Length; endIndex++)
        {
            char currentChar = chars[endIndex];
            while(seenChars.Contains(currentChar))
            {
                seenChars.Remove(chars[startIndex]);
                startIndex++;
            }

            seenChars.Add(currentChar);
            length = Math.Max(length, endIndex + 1 - startIndex);
        }

        return length;
    }

    public void RunTests()
    {
        string s;
        s = "dvdf";
        WriteResult(s, LengthOfLongestSubstring(s), 3);

        s = " ";
        WriteResult(s, LengthOfLongestSubstring(s), 1);

        s = " ab ccd efg ";
        WriteResult(s, LengthOfLongestSubstring(s), 6);

        s = "tmmzuxt";
        WriteResult(s, LengthOfLongestSubstring(s), 5);

        s = "2134908765a;lkjsdfzxcoviu";
        WriteResult(s, LengthOfLongestSubstring(s), 25);

        s = "abc!@#$%^&*()_+{}abcbb";
        WriteResult(s, LengthOfLongestSubstring(s), 17);

        s = "bbbbb";
        WriteResult(s, LengthOfLongestSubstring(s), 1);

        s = "pwwkew";
        WriteResult(s, LengthOfLongestSubstring(s), 3);

        s = "au";
        WriteResult(s, LengthOfLongestSubstring(s), 2);
    }

    public static void WriteResult(string s, int length, int expected){
        bool passed = length == expected;
//        if (passed) return;
        Console.WriteLine($"Input: s = \"{s}\"");
        Console.WriteLine($"Output: {length}");
        Console.WriteLine($"Expected: {expected}");
        Console.WriteLine(passed ? "Pass":"Fail");
        Console.WriteLine();
    }
}