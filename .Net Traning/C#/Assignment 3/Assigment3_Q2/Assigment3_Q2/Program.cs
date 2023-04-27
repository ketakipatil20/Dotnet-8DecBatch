using System;

namespace Assigment3_Q2
{
    class Stack : ICloneable
    {
        int top;
        int maxsize = 10;
        int[] arr = new int[10];

        public object Clone()
        {
            Stack st= new Stack();
           st.top = -1;

            return st;
        }

        public static void Main()
        {
            Stack st = new Stack();
            st.top = -1;
            Stack s1 = st.Clone() as Stack;
            int choice = 0;

            Console.WriteLine("\n------------------------------------");
            while (choice != 4)
            {
                Console.WriteLine("Chose one from the below option....\n");
                Console.WriteLine("\n1.Push\n2.Pop\n3.Show\n4.Exit");
                Console.WriteLine("\n Enter your choice \n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            st.push();
                            break;
                        }
                    case 2:
                        {
                            st.pop();
                            break;
                        }
                    case 3:
                        {
                            st.show();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exiting.....");
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Please Enter Valid choice");
                            break;
                        }

                };



            }
        }

        Boolean push()
        {
            int val;
            if (top == maxsize - 1)
            {
                Console.WriteLine("\n Overflow");
                return false;
            }
            else
            {
                Console.WriteLine("Enter the value?");
                val = Convert.ToInt32(Console.ReadLine());
                top = top + 1;
                arr[top] = val;
                Console.WriteLine("Item pushed");
                return true;
            }
        }

        Boolean pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Underflow");
                return false;
            }
            else
            {
                top = top - 1;
                Console.WriteLine("Item popped");
                return true;
            }
        }
        void show()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
        }
        
    }
}

        
    

