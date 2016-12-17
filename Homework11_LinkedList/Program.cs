using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            int input=0;
            int push;
            while (input != 9)
            {
                //***********************************************Stack * *******************
                Console.WriteLine("\n 1 - Push; 2 - Pop; 3 - Peek; 8 - Exit; ");
                input = Int32.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Value to push:");
                    push = Int32.Parse(Console.ReadLine());

                    stack.Push(push);
                    stack.PrintStack();
                }

                if (input == 2)
                {
                    stack.Pop();
                    stack.PrintStack();
                }

                if (input == 3)
                {
                    stack.Peek();
                    stack.PrintStack();
                }
                //**************************************************Stack****

                //****************************************************Queue
                //    Console.WriteLine("\n 1 - Enqueue; 2 - Dequeue; 8 - Exit; ");
                //    input = Int32.Parse(Console.ReadLine());

                //    if (input == 1)
                //    {
                //        Console.WriteLine("Value to enqueue:");
                //        push = Int32.Parse(Console.ReadLine());

                //        queue.Enqueue(push);
                //        queue.PrintQueue();
                //    }

                //    if (input == 2)
                //    {
                //        queue.Dequeue();
                //        queue.PrintQueue();
                //    }

                //    //*************************************Queue

                if (input == 8)
                {
                    Console.WriteLine("Bye!!!");
                }
            }



            Console.ReadLine();
        }
    }
}
