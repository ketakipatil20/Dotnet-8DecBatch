using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
            {
                int n;
                MyStack m = new MyStack();
                try
                {
                    do
                    {
                        Console.WriteLine("Enter Choice:");
                        Console.WriteLine("1.Push");
                        Console.WriteLine("2.Pop");
                        Console.WriteLine("3.Display");
                        Console.WriteLine("4.Clone");
                        Console.WriteLine("5.Exit");



                        n = Convert.ToInt32(Console.ReadLine());



                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("Enter elements");
                                int num = Convert.ToInt32(Console.ReadLine());
                                m.push(num);
                                break;
                            case 2:
                                m.pop();
                                break;
                            case 3:
                                m.display();
                                break;
                            case 4:
                                MyStack newStack = m.Clone() as MyStack;
                                newStack.display();
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("Enter valid choice");
                                break;
                        }



                    }
                    while (n != 5);



                }
                catch (StackException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }



