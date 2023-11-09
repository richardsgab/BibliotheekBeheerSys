using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExtras
{
    internal class Program
    {
        static string[] testBooks = { "b1, b2, b3" };
        static string[] testUsers = { "Ab", "Sj", "Ko" };
        static string matToBorrow;
        static string userName;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter title to lean: ");
            string matToBorrow = Console.ReadLine();
            //Call the CheckIsLoaned method
            CheckIsLoaned(matToBorrow);
            BorrowABook(testBooks, matToBorrow);
        }
        static void CheckIsLoaned(string title)
        {           
            for (int i = 0; i < testBooks.Length; i++)
            {
                if (matToBorrow != testBooks[i])
                {
                    Console.WriteLine($"{matToBorrow} is Loaned");
                }
                else if (matToBorrow == testBooks[i])
                {
                    //Call the Loaned Books method
                    BorrowABook(testBooks, matToBorrow );
                    break;
                }
                else
                {
                    Console.WriteLine("Is not a valid Title");
                }
            }
        }
        static void BorrowABook(string[] testBooks, string title) 
        {
            Console.WriteLine("Enter your User Name: ");
            userName = Console.ReadLine();

            for (int i = 0; i < testBooks.Length; i++)
            {
                if (title == testBooks[i])
                {
                    testBooks[i] = "333";
                }
            }
        }
    }
}
