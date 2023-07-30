public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index = 1;
            int[] expNums = new int[nums.Length];
            expNums[0]=nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (expNums[index-1] != nums[i])
                {
                    expNums[index++] = nums[i];
                }
            }
            for(int j=0;j<index;j++)
            {
                nums[j] = expNums[j];
            }
            return index;
        
    }
}
