public class Solution {
    public string GcdOfStrings(string str1, string str2) {
         string temp = "";
            string temp1 = "";
                if (str1.Length < str2.Length)
                {
                    temp = str1;
                    str1 = str2;
                    str2 = temp;
                }
                temp = str2;
                string tstr1 = str1;
                for (int i = str2.Length; i > 0; i--)
                {
                    if (str1.Length % temp.Length != 0)
                    {
                        temp = temp.Substring(0, i);
                        continue;
                    }
                    tstr1 = str1;
                    for (int j = 0; j < str1.Length / temp.Length; j++)
                    {
                        if (tstr1.IndexOf(temp) != 0)
                            break;
                        else
                        {
                            tstr1 = tstr1.Substring(temp.Length);
                        }
                        if (tstr1 == "" && str2.Length % temp.Length == 0)
                    {
                        for(int l=0;l< str2.Length/temp.Length;l++)
                        {
                            temp1 += temp;
                        }
                        if (str2 == temp1)
                            return temp;
                        else
                            return "";
                    }
                            
                        else
                            continue;
                    }
                    temp = temp.Substring(0, i);
                }




                return "";

            }
        
}
