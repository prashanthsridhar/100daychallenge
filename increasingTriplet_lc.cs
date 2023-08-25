public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int i1 = 0, i2 = 0;
            for(int i=0;i<nums.Length;i++)
            {
                i1 = findBigger(nums[i..nums.Length],nums[i]);
                if (i1> -1)
                    
                
                {
                    i2 = findBigger(nums[(i1+i)..nums.Length], nums[i1+i]);
                    if(i2>-1)
                    {
                        return true;
                    }
                }
                
            }
            return false;
    }
    public int findBigger(int[] nums,int n)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > n)
                    return i;
            }
            return -1;
        }
}
