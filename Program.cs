using System;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            int[] nums = new int[]{3,2,3}; 
            int target = 6;
            int[] result = sol.TwoSum(nums, target);

            Console.WriteLine(result[0] +"," + result[1]);


        }
    }
}
