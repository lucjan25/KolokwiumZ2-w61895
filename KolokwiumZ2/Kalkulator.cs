using System;

namespace KolokwiumZ2
{
    public class Kalkulator
    {

        public Kalkulator(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        #region Wlasciwosci
        public double a { get; set; }
        public double b { get; set; }
        #endregion

        #region Dzialania
        public double Suma()
        {
            return a + b;
        }
        public double Roznica()
        {
            return a - b;
        }
        public double Iloczyn()
        {
            return a * b;
        }
        public double Iloraz()
        {
            if (b != 0)
                return a / b;
            else
                throw new ArgumentException("Proba dzielenia przez 0");
        }
        public double Potega()
        {
            return Math.Pow(a, b);
        }
        #endregion
    }
}
