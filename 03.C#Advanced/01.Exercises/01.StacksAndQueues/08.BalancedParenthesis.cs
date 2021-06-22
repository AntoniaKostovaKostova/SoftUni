using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);       

            int middleOfInput = input.Length / 2;         

            int counter = 0;

            bool isBalanced = true;
          
            foreach (char symbol in input)
            {
                bool isInIf = false;

                counter++;

                if (stack.Count > 0)
                {
                    if (!isInIf)
                    {
                        
                        if (symbol == '{' && stack.Peek() == '}')
                        {
                            stack.Pop();
                            isInIf = true;
                            
                        }
                        if (symbol == '[' && stack.Peek() == ']')
                        {
                            stack.Pop();
                            isInIf = true;
                            
                        }
                        if (symbol == '(' && stack.Peek() == ')')
                        {
                            stack.Pop();
                            isInIf = true;
                            
                        }
                    }

                    if (!isInIf)
                    {
                        isBalanced = false;
                        break;
                    }

                }
                if (counter == middleOfInput)
                {
                    break;
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
