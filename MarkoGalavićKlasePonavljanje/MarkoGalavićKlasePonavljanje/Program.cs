using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkoGalavićKlasePonavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            double postotak;
            double Postotak;

            Produceralni x = new Produceralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            x.setpostotak(x.getpostotak());
            x.setPostotak(x.getPostotak());

            y.setpostotak(y.getpostotak());
            y.setPostotak(y.getPostotak());

            z.setpostotak(z.getpostotak());
            z.setPostotak(z.getPostotak());


            if (postotak + Postotak > 100)
            {

            }

            Console.WriteLine(":" + x);
            Console.WriteLine(":" + y);
            Console.WriteLine(":" + z);
            Console.ReadKey();
        }
    }
}
