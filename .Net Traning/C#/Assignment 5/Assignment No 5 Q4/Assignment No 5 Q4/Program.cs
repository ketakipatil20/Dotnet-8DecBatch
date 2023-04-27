using System;

namespace Assignment_No_5_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<Object> st = new MyStack<Object>();

            int choice = 0;
            Console.WriteLine("\n----------------------------------------------\n");
            while (choice != 4)
            {
                Console.WriteLine("Chose one from the below options...\n");
                Console.WriteLine("\n1.Push\n2.Pop\n3.Show\n4.Exit");
                Console.WriteLine("\n Enter your choice \n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            st.push("hello");
                            st.push(1234);
                            st.push(null);
                            st.push(false);
                            st.push(3.40);
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
                            Console.WriteLine("Exiting....");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please Enter valid choice ");
                            break;
                        }
                };

            }
        }
    }
}
