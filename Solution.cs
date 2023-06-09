﻿public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsPalindrome(10));
        Console.WriteLine(solution.IsPalindrome(3003));
        Console.WriteLine(solution.ContainsDuplicate( new int[]{ 1,2,3}));
        Console.WriteLine(solution.ContainsDuplicate(new int[] { 1, 2, 1 }));
        String[] fizz = (String[]) solution.FizzBuzz(15);
        for (int i = 0; i < fizz.Length; i++)
            Console.Write(fizz[i]);
        Console.WriteLine();
        int[] test = solution.TwoSum(new int[] { 1, 3, 4 }, 5);
        Console.WriteLine(test[0] +" " + test[1]);
    
    }
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (target == nums[i] + nums[j])
                    return new int[] { i, j };


        return new int[] { 0, 1 };
    }
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        String y = x.ToString();
        int a = 0;
        int b = y.Length - 1;
        while (a < b)
        {
            if (y[b] != y[a])
                return false;
            a++;
            b--;


        }
        return true;




    }
    public IList<string> FizzBuzz(int n)
    {
        String[] ans = new String[n];
        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 15 == 0)
                ans[i] = "FizzBuzz";
            else if ((i + 1) % 5 == 0)
                ans[i] = "Buzz";
            else if ((i + 1) % 3 == 0)
                ans[i] = "Fizz";
            else
                ans[i] = Convert.ToString(i + 1);

        }
        return ans;
    }
    public bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
                return true;

        }

        return false;
    }

}