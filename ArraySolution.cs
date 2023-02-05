using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays101LeetCode
{
    public class ArraySolution
    {
        //Given a binary array nums, return the maximum number of consecutive 1's in the array.
        //sample input: 
        // Input: nums = [1,1,0,1,1,1]
        // Output: 3

        //Input: nums = [1,0,1,1,0,1]
        // Output: 2

        public int maxConsecutiveOnes(int[] nums)
        {
            //boundary conditions
            if (nums == null)
            {
                return 0;
            }

            if (nums.Length == 1 && nums[0] == 1)
            {
                return 1;
            } 

            int left = 0;
            int right = left + 1;
            int maxConsecutive = 1;
            int count = 0;

            // this checks for max consecutive numbers convert to check for only 1's

            if (Array.Exists(nums, element => element == 1))
            {
                count++;
            } else
            {
                return 0;
            }

            while (right < nums.Length)
            {
                if (nums[left] == nums[right] && nums[left] == 1)
                {
                    count++;
                    right++;

                    if (count > maxConsecutive)
                    {
                        maxConsecutive = count;
                    }
                } else
                {
                    //need to reset count to 1 to avoid over counting
                    left = right;
                    right++;
                    count = 1;
                }
            }
            return maxConsecutive;
        }


        // Given an array nums of integers, return how many of them contain an even number of digits.



        //Example 1:

        //Input: nums = [12, 345, 2, 6, 7896]
        //Output: 2
        //Explanation: 
        //12 contains 2 digits(even number of digits). 
        //345 contains 3 digits(odd number of digits). 
        //2 contains 1 digit(odd number of digits). 
        //6 contains 1 digit(odd number of digits). 
        //7896 contains 4 digits(even number of digits). 
        //Therefore only 12 and 7896 contain an even number of digits.

        public int FindNumbers(int[] nums)
        {
          
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            
           int count = 0;
           foreach (var num in nums)
            {
                string numString = "";
                numString = num.ToString();

                if (numString.Length % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
