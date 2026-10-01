using System;
using System.Collections.Generic;

public class TwoSum
{
    /*
        Given an array of integers nums and an integer target, return the indices of the two numbers that add up to target.

        You may assume:

        There is exactly one solution.
        You cannot use the same element twice.
    */

    public static int[] TwoSumSolution(int[] nums, int target)
    {
        if(nums.Length < 1) { return Array.Empty<int>(); }

        int[] ret = new int[2];
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(seen.TryGetValue(target - nums[i], out int index))
            {
                ret[1] = i;
                ret[0] = index;
                return ret;
            } 
            else
            {
                seen.TryAdd(nums[i], i);
            }
        }
        return ret;
    }
}