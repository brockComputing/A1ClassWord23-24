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
        public string  CurrencyName { get; set; }
      
    }

    class Chapter10
    {
        static void Main(string[] args)
        {
            List<Country> countrylist = new List<Country>();
            do
            {
                Console.WriteLine("1. Add a country");
                Console.WriteLine("2. Display all countries ");
                string ans = Console.ReadLine();    
                if (ans == "1")
                {
                    AddCountry(countrylist);
                }
                else if (ans == "2")
                {
                    DisplayCountries(countrylist);
                }
            } while (true);

            
            Console.ReadLine(); 
            

        }

        private static void DisplayCountries(List<Country> countrylist)
        {
            throw new NotImplementedException();
        }

        private static void AddCountry(List<Country> countrylist)
        {
            throw new NotImplementedException();
        }
    }
}
