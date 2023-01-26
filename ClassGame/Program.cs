using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    private static void Main(string[] args)
    {

        //Challenge 1
        /* create variables from these countries
        Finland: 
        - Name: Finland
        - Population: 5530719
        - Region: Europe,
        - Capital: Helsinki
        - GDP: 27.3
        - Languages: Finnish, Swedish
        - Cities: Helsinki, Tampere, Lahti, Porvo, Kemi
        - Borders: Norway, Sweden, Russia
         */
        var Finland = new Country(
"Finland", 5530719, "Europe", "Helsinki", 27.3, new string[] { "Finnish", "Swedish" }, new string[] { "Helsinki", "Tampere", "Lahti", "Porvo", "Kemi" },
new string[] { "Norway", "Sweden", "Russia" }
        );
        Country.HasBorder(Finland);
        Finland.HasBorder("Finland");
        Country.CheckWealth(Finland);
        var FinCities = Finland[0..4];
        var FirstCity = Finland[0];
        /* Write methods to print FinCities and FirstCity */

        //Challenge 2
        /* write your own game */
    }



    class Country
    {
        /* provide your code for challenge 1 here */
        public string Name { get; set; }
        public int Population { get; set; }
        public string Regionn { get; set; }
        public string Capital { get; set; }
        public double GDPPerCapital { get; }
        public string[] Languages { get; set; }
        public string[] Cities { get; set; }
        public string[]? Borders { get; set; }

        public enum CheckWealthEnum
        {
            Poor, Medium, Rich
        }

        public Country(string name, int population, string regionn, string capital,
        double gdpPerCapital, string[] languages, string[] cities,
        string[]? borders)
        {
            Name = name;
            Population = population;
            Regionn = regionn;
            Capital = capital;
            GDPPerCapital = gdpPerCapital;
            Languages = languages;
            Cities = cities;
            Borders = borders;
        }

        public static bool HasBorder(Country country)
        {
            if (country.Borders.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasBorder(string country)
        {
            if (country == Name && Borders.Length > 0)
            {
                System.Console.WriteLine(true);
                return true;
            }
            else
            {
                System.Console.WriteLine(false);
                return false;
            }
        }

        public static string CheckWealth(Country country)
        {
            var wealthLevel = country.GDPPerCapital switch
            {
                <= 5000 => CheckWealthEnum.Poor.ToString(),
                > 5000 and <= 15000 => CheckWealthEnum.Medium.ToString(),
                > 15000 => CheckWealthEnum.Rich.ToString(),
            };
            System.Console.WriteLine(wealthLevel);
            return wealthLevel;
        }

        public string[] this[Range range]
        {
            get
            {
                return Cities[range];
            }
        }

        public string this[int Index]
        {
            get
            {
                return Cities[Index];
            }
        }
    }



    class Cities
    {
    }

    class Room
    {
        /* provide your code for challenge 2 here */
    }

    class Player
    {
        /* provide your code for challenge 2 here */
    }
}

