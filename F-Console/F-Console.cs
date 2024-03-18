using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter12
{


    class Country
    {
        public string CountryName { get; set; }
        public double ExchangeRate { get; set; }
        public string CurrencyName { get; set; }

    }

    class Chapter10
    {
        static void Main(string[] args)
        {
            List<Country> countrylist = new List<Country>();
            string ans;
            do
            {
                Console.WriteLine("1. Add a country");
                Console.WriteLine("2. Display all countries ");
                Console.WriteLine("3. Find the countries exchange rate");
                Console.WriteLine("4. Save in the text file");
                Console.WriteLine("5. Restore the list from the text file");
                ans = Console.ReadLine();
                if (ans == "1")
                {
                    AddCountry(countrylist);
                }
                else if (ans == "2")
                {
                    DisplayCountries(countrylist);
                }
                else if (ans == "3")
                {
                    ExchangeRate(countrylist);
                }
                else if (ans == "4")
                {
                    SaveInTextFile(countrylist);
                }
                else if (ans == "5")
                {
                    RestoreList(countrylist);
                }
            } while (ans != "9");


            Console.ReadLine();


        }

        private static void RestoreList(List<Country> countrylist)
        {
            StreamReader currentFile = new StreamReader("Country list.txt");
            while (!currentFile.EndOfStream)
            {
                Country aCountry = new Country();
                aCountry.CountryName = currentFile.ReadLine();
                aCountry.CurrencyName = currentFile.ReadLine();
                aCountry.ExchangeRate = Convert.ToDouble(currentFile.ReadLine());
                countrylist.Add(aCountry);
            }
            currentFile.Close();
        }

        private static void SaveInTextFile(List<Country> countrylist)
        {

            StreamWriter currentFile = new StreamWriter("Country list.txt");
            foreach (var item in countrylist)
            {
                currentFile.WriteLine(item.CountryName);
                currentFile.WriteLine(item.CurrencyName);
                currentFile.WriteLine(item.ExchangeRate);
            }
            currentFile.Close();
        }

        private static void ExchangeRate(List<Country> countrylist)
        {
            Console.WriteLine("Enter a country name");
            string cname = Console.ReadLine();
            foreach (var item in countrylist)
            {
                if (cname == item.CountryName)
                {

                    Console.WriteLine($" {item.ExchangeRate}");
                }
            }
        }

        private static void DisplayCountries(List<Country> countrylist)
        {
            foreach (var item in countrylist)
            {
                Console.WriteLine($"{item.CountryName} {item.CurrencyName} {item.ExchangeRate}");
            }

        }

        private static void AddCountry(List<Country> countrylist)
        {
            Country aCountry = new Country();
            Console.WriteLine("Enter the country name:");
            aCountry.CountryName = Console.ReadLine();
            Console.WriteLine("Enter the exchange rate:");
            aCountry.ExchangeRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the currency name:");
            aCountry.CurrencyName = Console.ReadLine();
            countrylist.Add(aCountry);
        }
    }
}
