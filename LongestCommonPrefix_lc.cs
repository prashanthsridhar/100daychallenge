public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string comm = "";
            int max = -1;
            int index = -1;
            int count = 0;
            for(int i=0;i<strs.Length;i++)
            {
                if(strs[i].Length>max)
                    index = i;
            }comm = strs[index];
            while(comm!="")
            {
                count = 0;
                for(int j=0;j<strs.Length;j++)
                {
                    if(strs[j].IndexOf(comm)==0)
                    {
                        count++;
                    }
                }
                if(count==strs.Length)
                    return comm;
                comm=comm.Substring(0,comm.Length-1);
            }
            return comm;
        
    }
}
