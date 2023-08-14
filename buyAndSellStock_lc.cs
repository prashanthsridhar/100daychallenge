public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 1)
            return 0;
        int maxDif = prices[1] - prices[0];
        int min = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] - min > maxDif)
            {
                maxDif = prices[i] - min;
            }
            
            if (prices[i] < min)
                min = prices[i];
        }
        if (maxDif < 0)
            maxDif = 0;
        return maxDif;
    }
}
