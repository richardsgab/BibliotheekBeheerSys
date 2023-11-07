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
            /*int choiceMat = 0;*/
            string input;
            string title = null;
            string author = null;
            /*bool isBook = false;*/
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
                        ShowMaterials(bookTitles, bookAuthors);
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
                Console.Clear();
            }
            
        }
        static void ShowMenu() // Shows the Main Menu
        {
            Console.WriteLine("1. Show all books and mags");
            Console.WriteLine("2. Add new material");
            Console.WriteLine("3. Delete material");
            Console.WriteLine("4. Search for a book or a mag");
            Console.WriteLine("5. New user register");
        }
        static void AddMaterial(string title, string author)//Add material
        {
            int choiceMat = 0;
            Console.WriteLine("1 - Book");
            Console.WriteLine("2 - Revue");
            choiceMat = Int32.Parse(Console.ReadLine());

            if (choiceMat == 1)
            {
                
                Console.WriteLine("Enter the title: ");

                //To add a new place in the array to fill it:
                Array.Resize(ref bookTitles, bookTitles.Length + 1);
                title = Console.ReadLine();

                //Puts the new entry in the new place created:
                bookTitles[bookTitles.Length - 1] = title;
                /*int i;*/

               /* for (i = 0; i < bookTitles.Length; i++)
                {
                    bookTitles[i] = title;
                }*/

                string[] bookAuthors = new string[3];
                Console.WriteLine("Enter the author: ");
                Array.Resize(ref bookAuthors, bookAuthors.Length + 1);
                author = Console.ReadLine();
                bookAuthors[bookAuthors.Length - 1] = author;

            }
            else if (choiceMat == 2)
            {
                /*isBook = false;
                PopulateArrayTijdschrijft(title) ;*/
                string[] magsNames = new string[2];
                Console.WriteLine("Enter the title: ");
                title = Console.ReadLine();

                int i;
                for (i = 0; i < magsNames.Length; i++)
                {
                    magsNames[i] = title;
                }


                
                /*int i ;*/

                for (i = 0; i < bookAuthors.Length; i++)
                {
                    bookAuthors[i] = title;
                    Console.WriteLine($"New entry: {bookTitles[i]} - {bookAuthors[i]}");
                }

            }
            
            
        }
       
        static void ShowMaterials(string[] bookTitles, string[] boekAuthors) //Show all books and mags
        {            
            int choiceMat = 0;
            Console.WriteLine("1 - Book");
            Console.WriteLine("2 - Revue");
            choiceMat = Int32.Parse(Console.ReadLine());

            if (choiceMat == 1) 
            {
                for (int i = 0; i < bookTitles.Length; i++)
                {
                    Console.WriteLine($"Book id: {i + 1} '\n' Title: {bookTitles[i]} '\n' Author: {boekAuthors[i]}");
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
