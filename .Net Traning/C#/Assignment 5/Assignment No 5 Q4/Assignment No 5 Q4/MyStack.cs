using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_No_5_Q4
{
    class MyStack<T>
    {
        T[] arr = new T[10];
        int top;
        int maxsize = 10;

        public void push(T val)
        {

            try
            {
                if (top == maxsize - 1)
                {


                    throw new Exception("Overflow.");


                }


                else
                {



                    Console.WriteLine("-------------------------------------------------");
                    top = top + 1;
                    arr[top] = val;
                    Console.WriteLine($"{val} Item pushed");
                    Console.WriteLine("-------------------------------------------------");


                }
            }
            catch (Exception st)
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
                    throw new Exception("Underflow.");
                }


                else


                {
                    top = top - 1;
                    Console.WriteLine("Item popped");
                    Console.WriteLine("-------------------------------------------------");


                }
            }
            catch (Exception st)
            {
                Console.WriteLine(st);
            }
        }
        public void show()
        {
            Console.WriteLine("-------------------------------------------------");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("-------------------------------------------------");
        }


    }
}
