using System;

namespace asdasd
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }
        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptFundamental();
            PrintReceiptEnd();
        }
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintReceiptFundamental()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintReceiptEnd()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© BG");
        }
    }
}
