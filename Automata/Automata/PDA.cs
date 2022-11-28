using System.Runtime.CompilerServices;

namespace Automata
{
    public class PDA
    {
        public bool CheckSymbol(String inputs)
        {
            Stack<char> stack = new Stack<char>();
            int len = inputs.Length;

            for (int i = 0; i < len; i++)
            {
                switch (inputs[i])
                {
                    case '(':
                        stack.Push(inputs[i]);
                        break;
                    case ')':
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }else
                        {
                            return false;
                        }
                        break;
                    case '{':
                        stack.Push(inputs[i]);
                        break;
                    case '}':
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }else
                        {
                            return false;
                        }
                        break;
                    case '[':
                        stack.Push(inputs[i]);
                        break;
                    case ']':
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }else
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }

            }
            
            if (stack.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckPalindrome(String word)
        {
            Stack<char> stack = new Stack<char>();

            int len = word.Length, i;

            for (i = 0; i < len / 2; i++)
            {
                stack.Push(word[i]);
            }
            if (len % 2 != 0)
            {
                i = i + 1;
            }

            while (i < len)
            {
                char c = stack.Peek();
                stack.Pop();

                if (c != word[i])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
