public class Solution
{
    public int ClimbStairs(int n)
    {
        double count = 1;
        for (int i = 1; i < n; i++)
        {
            if ((i * 2) <= n)
            {

                count += (factorial_Recursion(n - i) / (factorial_Recursion(i) * factorial_Recursion(n - i - i)));
            }
        }
        return Convert.ToInt32(count);
    }
    public static double factorial_Recursion(int number)
    {
        if (number == 1 || number == 0)
            return 1;
        else
            return number * factorial_Recursion(number - 1);
    }
}
