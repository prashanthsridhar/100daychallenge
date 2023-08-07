public class Solution {
    public int MySqrt(int x) {
        if(x==0)
        return 0;
        if(x==1)
        return 1;
        for(int i=1;i<=(x/2)+1;i++)
{
    if((long)i*i==x)
        return i;
    else if((long)i*i>x)
                return i-1;


}
 return 1;
    }
   
}
