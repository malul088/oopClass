using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    public class Fraction
    {
        public int numerator;
        public int denominator;

        public Fraction() { }
        public Fraction(int _numerator, int _denomiator){
            if (_denomiator == 0)
                throw new DivideByZeroException();

            this.numerator = _numerator;
            this.denominator = _denomiator;
        }

        public static Fraction operator + (Fraction a, Fraction b)
        {
            Fraction newFraction = new Fraction();
            newFraction.numerator =  a.numerator * b.denominator + b.numerator * a.denominator;
            newFraction.denominator = a.denominator * b.denominator;
            return newFraction.getReduction();
        }
        
        public static Fraction operator - (Fraction a, Fraction b)
        {
            Fraction bNegative = new Fraction(b.numerator, b.denominator*-1);
            return (a + bNegative).getReduction();
        }
        public static Fraction operator * (Fraction a, Fraction b)
        {
            Fraction newFraction = new Fraction();
            newFraction.numerator = a.numerator * b.numerator;
            newFraction.denominator = a.denominator * b.denominator;
            return newFraction.getReduction();
        }
        
        public static Fraction operator / (Fraction a, Fraction b)
        {
            Fraction newFraction = new Fraction();
            newFraction.numerator = a.numerator * b.denominator;
            newFraction.denominator = a.denominator * b.numerator;
            return newFraction.getReduction();
        }
        public static bool operator == (Fraction a, Fraction b)
        {
            Fraction a1 = a.getReduction();
            Fraction b1 = b.getReduction();
            return (a1.numerator == b1.numerator && a1.denominator == b1.denominator);
        }
        public static bool operator != (Fraction a, Fraction b)
        {
            if (a == b)
                return false;
            else return true;
        }
        
        public static bool operator > (Fraction a, Fraction b)
        {
            if ((a - b).numerator > 0)
                return true;
            else return false;
        }
        
        public static bool operator < (Fraction a, Fraction b)
        {
            if (!(a>b) && !(a==b))
                return true;
            else return false;
        }

        public double getDouble() { 
            return (double)numerator/ (double)denominator;
        }
        
        public override string ToString() { 
            return numerator +"/"+denominator;
        }

        public Fraction getReduction()
        {
            int n1=numerator, n2=denominator;
            while (n2 != 0)
            {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            numerator /= n1;
            denominator /= n1;
            return this;
        }
    }
}
