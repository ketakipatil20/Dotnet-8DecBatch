using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Q3
{
    public class StackException : Exception
    {
        public StackException(string message) : base(message) { }
    }
    public class MyStack : ICloneable
    {
        private int[] arr = new int[20];
        private int top = -1;
        private int size;



        public object Clone()
        {
            Console.WriteLine("----cloned Array----");
            MyStack newStack = new MyStack
            {
                arr = this.arr,
                top = this.top,
                size = this.size
            };
            return newStack;
        }
        public void push(int a)
        {
            try
            {
                if (top == arr.Length - 1)
                {
                    throw new StackException("FukkStack Exception.");
                }
                arr[++top] = a;
                Console.WriteLine($"\nPushed {a} onto the stack.");
            }
            catch (StackException st)
            {
                Console.WriteLine(st);
            }
        }
        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new StackException("EmptyStack Exception.");
                }
                Console.WriteLine($"\n{arr[top]} popped.");
                arr[top--] = 0;
            }
            catch (StackException st)
            {
                Console.WriteLine(st);
            }
        }
        public void display()
        {
            Console.WriteLine("\n---Printing---");
            foreach (int i in arr)
            {
                Console.Write(i + "");
            }
        }


    }



}
