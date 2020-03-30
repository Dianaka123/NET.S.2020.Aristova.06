using System;
using System.Data;

namespace NET.S._2020.Aristova._06
{
    public sealed class Polynomial
    {
        
        public int[] Coefficients { get; set; }
        

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {

            int[] minArrayCoefficient;
            int[] maxArrayCoefficient;
           
            ChoiseArray(p1, p2,out minArrayCoefficient,out maxArrayCoefficient);

            int[] newCoefficient = new int[maxArrayCoefficient.Length];

            int minLength = minArrayCoefficient.Length - 1; // length min array

            int diff = maxArrayCoefficient.Length - minArrayCoefficient.Length; // difference between max and min length

            for (int i = maxArrayCoefficient.Length - 1; i >= 0; i--)
            {
                newCoefficient[i] = maxArrayCoefficient[i];

                if (i - diff >= 0) 
                {
                    newCoefficient[i] += minArrayCoefficient[minLength];
                    minLength--;
                }
            }
            
            return new Polynomial {Coefficients = newCoefficient};
        }


        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {

            int[] newCoefficient = new int[p1.Coefficients.Length + p2.Coefficients.Length - 1];

            for (int i = 0; i < p1.Coefficients.Length; ++i)
            for (int j = 0; j < p2.Coefficients.Length; ++j)
                newCoefficient[i + j] += p1.Coefficients[i] * p2.Coefficients[j];

            return new Polynomial {Coefficients = newCoefficient};
        }

        public static bool operator ==(Polynomial p1, Polynomial p2)
        {
            
            return p2.Equals(p1);
        }

        public static bool operator !=(Polynomial p1, Polynomial p2)
        {
            
            return !p1.Equals(p2);
        }

        public bool Equals(Polynomial other)
        {
            ThrowNullException(other);
            return Equals(Coefficients, other.Coefficients);
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is Polynomial other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Coefficients);
        }

        public override string ToString()
        {
            string preview = "";
            int pow = Coefficients.Length;
            for (int i = 0; i < Coefficients.Length; i++)
            {
                if (i == Coefficients.Length - 1)
                {
                    preview += $"{Coefficients[i]}";
                    break;
                }
                preview += $"{Coefficients[i]}x^{--pow} +";
                
            }
            return preview;
        }

        private static void ThrowNullException(Polynomial p1)
        {
            if (p1 == null)
            {
                throw new ArgumentNullException();
            }
        }

        private static void ChoiseArray(Polynomial p1, Polynomial p2, out int[] minArrayCoefficient, out int[] maxArrayCoefficient)
        {
            if (p1.Coefficients.Length != p2.Coefficients.Length)
            {
                minArrayCoefficient =
                    p1.Coefficients.Length < p2.Coefficients.Length ? p1.Coefficients : p2.Coefficients;
                maxArrayCoefficient =
                    p1.Coefficients.Length > p2.Coefficients.Length ? p1.Coefficients : p2.Coefficients;
            }
            else
            {
                minArrayCoefficient = p1.Coefficients;
                maxArrayCoefficient = p2.Coefficients;
            }
        }

    }

}