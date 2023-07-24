//https://leetcode.com/problems/two-sum/submissions/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] a=new int[2];
         int sum=0;
        for(int i=0;i<nums.Length;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                sum=nums[i];
                sum+=nums[j];
                if(sum==target)
                {
                    a[0]=i;
                    a[1]=j;
                }
            }
        }
        return a;
        
    }
}
