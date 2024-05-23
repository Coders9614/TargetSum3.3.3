using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetSum3._3._3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);

            Console.WriteLine($"digit 2 + 7 = targeted sum : 9 index number [{result[0]}, {result[1]}]");
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // Iterate through each element in the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Iterate through the array starting from the next element
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Check if the sum of nums[i] and nums[j] is equal to the target
                    if (nums[i] + nums[j] == target)
                    {
                        // If found, return value i and j 
                        return new int[] { i, j };
                        Console.WriteLine(i + "," + j); 
                    }
                }
            }

            // to indicate an error in the logic or input.
            // This part will not be reached because the problem guarantees a solution.
            return new int[] { };
        
        }
    }
}
