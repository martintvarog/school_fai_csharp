using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double myWeight2020 = 69.5;
            double myWeight2021;

            string weightAsString;
            Console.WriteLine("What is your current weight?");
            weightAsString = Console.ReadLine();
            myWeight2021 = double.Parse(weightAsString);

            bool isMyWeightLower;
            isMyWeightLower = myWeight2020 > myWeight2021;

            Console.WriteLine("Did I loose weight?");
            Console.WriteLine(isMyWeightLower);
            Console.ReadKey();
        }
    }
}
