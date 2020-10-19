using System;

namespace Laboratorna_2_4
{
    class Address
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address adress = new Address();
            adress.index = 30773;
            adress.country = "Ukraine";
            adress.city = "Kyiv";
            adress.street = "MagMurMeow";
            adress.house = 43;
            adress.apartment = 13;
            Console.WriteLine(adress.index + Environment.NewLine
                + adress.country + Environment.NewLine
                + adress.city + Environment.NewLine
                + adress.street + Environment.NewLine
                + adress.house + Environment.NewLine
                + adress.apartment);
            Console.ReadKey();
        }
    }
    
}
