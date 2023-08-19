public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
           string temp = "";

                temp = "";
                int min = word1.Length;
                if(word2.Length<min)
                    min= word2.Length;
                for(int i=0; i<min;i++)
                {
                    temp = temp + word1[i];
                    temp = temp + word2[i];

                }
                if(word1.Length<word2.Length)
                temp+=word2.Substring(word1.Length);
                else
                    temp += word1.Substring(word2.Length);


                return temp;
    }
}
