public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int temp = 1;
            int t1 = 1;
            int[] lp=new int[nums.Length];
            int[] rp = new int[nums.Length];
            int[] res = new int[nums.Length];
            for (int i=0;i<nums.Length;i++)
            {
                lp[i] = temp;
                temp*=nums[i];
            }
            for (int i = nums.Length-1; i >=0 ; i--)
            {              
                rp[i] = t1;
                res[i]= lp[i]*rp[i];
                t1*=nums[i];
            }
            return res;
    }
     
}
