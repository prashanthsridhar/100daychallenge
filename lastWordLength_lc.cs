public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        if(s[s.Length-1]==' ')
                s= s.Substring(0, s.Length-1);
            string[] a=s.Split(' ');
            for(int i =0;i<a.Length;i++)
            {
                if(a[i].Length>0)
                    count=a[i].Length;
            }
            return count;
    }
}
