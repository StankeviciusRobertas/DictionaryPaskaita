namespace DictionaryPaskaita
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string myCity = "Moletai";
            //List<string> citiesList = new List<string>
            //{
            //    "Vilnius",
            //    "Kaunas",
            //    "Siauliai",
            //    "Jonava",
            //};
            //Console.WriteLine("Printing cities list below: ");
            //foreach (string city in citiesList)
            //{
            //    Console.WriteLine(city);
            //}

            //Dictionary<string, int> cities = new Dictionary<string, int>
            //{
            //    { "Vilnius", 7 },
            //    { "Kaunas", 6 },
            //    { "Siauliai", 8 },
            //    { "Jonava", 6 },
            //    { "New York", 12 }
            //};
            //Console.WriteLine("Printing cities dictionary: ");
            //foreach (var cityKeyValuePair in cities)
            //{
            //    Console.WriteLine($"{cityKeyValuePair.Key} - {cityKeyValuePair.Value}"); // pasirenkama per Key miestas, per value int'a
            //}

            //List<int> myPoints = new List<int>() { 5, 9, 12 };
            //string myName = "Marius";

            //Dictionary<string, List<int>> playersPointsDictionary = new Dictionary<string, List<int>>()
            //{
            //    { "Ieva", new List<int>() { 9, 8, 10 } },
            //    { "Audrius", new List<int> { 8, 10, 8, 10, 10} },
            //    { "Veronika", new List<int> {10, 10,10 } },
            //    { myName, myPoints },
            //};
            //Console.WriteLine("Printing players points diciotnary: ");
            //foreach (var playersPoints in playersPointsDictionary)
            //{
            //    Console.Write($"{playersPoints.Key} - ");
            //    foreach(var point in playersPoints.Value)
            //    {
            //        Console.Write(point + " ");
            //    }
            //    Console.WriteLine();
            //}

            //// Nuskaityti konkretaus iraso reiksme: 
            //Console.WriteLine("Siauliai skaicius: " + cities["Siauliai"]);

            ////Ideti i dictionary nauja irasa:

            //cities["Londonas"] = 20;
            //cities["Siauliai"] = 18;

            ////Pakeisti esama value::
            //cities["Siauliai"] = cities["Jonava"] + cities["Kaunas"];

            //// Ar dictionary egzistuoja irasas su nurodomu key
            //if (cities.ContainsKey("New York"))
            //{
            //    Console.WriteLine("New York skaicius: " + cities["New York"]);
            //}
            //else
            //{
            //    Console.WriteLine("Dictionary nera miesto New York");
            //}

            //// Ar dcitionary egzistuoja irasas su nurodomu value

            //if(cities.ContainsValue(7))
            //{
            //    Console.WriteLine("Egzsituoja miestas su reiskme 7");
            //}
            //else
            //{
            //    Console.WriteLine("Miestas su reiksme 7 neegzistuoja ");
            //}

            //// Trinti reiksme is dictionary:
            //cities.Remove("New York");

            //// Atrenkami dictionary keys
            //Console.WriteLine("Printing dictionary keys: ");
            //foreach(var key in cities.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            //Console.WriteLine("Printing dictionary values: ");
            //foreach (var value in cities.Values)
            //{
            //    Console.WriteLine(value);
            //}

            ////Kvieciame varda ir amziu
            //namesAndAge();

            // Irasome Sali, gauname sostine
            //Console.WriteLine("Iveskit salies pavadinima Lietuva, Vokietija, Latvija, Lenkija ");
            //string country = Console.ReadLine();

            //string sostine = CountryAndCity(country);
            //Console.WriteLine($"Salies: {country}, Sostine: {sostine}");
            ////////////////////////////////////////////////////////////////////////////////////////

            //sukuriame Diciotnary sarasa
            //Dictionary<string, int> fruit = new Dictionary<string, int>
            //{
            //    { "apelsinas", 2 },
            //    { "mandarinas", 5 },
            //    { "obuolys", 4 }
            //};
            //// spausdiname dictionary
            //fruitPrint(fruit);
            ////pridedam nauja vaisiu
            //Console.WriteLine("Iveskit nauja vaisiu: ");
            //string newFruit = Console.ReadLine();
            //Console.WriteLine("Iveskite kieki: ");
            //int newValue = Convert.ToInt32(Console.ReadLine());

            //fruit = createNewFruit(fruit, newFruit, newValue);
            ////Spausdinam su pridetu vaisium
            //Console.WriteLine("Sarasas su pridetu vaisium");
            //foreach(var kvp in fruit)
            //{
            //    Console.WriteLine($"{kvp.Key}, {kvp.Value}");
            //}

            ////isimam vaisiu
            //Console.WriteLine("Isimkite vaisiu");
            //string removeFruit = Console.ReadLine();
            //fruit = RemoveFruit(fruit, removeFruit);
            ////spausdinam su isimtu vaisium
            //Console.WriteLine("sarasas su atimtu vaisium");
            //foreach(var kvp in fruit)
            //{
            //    Console.WriteLine($"{kvp.Key}, {kvp.Value}");
            //}
            //////////////////////////////////////////////////////////////

            Console.WriteLine("Iveskit sali: ");
            string country = Console.ReadLine();
            Dictionary<string, int> countryResidents = new Dictionary<string, int>();
            countryResidents = CityAndNumberOfResidents(country);

            foreach(var countryResident in countryResidents)
            {
                Console.WriteLine($"{countryResident.Key} {countryResident.Value}");
            }


        }
        public static Dictionary<string, int> CityAndNumberOfResidents(string country)
        {
            Dictionary<string, int> countryResidents = new Dictionary<string, int>
            {
                { "Lietuva", 1900 },
                { "Vokietija", 50 },
                { "Latvija", 5555 },
                { "Lenkija", 999595 }

            };
            return country;
        }
        public static Dictionary<string, int> RemoveFruit(Dictionary<string, int> fruit, string removeFruit)
        {
            fruit.Remove(removeFruit);
            return fruit;
        }
        public static Dictionary<string, int> createNewFruit(Dictionary<string, int> fruit, string newFruit, int newValue)
        {
            fruit[newFruit] = newValue;
            return fruit;
        }
        public static void fruitPrint(Dictionary<string, int> fruit)
        {
            foreach (var item in fruit)
            {
                Console.WriteLine($"{item.Key} kiekis: {item.Value}");
            }
        }
        public static string CountryAndCity(string country)
        {
            Dictionary<string, string> countryCity = new Dictionary<string, string>
            {
                { "Lietuva", "Vilnius" },
                { "Vokietija", "Berlynas" },
                { "Latvija", "Ryga" },
                { "Lenkija", "Varsuva" }

            };
             if (countryCity.ContainsKey(country))
            {
                return countryCity[country];
            }
            else
            {
                return "Nurodytos salies zodyne nera";
            }
        }
        public static void namesAndAge()
        {
            Dictionary<string, int> nameAndAge = new Dictionary<string, int>
            {
                { "Robertas", 30 },
                { "Marius", 32 },
                { "Rokas", 25 },
                { "Linas", 18 }
            };

            Console.WriteLine("Spausdinam varda ir metus: ");
            foreach (var nameAge in nameAndAge)
            {
                Console.WriteLine($"{nameAge.Key} amzius: {nameAge.Value}");
            }    
        }
    }
}