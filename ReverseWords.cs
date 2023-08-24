public class Solution {
    public string ReverseWords(string s) {
        String[] strlist = s.Split(" ",
               StringSplitOptions.RemoveEmptyEntries);
            string temp = "";
            foreach (String ss in strlist)
            {
                temp = ss.Trim() +" "+ temp;
            }

            return temp.Substring(0,temp.Length-1);
        
    }
}
