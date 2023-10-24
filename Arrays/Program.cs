using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Bircan", "Betül", "Eylül Ada" };

            string[] students2 ={"Bircan", "Betül", "Eylül Ada"};

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","Bursa","Balıkesir", },
                {"Kayseri","Nevşehir","Eskişehir", },
                {"Burdur","Antalya","Mersin", },
                {"Artvin","Rize","Trabzon", },
                {"Manisa","Aydın","Muğla", }

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~");
            }

            Console.ReadLine();
        }
    }
}
