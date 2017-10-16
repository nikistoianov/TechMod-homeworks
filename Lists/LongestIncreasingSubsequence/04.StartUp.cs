using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //List<int> result = GetLIS(arr);

            //Console.WriteLine(string.Join(" ", result));
            Console.WriteLine(GetLIS(arr));
        }

        private static List<int> GetLIS_MemLimit(int[] arr)
        {
            List<List<int>> nums = new List<List<int>>();

            int maxLenght = 1;

            foreach (int item in arr)
            {
                int loopEnd = nums.Count;
                bool itemAdded = false;
                for (int i = 0; i < loopEnd; i++)
                {
                    int lastNum = nums[i].Count - 1;
                    if (nums[i][lastNum++] < item)
                    {
                        nums.Add(new List<int>(nums[i].ToArray()));
                        nums[nums.Count - 1].Add(item);
                        itemAdded = true;
                        maxLenght = Math.Max(maxLenght, lastNum + 1);
                    }
                }
                if (!itemAdded)
                {
                    nums.Add(new List<int> { item });
                }
            }
            
            foreach (List<int> singleNums in nums)
            {
                if (singleNums.Count == maxLenght)
                {
                    return singleNums;
                }
            }
            return new List<int>();
        }

        private static int GetLIS2(int[] arr)
        {
            int[] dp = new int[arr.Length];
            int maxSizeOfSubseq = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                dp[i] = 1;
                maxSizeOfSubseq = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] < arr[i] && dp[j] > maxSizeOfSubseq)
                    {
                        maxSizeOfSubseq = dp[j];
                    }
                }
                dp[i] = dp[i] + maxSizeOfSubseq;
                //System.out.println(dp[dp.length - 1]);
            }


            // Now find the Max Size Of Subsequence amongst all computes subsequence lengths
            maxSizeOfSubseq = 0;
            for (int count = 0; count < dp.Length; ++count)
            {
                if (dp[count] > maxSizeOfSubseq)
                {
                    maxSizeOfSubseq = dp[count];
                }
            }

            return maxSizeOfSubseq;
        }

        static public string GetLIS(int[] s)
        {
            int[] l = new int[s.Length];  // DP table for max length[i]
            int[] p = new int[s.Length];  // DP table for predeccesor[i]
            string[] results = new string[s.Length];
            int max = int.MinValue;

            l[0] = 1;

            for (int i = 0; i < s.Length; i++)
                p[i] = -1;

            results[0] = s[0].ToString();

            for (int i = 1; i < s.Length; i++)
            {
                l[i] = 1;
                
                for (int j = 0; j < i; j++)
                {
                    if (s[j] < s[i] && l[j] + 1 > l[i])
                    {
                        //results[i] += s[j] + " ";
                        //Console.Write(" " + s[j]);
                        results[i] = results[j];
                        l[i] = l[j] + 1;
                        p[i] = j;
                        if (l[i] > max)
                            max = l[i];
                    }
                }
                results[i] += " " + s[i];
                //Console.WriteLine($"i={i} --> {results[i]} --> max={l[i]}");
            }

            int maxID = 0;
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i] == max)
                {
                    maxID = i;
                    break;
                }
            }

            return results[maxID].Trim();

            //Console.WriteLine(results[maxID].Trim());

            //return max;
        }
    }
}
