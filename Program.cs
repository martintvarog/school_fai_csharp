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
            int max = 100;
            bool jePrvocislo;

            for(int cislo = 2; cislo <= max; cislo++)
            {
                jePrvocislo = true;
                
                for(int i = cislo - 1; i > 1; i-- )
                {
                    if(cislo % i == 0)
                    {
                        jePrvocislo = false;
                        break;
                    }
                }
                if(jePrvocislo)
                {
                    Console.WriteLine(cislo);
                }
            }
        }
    }
}
