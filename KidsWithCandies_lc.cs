public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = -1;
            for (int i = 0; i <candies.Length;i++)
            {
                if (candies[i] > max)
                    max = candies[i];
            }
            bool[] isMax=new bool[candies.Length];
            for(int i = 0; i < candies.Length;i++)
            {
                if(candies[i]+extraCandies>=max)
                    isMax[i]=true;

            }
            return isMax;
        
    }
}
