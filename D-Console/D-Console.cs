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
            string test =  "usa,dollar,0.34";
            string[] cArray = test.Split(',');
            do
            {
                Console.WriteLine("1. Add a country");
                Console.WriteLine("2. Display all countries ");
                Console.WriteLine("3. Find the exchange rate");
                Console.WriteLine("4. Save to Text file");
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
                    FindExchange(countrylist);
                }
                else if (ans == "4")
                {
                    SaveToTextFile(countrylist);
                }
            } while (ans != "9");
            Console.ReadLine();
        }

        private static void SaveToTextFile(List<Country> countrylist)
        {
            StreamWriter currentFile = new StreamWriter("a.txt");
            foreach (var item in countrylist)
            {
                currentFile.WriteLine(item.CountryName);
                currentFile.WriteLine(item.ExchangeRate);
                currentFile.WriteLine(item.CurrencyName);
            }
            currentFile.Close();
        }

        private static void FindExchange(List<Country> countrylist)
        {
            Console.WriteLine("enter the country");
            string cName = Console.ReadLine();
            foreach (var item in countrylist)
            {
                if (item.CountryName == cName)
                {
                    Console.WriteLine($"{item.CurrencyName} {item.ExchangeRate} ");
                }
            }
        }

        private static void DisplayCountries(List<Country> countrylist)
        {
            foreach (var item in countrylist)
            {
                Console.WriteLine(item.CountryName);
            }

            //for (int i = 0; i < countrylist.Count; i++)
            //{
            //    Console.WriteLine(countrylist[i].CountryName);
            //}
        }

        private static void AddCountry(List<Country> countrylist)
        {
            Country aCountry  = new Country();
            Console.WriteLine("enter the country name");
            aCountry.CountryName = Console.ReadLine();
            Console.WriteLine("enter the exanage rate");
            aCountry.ExchangeRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the currency name");
            aCountry.CurrencyName = Console.ReadLine();

            
            countrylist.Add(aCountry);
        }
    }
}
