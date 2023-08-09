public class Solution {
    public bool IsPalindrome(string s) {
        //s=s.Replace(" ", "");
            string temp = "";
            s = s.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                if((int)s[i]>=97 && (int)s[i] <=122)
                temp += s[i];
                if ((int)s[i] >= 48 && (int)s[i] <= 57)
                    temp += s[i];
            }
            
            string rev = "";
            for(int i=temp.Length-1;i>=0;i--)
            {
              
                rev += temp[i];
            }
            if(rev==temp)
            return true;
        return false;
        
    }
}
