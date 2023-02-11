Title: Problem Solving Fundamentals Review

Description: 
This repository is a part of an effort to improve my fundamental problem solving skills through completing LeetCode challenges. 
While I am familiar with array and array concepts, I am returning to Arrays 101 on LeetCode to reinforce 
the fundamentals of arrays and problem solving. I will be completing the challenges in the course and provide solution commentary as to why and how the solution works to give insight into the thought process 
of solving that particualt challenge.

link to LeetCodeArrays101: https://leetcode.com/explore/learn/card/fun-with-arrays/



Problem #1: Max Consecution Ones

Prompt:  
Given a binary array nums, return the maximum number of consecutive 1's in the array.
sample input: 
Input: nums = [1,1,0,1,1,1]
Output: 3

Input: nums = [1,0,1,1,0,1]
Output: 2

Discussion: 
In the code I am first checking for any boundary conditions to avoid exceptions and to check if any code needs to be run. 
For instance if the input is has only one digit and that digit is one, then return 1 there is no neeed to enter the loop.
This prompt asks for the maximum number of one's versus the maximum number of a given and my goal was to use pointers 
in order to only traverse the array once.



