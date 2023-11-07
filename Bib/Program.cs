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
        string[] boekTitels = new string[3];
        string[] boekAuteurs = new string[3];
        string[] tijdschrijftNamen = new string[2];
        string[] gebruikers = new string[4];
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*int choiceMat = 0;*/
            string input;
            string titel = null;
            string auteur = null;
            bool isBoek = false;
            string naam = null;
            string zoekterm = null;

            Console.WriteLine("BIBLIOTHEEK");

            while (true)
            {
                ToonMenu();
                input = Console.ReadLine();


                switch (input) 
                {
                    case "1":
                        ToonMaterialen(boekTitels, boekAuteurs);
                        break;
                    case "2":
                        VoegMateriaalToe(titel, auteur, isBoek);
                        break;
                    case "3":
                        VerwijderMateriaal(titel);
                        break;
                    case "4":
                        ZoekMateriaal(zoekterm);
                        break;
                    case "5":
                        RegistreerGebruiker(naam);
                        break;
                }
                Console.Clear();
            }
            
        }
        static void ToonMenu()
        {
            Console.WriteLine("1. Materialen tonen" + "\n" + "2. Materiaal toevoegen" + "\n" + "3. Materiaal verwijderen" + "\n" + "4. Materiaal zoeken" + "\n" + "5. Nieuwe gebruiker registreren");
        }
        static void VoegMateriaalToe(string titel, string auteur, bool isBoek)
        {
            int choiceMat = 0;
            Console.WriteLine("Choose between: 1 => Book or  2 => Revue");
            choiceMat = Int32.Parse(Console.ReadLine());

            if (choiceMat == 1)
            {
                isBoek = true;
                PopulateArrayBook(titel, auteur);
            }
            else if (choiceMat == 2)
            {
                isBoek = false;
                PopulateArrayTijdschrijft(titel) ;
            }
            /*int choiceMat;*/
            
        }
        static void PopulateArrayBook(string titel, string auteur)
        {
            /*string auteur;*/
            string[] boekTitels = new string[3];
            Console.WriteLine("Enter the title: ");

            //para agregar un lugar en el array que reciba el nuevo elemento:
            Array.Resize(ref boekTitels, boekTitels.Length + 1);

            titel = Console.ReadLine();

            //Ubica la nueva entrada en el nuevo espacio creado en el array:
            boekTitels[boekTitels.Length - 1] = titel;
            /*int i;

            for (i = 0; i < boekTitels.Length; i++)
            {
                boekTitels[i] = titel;
            }*/

            string[] boekAuteurs = new string[3];
            Console.WriteLine("Enter the author: ");
            Array.Resize(ref boekAuteurs, boekAuteurs.Length + 1);
            auteur = Console.ReadLine();
            boekAuteurs[boekAuteurs.Length - 1] = auteur;


            /*for (i = 0; i < boekAuteurs.Length; i++)
            {
                boekAuteurs[i] = titel;
                Console.WriteLine($"New entry: {boekTitels[i]} - {boekAuteurs[i]}");
            }*/
        }
        static void PopulateArrayTijdschrijft(string titel)
        {
            string[] tijdschrijftNamen = new string[2];
            Console.WriteLine("Enter the title: ");
            titel = Console.ReadLine();
            for (int i = 0; i < tijdschrijftNamen.Length; i++)
            {
                tijdschrijftNamen[i] = titel;
            }
        }
        static void ToonMaterialen(string[] boekTitels, string[] boekAuteurs)
        {
            /*string[] boekTitels = new string[3];
            string[] boekAuteurs = new string[3];*/
            int choiceMat = 0;
            Console.WriteLine("Choose between: 1 => Book or  2 => Revue");
            choiceMat = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < boekTitels.Length; i++)
            {
                Console.WriteLine($"Book id: {i + 1} '\n' Title: {boekTitels[i]} '\n' Author: {boekAuteurs[i]}");
            }
        }
        static void VerwijderMateriaal(string titel)
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
