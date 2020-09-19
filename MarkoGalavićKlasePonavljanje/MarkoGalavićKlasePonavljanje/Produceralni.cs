using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkoGalavićKlasePonavljanje
{
    class Produceralni
    {
        private double postotak;
        private double Postotak;

        public override string ToString()
        {
            string ispis = "\nBrzina oko osi: " +postotak + "\nBrzina oko Sunca: " + Postotak;
            return ispis;
        }
        public Produceralni()
        {

        }

        public Produceralni(double postotak, double Postotak)
        {
            this.postotak = postotak;
            this.Postotak = Postotak;
        }




        public double getpostotak()
        {
            return postotak;
        }
        public void setpostotak(double postotak)
        {
            this.postotak = postotak;
        }
        public double getPostotak()
        {
            return Postotak;
        }
        public void setPostotak(double Postotak)
        {
            this.Postotak = Postotak;
        }

    }
}
