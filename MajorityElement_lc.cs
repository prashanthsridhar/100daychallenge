public class Solution {
    public int MajorityElement(int[] nums) {

        Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if(map.ContainsKey(i))
                    map[i] = map[i] + 1;
                else
                    map.Add(i, 1);
            }

          

            var a = map.FirstOrDefault(x => x.Value == map.Max(x => x.Value));
            if (map[a.Key] > nums.Length / 2)
                return a.Key;
            else return -1;
        
    }
}
