public class Solution {
    public bool IsHappy(int n) {
         int num = 99;
                     List<int> list1 = new List<int>();   

         while(num.ToString().Length!=0)
{
    num = sumDig(n);
    if (num == 1)
        return true;
    if (list1.Contains(num))
        return false;
    list1.Add(num);
    n = num;
}



return false;
    }
    public int sumDig(int hh)
{
    int sum = 0;
    while (hh > 0)
    {
        sum =sum+ (int)Math.Pow((hh % 10) ,2);
        hh = hh / 10;
    }
    return sum;
}
}
