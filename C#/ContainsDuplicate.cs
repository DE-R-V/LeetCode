using System;

public class ContainsDuplicate
{
    /*
        Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        Examples:

        Input: nums = [1,2,3,1]
        Output: true

        Input: nums = [1,2,3,4]
        Output: false

        Input: nums = [1,1,1,3,3,4,3,2,4,2]
        Output: true
    */
    public static bool ContainsDuplicateSolution(int[] nums)
    {
        if(nums.Length <= 1) { return false; }

        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(occurrences.TryGetValue(nums[i], out int count)) {
                return true;
            } 
            else {
                occurrences[nums[i]] = 1;
            }
        }

        return false;
    }
}