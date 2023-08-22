public class Solution {
    public string ReverseVowels(string s) {
         string vow = "";
            string temp = "";
            foreach(char c in s)
            {
                if(c=='a'||c=='e'||c=='i'||c=='o'||c=='u'||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')

                {
                    vow += c;
                }
                

            }
            if (vow != null)
            {

                
                var ff= vow.Reverse();
                vow = "";
                foreach(var e in ff)
                {
                    vow += e;
                }
            }

            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'||
                    s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    temp += vow[0];
                    vow=vow.Substring(1);
                }
                else
                    temp += s[i];
            }
            return temp;

        
    }
}
