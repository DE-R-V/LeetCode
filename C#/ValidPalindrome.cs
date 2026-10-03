using System;

public class ValidPalindrome
{
    /*
        Given a string s, return true if it is a palindrome, considering only alphanumeric characters and ignoring cases.
        A palindrome is a string that reads the same forward and backward.

        Examples:
        Input: s = "A man, a plan, a canal: Panama"
        Output: true
        Input: s = "race a car"
        Output: false
        Input: s = " "
        Output: true

        Constraints:

        - 1 <= s.length <= 2 * 10^5
        - s consists only of printable ASCII characters.

        Try to solve it in O(n) time and O(1) extra space.
    */
    
    public static bool IsPalindrome(string s)
    {
        Console.WriteLine("---- NEW PALINDROME ----");
        bool isPalindrome = true;
        char[] chars = s.ToUpper().ToCharArray();
        int i = 0, j = chars.Length - 1;
        if( s.Length > 1) {
            while( isPalindrome && i < j)
            {
                if(char.IsLetterOrDigit(chars[i]) && char.IsLetterOrDigit(chars[j])) {
                    isPalindrome = isPalindrome && chars[i] == chars[j];
                    i++;
                    j--;
                } else if(!char.IsLetterOrDigit(chars[i]) && char.IsLetterOrDigit(chars[j])) {
                    i++;
                } else if(char.IsLetterOrDigit(chars[i]) && !char.IsLetterOrDigit(chars[j])) {
                    j--;
                } else {
                    i++;
                    j--;
                }
            }
        }
        return isPalindrome;
    }
}