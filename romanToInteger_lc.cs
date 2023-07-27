public class Solution {
    public int RomanToInt(string s) {
         int number = 0;
         string a =s;
           for(int i=0;i<a.Length;i++)
            {
                if (a[i] == 'I')
                {
                    if (i+1!=a.Length && a[i + 1] == 'V')
                    {
                        number += 4;
                        i += 1;
                    }
                    else if (i + 1 != a.Length &&  a[i + 1] == 'X')
                    {
                        number += 9;
                        i += 1;
                    }
                    else
                        number += 1;
                }
                else if (a[i] == 'X')
                {
                    if (i + 1 != a.Length &&  a[i + 1] == 'L')
                    {
                        number += 40;
                        i += 1;
                    }
                    else if (i + 1 != a.Length &&  a[i + 1] == 'C')
                    {
                        number += 90;
                        i += 1;
                    }
                    else
                        number += 10;
                }
                else if (a[i]=='C')
                {
                    if (i + 1 != a.Length && a[i+1] == 'M')
                    {
                        number += 900;
                        i += 1;
                    }
                    else if (i + 1 != a.Length &&  a[i+1]=='D')
                    {
                        number += 400;
                        i += 1;
                    }
                    else
                        number += 100;
                }
                else if (a[i] == 'L')
                {
                    number += 50;
                }
                else if (a[i] == 'V')
                {
                    number += 5;
                }
                 else if (a[i] == 'D')
                {
                    number += 500;
                }
                else if(a[i]=='M')
                {
                    number += 1000;
                }
            }
        
        return number;
    }
}
