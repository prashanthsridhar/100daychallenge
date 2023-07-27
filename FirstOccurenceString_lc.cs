public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    count++;
                }
            }

            for (int i=0;i<nums.Length;i++)
            {
                if (nums[i]==val)
                {
                    
                    for (int j = nums.Length-1; j > i; j--)
                    {
                        if (nums[j] != val)
                        {
                            nums[j] = nums[j] + nums[i];
                            nums[i] = nums[j] - nums[i];
                            nums[j] = nums[j] - nums[i];
                        }
                        
                    }
                }
                
                    

            }

            
            return nums.Length - count;
        
    }
}
