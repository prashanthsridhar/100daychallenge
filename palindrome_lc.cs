public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
        return false;
        int num=x;
        int rev=0;
        while (num>0)
        {
            rev=rev*10+num%10;
            num=num/10;

        }
        if(rev==x)
            return true;
        return false;
        
    }
}
