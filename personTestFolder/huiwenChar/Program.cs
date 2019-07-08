using System;
using System.Collections.Generic;
using System.Linq;

namespace huiwenChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //huiWenTest();

            int[] scores = new int[] { 97, 92, 81, 87 };

            IEnumerable<int> scorequery =
                from score in scores
                where score > 90
                select score;

            foreach (var item in scorequery)
            {
                Console.WriteLine(item + "   ");
                Console.ReadKey();
            }  

        }
        public static void  huiWenTest()
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
                queue.Enqueue(str[i]);
            }

            bool ishuiwen = true;
            while(stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    ishuiwen = false;
                    break;
                }
            }

            Console.WriteLine("输入的字符串是回文嘛？ --"  + ishuiwen);
            Console.ReadKey();

        }
    }
}
