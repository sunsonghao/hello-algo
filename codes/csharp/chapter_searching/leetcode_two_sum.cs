﻿/**
 * File: leetcode_two_sum.cs
 * Created Time: 2022-12-23
 * Author: haptear (haptear@hotmail.com)
 */

using NUnit.Framework;

namespace hello_algo.chapter_searching;

public class leetcode_two_sum
{
    /* 方法一：暴力枚举 */
    public static int[] twoSumBruteForce(int[] nums, int target)
    {
        int size = nums.Length;
        // 两层循环，时间复杂度 O(n^2)
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return new int[0];
    }

    /* 方法二：辅助哈希表 */
    public static int[] twoSumHashTable(int[] nums, int target)
    {
        int size = nums.Length;
        // 辅助哈希表，空间复杂度 O(n)
        Dictionary<int, int> dic = new();
        // 单层循环，时间复杂度 O(n)
        for (int i = 0; i < size; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                return new int[] { dic[target - nums[i]], i };
            }
            dic.Add(nums[i], i);
        }
        return new int[0];
    }

    [Test]
    public void Test()
    {
        // ======= Test Case =======
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // ====== Driver Code ======
        // 方法一
        int[] res = twoSumBruteForce(nums, target);
        Console.WriteLine("方法一 res = " + string.Join(",", res));
        // 方法二
        res = twoSumHashTable(nums, target);
        Console.WriteLine("方法二 res = " + string.Join(",", res));
    }
}
