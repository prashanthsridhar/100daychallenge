public class Solution {
    public bool IsValid(string s) {
        if(s.Length%2!=0)
                return false;
        Stack myStack = new Stack();
             try
            {
                foreach (char c in s)
                {
                    if (c == '{' || c == '[' || c == '(')
                        myStack.Push(c);
                    else
                    {
                        if (c == '}')
                        {
                            if (myStack.Peek().Equals('{'))
                                myStack.Pop();
                            else
                                return false;
                        }
                        if (c == ']')
                        {
                            if (myStack.Peek().Equals('['))
                                myStack.Pop();
                            else
                                return false;
                        }
                        if (c == ')')
                        {
                            if (myStack.Peek().Equals('('))
                                myStack.Pop();
                            else
                                return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            if(myStack.Count==0)
                return true;
            return false;

    }
}
