/*
Given an array of integers nums and an integer target, return the indices of the two numbers that add up to target.

You may assume:

There is exactly one solution.
You cannot use the same element twice.
*/

using System;

class TwoSum
{
    public static int[] TwoSumSolution(int[] nums, int target)
    {
        if(nums.Length < 1) { return Array.Empty<int>(); }

        int[] ret = new int[2];
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(seen.TryGetValue(target - nums[i], out int index))
            {
                ret[0] = i;
                ret[1] = index;
                return ret;
            } 
            else
            {
                seen.TryAdd(nums[i], i);
            }
        }
    }

    static void Test(int[] nums, int target)
    {
        int[] result = TwoSumSolution(nums, target);

        Console.WriteLine(
            $"nums = [{string.Join(", ", nums)}], " +
            $"target = {target} " +
            $"=> [{result[0]}, {result[1]}]"
        );
    }

    static void Main()
    {
        Test(new int[] { 2, 7, 11, 15 }, 9);
        Test(new int[] { 3, 2, 4 }, 6);
        Test(new int[] { 3, 3 }, 6);

        Test(new int[] { 1, 5, 8, 10 }, 11);
        Test(new int[] { 10, -2, 7, 3 }, 1);
        Test(new int[] { -3, 4, 3, 90 }, 0);

        Test(new int[] { 0, 4, 3, 0 }, 0);
        Test(new int[] { -1, -2, -3, -4, -5 }, -8);
    }
}