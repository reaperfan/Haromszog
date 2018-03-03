using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    class DHarmoszog
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;
        private int sorSzam;
        public double AOldal
        {
            get
            {
               return aOldal;
            }
            set
            {
                if (value > 0)
                {
                    this.aOldal = value;
                }
                else
                {
                    throw new Exception(String.Format("{0}. sor: Az 'a' oldal nem lehet nulla vagy negatív", this.sorSzam) + " a oldal: " + this.aOldal);
                }
            }
        }

        public double BOldal
        {
            get
            {
                return bOldal;
            }
            set
            {
                if (value > 0)
                {
                    this.bOldal = value;
                }
                else
                {
                    throw new Exception(String.Format("{0}. sor: Az 'b' oldal nem lehet nulla vagy negatív", this.sorSzam) + " b oldal: " + this.bOldal);
                }
            }
        }

        public double COldal
        {
            get
            {
                return cOldal;
            }
            set {
                if (value > 0)
                {
                    this.cOldal = value;
                }
                else
                {
                    throw new Exception(String.Format("{0}. sor: Az 'c' oldal nem lehet nulla vagy negatív", this.sorSzam)+" c oldal: " + this.cOldal);
                }
            }
        }
        private bool EllDerekszogu
        {
            get
            {
                return (Math.Pow(this.cOldal, 2) == Math.Pow(this.aOldal, 2) + Math.Pow(this.bOldal, 2));
                
            }
        }
        private bool EllMegszerkeztheto
        {
            get
            {
                return this.aOldal + this.bOldal > this.cOldal;
                
            }
        }
        private bool EllNovekvoSorrend
        {
            get
            {
                return this.aOldal <= this.bOldal && this.bOldal <= this.cOldal;
            }
        }
        public double Kerulet
        {
            get
            {
                return this.aOldal + this.bOldal + this.cOldal;
            }

        }
        public double Terulet
        {
            get
            {
                return this.aOldal * this.bOldal / 2;
            }
        }
        public int SorSzama
        {
            get
            {
                return this.sorSzam;
            }
            set
            {
                sorSzam = value;
            }
        }
        
        public DHarmoszog(string sor,int sorszam) 
        {
            string[] oldalak = sor.Split(' ');
            
           
           
            this.sorSzam = sorszam;
            this.AOldal = Convert.ToDouble(oldalak[0]);
            this.BOldal = Convert.ToDouble(oldalak[1]);
            this.COldal = Convert.ToDouble(oldalak[2]);
            if (!EllNovekvoSorrend)
            {
                throw new Exception(
                   String.Format("{0}. sor: Az adatok nincsenek növekvő sorrendben",this.SorSzama));
            }
            if (!EllMegszerkeztheto)
            {
                throw new Exception(
                    String.Format("{0}. sor: A háromszöget nem lehet megszerkeszteni!",this.SorSzama));
            }
            if (!EllDerekszogu)
            {
                throw new Exception(String.Format("{0}. sor:  A háromszög nem derékszögű!",this.SorSzama));
            }
        }
        public override string ToString()
        {
            return String.Format("{0}.sor : a={1}, b={2}, c={3}", this.sorSzam, this.aOldal, this.bOldal, this.cOldal);
        }



    }
}
