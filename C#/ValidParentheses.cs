using System;

public class ValidParentheses
{
    /*
        Given a string s containing only:

        ( ) [ ] { }

        determine if the parentheses are valid.

        A string is valid if:

        Every opening bracket has a matching closing bracket.
        Brackets are closed in the correct order.
        Brackets of different types are properly nested.

        "()"       → true
        "()[]{}"   → true
        "(]"       → false
        "([)]"     → false
        "{[]}"     → true
    */
    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char opening = stack.Pop();

                if (c == ')' && opening != '(')
                {
                    return false;
                }

                if (c == ']' && opening != '[')
                {
                    return false;
                }

                if (c == '}' && opening != '{')
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}