public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack res=new Stack();
            int temp = 0;
            for(int i= asteroids.Length-1; i>=0;i--)
            {
                if(i== asteroids.Length - 1)
                    res.Push(asteroids[i]);
                else
                {
                    temp = res.Pop();
                    if(temp>0&& asteroids[i]>0)
                    {
                        res.Push(temp);
                        res.Push(asteroids[i]);

                    }
                    else if (temp < 0 && asteroids[i] < 0)
                    {
                        res.Push(temp);
                        res.Push(asteroids[i]);

                    }
                     else if (Math.Abs(temp) == Math.Abs(asteroids[i]))

                    {
                        if(asteroids[i]<0&&temp>0)
                        {
                            res.Push(temp);
                            res.Push(asteroids[i]);
                        }
                            
                        else
                        continue;

                    }
                    else
                    {
                        if (Math.Abs(temp) > Math.Abs(asteroids[i]))
                            res.Push(temp);
                        else if (Math.Abs(temp) < Math.Abs(asteroids[i]))
                            res.Push(asteroids[i]);
                    }
                    
                    
                }
            }
            int[] res1=new int[res.top+1];
            
            for(int u=0;res.top>-1;u++)
            {
                                res1[u]=res.Pop();
            }
            return res1;

        
    }
     internal class Stack
        {
            static readonly int MAX = 1000;
            public int top;
            public int[] stack = new int[MAX];

            bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }
            internal bool Push(int data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }

            internal int Pop()
            {
                if (top < 0)
                {
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }
        }
}
