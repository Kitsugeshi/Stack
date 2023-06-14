using System;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            string odd = "";
            string even = "";

            int[] input = { 3,1,2,5,4,6,7,2,8,3,9 };
            foreach (var item in input)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                stack.Push(input[i]);
            } 

            for (int i = 0; i < input.Length; i++)
            {
                if (stack.Peek() % 2 == 0)
                {
                    even += Convert.ToString(stack.Pop());
                }
                else
                {
                    odd += Convert.ToString(stack.Pop());
                }
            }
            Console.WriteLine();

            string output = even + odd;
            Console.WriteLine(output);
        }
    }
}