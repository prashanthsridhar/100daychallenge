public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if(map.ContainsKey(i))
                    map[i] = map[i] + 1;
                else
                    map.Add(i, 1);
            }
            int myKey = map.FirstOrDefault(x => x.Value == 1).Key;
            return myKey;
        
    }
}
