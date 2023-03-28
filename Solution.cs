public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsPalindrome(10));
        Console.WriteLine(solution.IsPalindrome(3003));

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
}