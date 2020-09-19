using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkoGalavićKlasePonavljanje
{
    class Objektni
    {
        private double postotak;
        private double Postotak;

        public override string ToString()
        {
            string ispis = "\n1.postotak : " + postotak + "\n2.postotak: " + Postotak;
            return ispis;
        }
        public Objektni()
        {

        }

        public Objektni(double postotak, double Postotak)
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
