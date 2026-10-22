using System;
using System.Xml;
using Microsoft.VisualBasic;

public class GroupAnagrams
{
    /*
        Given an array of strings strs, group the anagrams together.
        You can return the groups in any order.
        Two strings are anagrams if they contain the same characters with the same
        frequencies.

        Examples:

        Input: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
        Output: [["bat"], ["nat", "tan"], ["eat", "tea", "ate"]]

        Input: strs = [""]
        Output: [[""]]

        Input: strs = ["a"]
        Output: [["a"]]

        Constraints:
        - strs[i] consists of lowercase English letters.
    */
    public static IList<IList<string>> GroupAnagramsSolution(String[] strs)
    {
        Console.WriteLine("\n\n=== GroupAnagramsSolution START ===");
        Console.WriteLine($"Input: [{string.Join(", ", strs)}]");
        Console.WriteLine($"Number of input strings: {strs.Length}");

        Dictionary<string, List<string>> stringDictionary = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            Console.WriteLine($"Original string: \"{strs[i]}\"");

            char[] stringAsChar = strs[i].ToCharArray();
            Array.Sort<char>(stringAsChar);

            string sorted = new string(stringAsChar);
            Console.WriteLine($"Generated key: \"{sorted}\"");

            Console.WriteLine($"Dictionary contains key? {stringDictionary.Keys.Contains(sorted)}");
            if (stringDictionary.Keys.Contains(sorted))
            {
                Console.WriteLine($"Key \"{sorted}\" exists. Appending \"{strs[i]}\".");
                stringDictionary[sorted].Add(strs[i]);
            }
            else
            {
                Console.WriteLine($"Key \"{sorted}\" does not exist. Creating a new group.");
                stringDictionary.Add(sorted, new List<string>([strs[i]]));
            }

            Console.WriteLine("Dictionary state:");
            foreach (var entry in stringDictionary)
            {
                Console.WriteLine($"  Key: \"{entry.Key}\" -> [{string.Join(", ", entry.Value)}]");
            }
        }

        Console.WriteLine("\n--- Building result ---");

        IList<IList<string>> result = new List<IList<string>>();

        foreach (string key in stringDictionary.Keys)
        {
            Console.WriteLine($"Adding group for key \"{key}\": [{string.Join(", ", stringDictionary[key])}]");
            result.Add(stringDictionary[key]);
        }

        Console.WriteLine($"Total groups returned: {result.Count}");
        Console.WriteLine("Final result:");

        foreach (var group in result)
        {
            Console.WriteLine($"  [{string.Join(", ", group)}]");
        }

        Console.WriteLine("=== GroupAnagramsSolution END ===\n\n");

        return result;
    }
}