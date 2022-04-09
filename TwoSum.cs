

//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] result = new int[2] {int.MaxValue, int.MaxValue};
        int[] resultIndexes = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= result[0])
            {
                result[0] = nums[i];
                resultIndexes[0] = i;
            }
            else if (nums[i] < result[1])
            {
                result[1] = nums[i];
                resultIndexes[1] = i;
            }
        }

        return resultIndexes;
    }
}