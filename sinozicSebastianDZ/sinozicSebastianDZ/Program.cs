using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianDZ
{
    class Program
    {
        static void Main(string[] args)
        {


            float ocjena, brojac = 0, prosjek = 0;
            Console.WriteLine("Upisite ocjene");
            ocjena = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (ocjena == 1)
                {
                    Console.WriteLine("Prosjek je 1 ");
                    goto dalje;
                }
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Kriva ocjena");
                    
                }
                prosjek = prosjek + ocjena;
                brojac++;
                ocjena = Convert.ToInt32(Console.ReadLine());
            } while (ocjena != 0);

            prosjek = prosjek / brojac;
            Console.WriteLine("Prosjek ocjena je: " + prosjek);

        dalje:

            Console.ReadKey();



        }
    }
}
