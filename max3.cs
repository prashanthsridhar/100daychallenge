using System;

namespace sandbox1
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int []a = new int []{ 1, 23, 12, 123, 456, 33, 523, 3242, 23425, 8664, 6335 };
            //int[] a = new int[] { 1, 2,3 };
            //Array.Reverse(a);

            int k = 3;
            int min;
            int[] max=new int[k] ;
            int ind;
            for (int i = 0 ; i < k ; i++)
            {
                max[i] = a[i] ;
            }
            min = findMin(max);
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>min && Array.IndexOf(max, a[i])<0)
                {
                    ind=Array.IndexOf(max, min);
                    max[ind] = a[i];
                    min = findMin(max);

                }
            }
            for(int i=0;i<k;i++)
            {
                Console.WriteLine(max[i]+" ");
            }
            

        }
        public static int findMin(int []a)
        {
            int min = a[0];
            for (int i = 0 ; i < a.Length ; i++)
            {
                if(a[i]<min)
                    min = a[i];
            }
            return min;
        }
    }
}
