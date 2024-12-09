﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Strings_Hash
{
    public class ArrayExercises
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            var bestPrice = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                profit = Math.Max(profit, prices[i] - bestPrice);
                bestPrice = Math.Min(bestPrice, prices[i]);

            }            
            return profit;
        }
        public bool IsSubsequence(string s, string t)
        {
            if(s.Length == 0) return true;
            if(s.Length > t.Length) return false;
            if(t.Contains(s)) return true;
            var k = 0;
            for (int i = 0; i < t.Length; i++) 
            {
                if (t[i] == s[k]) 
                {
                    if(k == s.Length - 1)
                        return true;
                    k++;
                }
                    
            }
            return false;
        }
        public int FindClosestNumber(int[] nums)
        {
            var closest = nums[0];

            for (int i = 1; i < nums.Length; i++) 
            {
                if (nums[i] == 0) return 0;
                if (Math.Abs(nums[i]) < Math.Abs(closest))
                    closest = nums[i];
                if (Math.Abs(nums[i]) == Math.Abs(closest))
                    closest = nums[i] >= 0 ? nums[i] : closest;
            }
            return closest;
            
        }
        public string MergeAlternately(string word1, string word2)
        {
            string result = string.Empty;

            if (word1.Length < word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    result += $"{word1[i]}{word2[i]}";
                }
            }
            else 
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    result += $"{word1[i]}{word2[i]}";
                }
            }
            if (word1.Length > word2.Length)
                result += word1.Substring(word2.Length, word1.Length - word2.Length);
            if (word1.Length < word2.Length)
                result += word2.Substring(word1.Length, word2.Length - word1.Length);

            return result;
        }
        public int RomanToInt(string s)
        {
            var sum = 0;
            for (int i = 0; i < s.Length - 1; i++) 
            {
                var i1 = s[i];
                var i2 = s[i + 1];
                if (RomanValue(i1) < RomanValue(i2)) 
                {
                    sum -= RomanValue(i1);
                }
                else
                {
                    sum += RomanValue(i1);
                }
            }
            sum += RomanValue(s[s.Length - 1]);

            return sum;
        }
        private int RomanValue(char num) 
        {
            switch (num) 
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                default: return 1000;
            }
        }
    }
}