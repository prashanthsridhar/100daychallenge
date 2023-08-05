public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {


            var a = AsteroidCollisionhelper(asteroids);
            for(int i=0;i<asteroids.Length-1; i++)
            {
                a= AsteroidCollisionhelper(a);
            }
            return a;
    }
       
        internal class Stack
        {
            static readonly int MAX = 10000;
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


            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
            
        }
        public static int[] AsteroidCollisionhelper(int[] asteroids)
        {
            Stack res = new Stack();
            int temp = 0;
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (res.top == -1)
                {
                    res.Push(asteroids[i]);
                    continue;
                }

                temp = res.Pop();
                //
                if (temp < 0 && asteroids[i] < 0)
                {
                    res.Push(temp);
                    res.Push(asteroids[i]);

                }
                else if (temp > 0 && asteroids[i] > 0)
                {
                    res.Push(temp);
                    res.Push(asteroids[i]);
                }
                else if (temp > 0 && asteroids[i] < 0)
                {
                    //2 -2
                    if (Math.Abs(temp) == Math.Abs(asteroids[i]))
                        continue;

                    //2 -3
                    else if (Math.Abs(temp) < Math.Abs(asteroids[i]))
                    {
                        res.Push(asteroids[i]);
                        //i=0;
                    }
                    //3 -2
                    else if (Math.Abs(temp) > Math.Abs(asteroids[i]))
                    {
                        res.Push(temp);

                    }
                }
                else if (temp < 0 && asteroids[i] > 0)
                {
                    res.Push(temp);
                    res.Push(asteroids[i]);


                }

            }

            //res.PrintStack();
            int[] res1 = new int[res.top + 1];
            for (int u = res.top; res.top > -1; u--)
            {
                res1[u] = res.Pop();
                // Console.WriteLine(u + " ---->" + res1[u]);
            }
            return res1;
        }

}
