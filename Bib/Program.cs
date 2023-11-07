using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib
{
    internal class Program
    {
        static string[] bookTitles = { "Book1", "Book2"};
        static string[] bookAuthors = {"Author1", "Author2"};
        static string[] magsNames = { "Mag1", "Mag2" };
        static string[] users = {"User1", "User2"};
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string input;
            string title = null;
            string author = null;           
            string name = null;
            string zoekterm = null;
                       

            Console.WriteLine("BIBLIOTHEEK"); //Menu title

            while (true)
            {
                ShowMenu();
                input = Console.ReadLine();


                switch (input) 
                {
                    case "1":
                        ShowMaterials(bookTitles, bookAuthors, magsNames);
                        break;
                    case "2":
                        AddMaterial(title, author);
                        break;
                    case "3":
                        DeleteMaterial(title);
                        break;
                    case "4":
                        ZoekMateriaal(zoekterm);
                        break;
                    case "5":
                        RegistreerGebruiker(name);
                        break;
                }
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        public static void ShowMenu() // Shows the Main Menu
        {
            Console.WriteLine("1. Show all books and mags");
            Console.WriteLine("2. Add new material");
            Console.WriteLine("3. Delete material");
            Console.WriteLine("4. Search for a book or a mag");
            Console.WriteLine("5. New user register");
        }
        public static void AddMaterial(string title, string author)//Add material
        {
            
            Console.WriteLine("1 - Book  ");
            Console.WriteLine("2 - Revue  ");
            int choiceMat = Int32.Parse(Console.ReadLine());

            string[] bookTitles = { "Book1", "Book2" };
            string[] bookAuthors = { "Author1", "Author2" };
            string[] magsNames = { "Mag1", "Mag2" };

            if (choiceMat == 1)
            {                
                Console.WriteLine("Enter the title: ");
                title = Console.ReadLine();

                //Add a new place at the end of the array to fill it:
                Array.Resize(ref bookTitles, bookTitles.Length + 1);
                //Puts the new entry in the new place created:
                bookTitles[bookTitles.Length - 1] = title;
                
                Console.WriteLine("Enter the author: ");
                author = Console.ReadLine();
                Array.Resize(ref bookAuthors, bookAuthors.Length + 1);
                bookAuthors[bookAuthors.Length - 1] = author;
                
            }
            else if (choiceMat == 2)
            {               
                Console.WriteLine("Enter the title: ");
                title = Console.ReadLine();
                Array.Resize(ref magsNames, magsNames.Length + 1);
                magsNames[magsNames.Length - 1] = title;          
            }        
            
        }
       
        public static void ShowMaterials(string[] bookTitles, string[] boekAuthors, string[] magsNames) //Show all books and mags
        {     
           
            Console.WriteLine("1 - Book");
            Console.WriteLine("2 - Revue");
            int choiceMat = Int32.Parse(Console.ReadLine());

            if (choiceMat == 1) 
            {
                for (int i = 0; i < bookTitles.Length; i++)
                {
                    Console.WriteLine($"Book id: {i + 1} \n Title: {bookTitles[i]} \n Author: {boekAuthors[i]}");
                }                
            }

            if (choiceMat == 2)
            {
                for (int i = 0; i < magsNames.Length; i++)
                {
                    Console.WriteLine($"Mag id: {i + 1} \n Title: {magsNames[i]}");
                }
            }

        }
        static void DeleteMaterial(string title)
        {

        }
        static void ZoekMateriaal(string zoekterm)
        {

        }
        static void RegistreerGebruiker(string naam)
        {

        }
        
    }
}
