using System;

namespace Assignment1_Q6
{
    enum bookType
    {
        Magazine = 1,
        Novel,
        ReferenceBook,
        Miscellaneous
    }
    struct Book
    {
        public int bookId;
        public string title;
        public double price;
        public bookType type;

        public void acceptDetails()
        {
            Console.WriteLine("Enter book ID: ");
            bookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter book title: ");
            title = Console.ReadLine();

            Console.WriteLine("Enter book price: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter book type: ");
            Console.WriteLine("1.Magazine");
            Console.WriteLine("2.Novel");
            Console.WriteLine("3.Reference Book");
            Console.WriteLine("4.Miscellaneous");
            int t = Convert.ToInt32(Console.ReadLine());
            type = (bookType)t;
        }
        public void displayDetails()
        {
            Console.WriteLine("----Displaying details----");
            Console.WriteLine($"Book ID: {bookId}");
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Book Price: {price}");
            Console.WriteLine($"Book Type: {type}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.acceptDetails();
            b.displayDetails();
        }
    }
}
