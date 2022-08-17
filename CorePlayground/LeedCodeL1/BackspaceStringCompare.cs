using System;
using System.Collections;

namespace LeedCodeLove.LeedCodeL1
{
    public static class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string s, string t)
        {
            var sStack = StackCharacters(s);
            var tStack = StackCharacters(t);
            return IsStackEqual(sStack, tStack);
        }

        private static Stack StackCharacters(string input)
        {
            var sStack = new Stack();
            foreach (char c in input)
            {
                if (!c.Equals('#'))
                {
                    sStack.Push(c);
                    
                }
                else if (sStack.Count != 0)
                {
                    sStack.Pop();
                }

            }
            return sStack;
        }

        private static bool IsStackEqual(Stack s, Stack t)
        {
            if (s.Count != t.Count) return false;
            while (s.Count != 0)
            {
                Console.WriteLine(s.Count);
                Console.WriteLine($"s peek: {s.Peek()}");
                Console.WriteLine($"t peek: {t.Peek()}");
                if (!s.Peek().Equals(t.Peek()))
                {
                    return false;
                }
                else
                {
                    s.Pop();
                    t.Pop();
                }
            }
            return true;
        }
    }
}
