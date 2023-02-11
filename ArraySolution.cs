using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
            if (nums == null || nums.Length == 1 && nums[0] != 1)
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

        public int findNumbers(int[] nums)
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


        /**
        Given an integer array nums sorted in non-decreasing order,
        return an array of the squares of each number sorted in non-decreasing order.
        
        Example 1:

        Input: nums = [-4, -1, 0, 3, 10]
        Output: [0,1,9,16,100]
        Explanation: After squaring, the array becomes[16, 1, 0, 9, 100].
        After sorting, it becomes [0,1,9,16,100].
        Example 2:

        Input: nums = [-7, -3, 2, 3, 11]
        Output: [4,9,9,49,121]
        **/

        public int[] sortedSquares(int[] nums)
        {
            int n = nums.Length;
            int left = 0;
            int right = n - 1;
            int[] result = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                int square = 0;
                if (Math.Abs(nums[left]) < Math.Abs(nums[right])) {
                    square = nums[right];
                    right--;
                } else
                {
                    square = nums[left];
                    left++; 
                }
                result[i] = square * square;
            }

            return result;

        }

        // Example function to insert items into an empty array and returns the new array
        // used as a utility function to work with future array problems that need an array created
        // example inserting and deleting exercises;

        // test cases: 

        public int[] insertValuesIntoArray(int lengthOfArray, int rangeEnd)
        {
            if (rangeEnd > lengthOfArray)
            {
                throw new IndexOutOfRangeException();
            }

            int[] a = new int[lengthOfArray];


            for (int i = 0; i < rangeEnd; i++)
            {
                a[i] = i;
            }

            return a;

        }

        // Example: insert items at the begining of an array
        // assuming that an array has at least one spot left at the end
        // insert one item at the end of an array of numbers
        // item is the item to be inserted at the end of the array
        // length is the length of the array to be passed into helper function
        public int[] insertItemAtStartOfArray(int item, int length)
        {
            // for this example length should be at least one more then range
            int[] intArray = insertValuesIntoArray(length, length - 1);

            //shift everything over

            // needed to reverse teh array to avoid over writing
            // length needed to be lebgth -2 so not out of bounds

          for (int i = length - 2; i >= 0; i--)
            {
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = item;

            return intArray;
        }


        // A function that inserts items at the end of an array

        public void insertAtEnd()
        {

        }

        // A function that inserts items in the middle of an array

        public void insertInTheMiddle()
        {

        }


        




    }
}
