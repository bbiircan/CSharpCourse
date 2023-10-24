using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro();
            string sentence = "My name is Rümeysa Bircan";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Eylül Ada Bircan";

            bool result3 = sentence.EndsWith("n");
            bool result4 = sentence.StartsWith("My");

            var result5 = sentence.IndexOf("namee"); //-1
            var result6 = sentence.IndexOf(" "); //2
            var result7 = sentence.LastIndexOf(" "); //20
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 =sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","*");
            var result13 = sentence.Remove(2,5); 


            Console.WriteLine(result13);
            Console.ReadLine();
        }
        private static void Intro()
        {
            string city = "Bursa";
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
