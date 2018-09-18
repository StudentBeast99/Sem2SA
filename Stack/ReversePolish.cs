using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class ReversePolish
    {
        public string Str { get; set; }
        MyStack<double> stack;

        public ReversePolish(string str)
        {
            Str = str;
        }
        public double GetValue()
        {
            stack = new MyStack<double>();
            string[] Arr = Str.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in Arr)
            {
                if (double.TryParse(item, out double result))
                {
                    stack.Push(result);
                }
                else
                {
                    switch (item)
                    {
                        case "+":
                            stack.Push(stack.Pop() + stack.Pop());
                            break;
                        case "*":
                            stack.Push(stack.Pop() * stack.Pop());
                            break;
                        case "-":
                            stack.Push(0 - stack.Pop() + stack.Pop());
                            break;
                        case "/":
                            stack.Push(1 / stack.Pop() * stack.Pop());
                            break;
                        default:
                            throw new Exception();
                    }
                }
            }
            if (stack.Count == 1)
                return stack.Pop();
            throw new Exception();
        }
    }
}
