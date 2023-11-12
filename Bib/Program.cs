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
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] boekTitels = new string[3];
            string[] boekAuteurs = new string[3];
            string[] tijdschrijftNamen = new string[2];
            string[] gebruikers = new string[4];
            /*int choiceMat = 0;*/
            string input;
            string titel = null;
            string auteur = null;
            bool isBoek = false;
            string naam = null;
            string zoekterm = null;


            Console.WriteLine("BIBLIOTHEEK"); //Menu title

            while (true)
            {
                ShowMenu();
                input = Console.ReadLine();

                if(input == "1")
                {
                    ShowMaterials(bookTitles, bookAuthors, magsNames);
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "2")
                {
                    AddMaterial(ref title, ref author);
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "3")
                {
                    DeleteMaterial(ref bookTitles, ref magsNames, title);
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "4")
                {
                    SearchMaterial(bookTitles, bookAuthors, magsNames, searchItem);
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "5")
                {
                    UserRegister(name);
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Not a valid choice");
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }                
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
        public static void AddMaterial(ref string title, ref string author)//Add material.Both for books and mags
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
                Array.Resize(ref bookAuthors, bookAuthors.Length + 1);
                author = Console.ReadLine();
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

        public static void ShowMaterials(string[] bookTitles, string[] bookAuthors, string[] magsNames) //Show all books and mags
        {

            Console.WriteLine("1 - Book");
            Console.WriteLine("2 - Revue");
            int choiceMat = Int32.Parse(Console.ReadLine());

            if (choiceMat == 1)
            {
                for (int i = 0; i < bookTitles.Length; i++)
                {
                    if (bookTitles[i] == "9999")//Doesen't show the item already convert to "9999"
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Book id: {i + 1} \n Title: {bookTitles[i]} \n Author: {bookAuthors[i]}");
                    }
                }
            }

            if (choiceMat == 2)
            {
                for (int i = 0; i < magsNames.Length; i++)
                {
                    if (magsNames[i] == "9999")//Doesen't show the item already convert to "9999"
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Mag id: {i + 1} \n Title: {magsNames[i]}");
                    }
                }
            }

        }
        static void DeleteMaterial(ref string[] bookTitles, ref string[] magsNames, string title) //Delete
        {
            Console.WriteLine("What material do you want to delete? : ");
            Console.WriteLine("1 - Book  ");
            Console.WriteLine("2 - Revue  ");
            int choiceMat = Int32.Parse(Console.ReadLine());

            if (choiceMat == 1)
            {
                Console.WriteLine("Enter the title: ");
                title = Console.ReadLine();
                // Find the index of the book title:
                int index = Array.IndexOf(bookTitles, title);
                if (index >= 0)
                {
                    bookTitles[index] = "9999";
                }
                else
                {
                    Console.WriteLine("Title not found.");
                }
            }
            else if (choiceMat == 2)
            {
                Console.WriteLine("Enter the title: ");
                title = Console.ReadLine();
                int index = Array.IndexOf(magsNames, title);
                if (index >= 0)
                {
                    magsNames[index] = "9999";
                }
                else
                {
                    Console.WriteLine("Title not found.");
                }
            }
        }
        static void SearchMaterial(string[] bookTitles, string[] bookAuthors, string[] magsNames, string searchItem)//Search in the arrays for a search term (both titles or authors)
        {
            Console.WriteLine("1 - Book");
            Console.WriteLine("2 - Revue");
            int choiceMat = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the search term: ");
            searchItem = Console.ReadLine();
            if (choiceMat == 1)
            {
                if (Array.IndexOf(bookTitles, searchItem) >= 0)
                {
                    Console.WriteLine($"'{searchItem}' found in Books Titles.");
                }
                else if (Array.IndexOf(bookAuthors, searchItem) >= 0)
                {
                    Console.WriteLine($"'{searchItem}' found in Books Authors.");
                }
                else
                {
                    Console.WriteLine("Search term not found.");
                }
            }
            else if (choiceMat == 2)
            {
                if (Array.IndexOf(magsNames, searchItem) >= 0)
                {
                    Console.WriteLine($"'{searchItem}' found in Magazines Titles.");
                }
                else
                {
                    Console.WriteLine("Search term not found.");
                }
            }

        }
        static void UserRegister(string name)//Add a new User Name to the users array
        {
            Console.WriteLine("Enter your User name");
            name = Console.ReadLine();

            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = name;
            Console.WriteLine($" User {name}. You are succesfully added to our Library!");

        }
    }
}
