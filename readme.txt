Title: Problem Solving Fundamentals Review

Description: 
This repository is a part of an effort to improve my fundamental problem solving skills through completing LeetCode challenges. 
While I am familiar with array and array concepts, I am returning to Arrays 101 on LeetCode to reinforce 
the fundamentals of arrays and problem solving. I will be completing the challenges in the course and provide solution commentary as 
to why and how the solution works to give insight into the thought process of solving that particular challenge.

link to LeetCodeArrays101: https://leetcode.com/explore/learn/card/fun-with-arrays/


SECTION: INTRODUCTION

Problem #1: Max Consecution Ones

Prompt:  
Given a binary array nums, return the maximum number of consecutive 1's in the array.
sample input: 
Input: nums = [1,1,0,1,1,1]
Output: 3

Input: nums = [1,0,1,1,0,1]
Output: 2

Discussion: 
In the code I am first checking for any boundary conditions to avoid exceptions and to check if any code needs to be executed. 
For instance, if the input is has only one digit and that digit is one, then return 1 there is no neeed to enter the loop.
This prompt asks for the maximum number of one's versus the maximum number of a given number passed into he function and my goal was to use pointers 
in order to only traverse the array once.

Problem #2: Find Numbers
Prompt:  Given an array of integers, return how many of them contain an even number of digits.

Example 1:
Input: nums = [12, 345, 2, 6, 7896]
Output: 2
Explanation: 
12 contains 2 digits(even number of digits). 
345 contains 3 digits(odd number of digits). 
2 contains 1 digit(odd number of digits). 
6 contains 1 digit(odd number of digits). 
7896 contains 4 digits(even number of digits). 
Therefore only 12 and 7896 contain an even number of digits.

Discussion: 

Problem #3: Squares of a Sorted Array
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

Discussion:

SECTION: INSERTING ITEMS INTO AN ARRAY

Sample insert fucntion

        







