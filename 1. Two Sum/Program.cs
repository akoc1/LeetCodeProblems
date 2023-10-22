using System;
using System.Collections.Generic;

namespace two_sum
{
    internal class Program
    {
        private int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target && j != i)
                    {
                        Console.WriteLine("[" + i.ToString() + ", " + j.ToString() + "]");
                        return new int[] { i, j };
                    }
                }
            }
            
            return null;
        }
        
        public static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = {3, 3};
            int target = 6;
            program.TwoSum(nums, target);
        }
    }
}