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
            
            CheckIsLoaned(matToBorrow);
            BorrowABook(testBooks, matToBorrow);
        }
        static void CheckIsLoaned(string matToBorrow)
        {                     
            for (int i = 0; i < testBooks.Length; i++)
            {
                testBooks[i] = matToBorrow;
                if (matToBorrow != testBooks[i])
                {
                    Console.WriteLine($"{matToBorrow} is Borrowed");
                    break;
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
        static void BorrowABook(string[] testBooks, string matToBorrow) 
        {
            Console.WriteLine("Enter your User Name: ");
            string userName = Console.ReadLine();

            for (int i = 0; i < testBooks.Length; i++)
            {
                if (matToBorrow == testBooks[i])
                {
                    testBooks[i] = "333";
                    break;
                }
            }
            Console.WriteLine($"User {userName}, yo have borrowed {matToBorrow}");
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}
