using System;

public class ValidAnagram
{
    /*
        Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        An anagram is a word or phrase formed by rearranging the letters of another word or phrase, using all the original letters exactly once.

        Examples:

        Input: s = "anagram", t = "nagaram"
        Output: true

        Input: s = "rat", t = "car"
        Output: false

        Input: s = "listen", t = "silent"
        Output: true

        Input: s = "hello", t = "bello"
        Output: false

        Constraints:

        - 1 <= s.length, t.length <= 5 * 10^4
        - s and t consist of lowercase English letters.
    */
    public static bool ValidAnagramSolution(string s, string t)
    {

        if( s.Length == 0 || t.Length == 0 || s.Length != t.Length) { return false; }

        Dictionary<char, int> occurrences = new Dictionary<char, int>();

        int i = 0;
        bool result = true;
        while(i < s.Length && i < t.Length)
        {
            if(!occurrences.TryAdd(s[i], 1))
            {
                occurrences[s[i]] = occurrences[s[i]] + 1;
            }
            if(!occurrences.TryAdd(t[i], -1))
            {
                occurrences[t[i]] = occurrences[t[i]] -1;
            }
            i++;
        }

        foreach(int value in occurrences.Values) {
            result = result && value == 0;
        }

        return result;
    }
}