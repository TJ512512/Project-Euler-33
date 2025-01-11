using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Fraction = 1;
            for (float i = 1; i < 10; i++)
            {
                for (float j = 1; j < 10; j++)
                {
                    for (float k = 0; k < 10; k++)
                    {
                        for (float l = 0; l < 10; l++)
                        {
                            if (CancellingFractions(i, j, k, l) == true)
                            {
                                double Temp = Convert.ToDouble(String.Concat(i, j));
                                Temp /= Convert.ToDouble(String.Concat(k, l));
                                if (Temp < 1)
                                {
                                    Fraction *= Temp;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(Fraction);

            //Console.WriteLine(CancellingFractions(2, 9, 9, 8));
        }
        static bool CancellingFractions (float Digit1, float Digit2, float Digit3, float Digit4)
        {
            //Console.WriteLine(Digit1);
            float Numerator = int.Parse(String.Concat(Digit1, Digit2));
            float Denominator = int.Parse(String.Concat(Digit3, Digit4));
            float value = Numerator / Denominator;
            float SecondValue = 0;
            //Console.WriteLine(value);
            if (Digit1 == Digit3)
            {
                SecondValue = Digit2 / Digit4;
                //Console.WriteLine("1, 3");
                //Console.WriteLine(SecondValue);
            }
            else if (Digit1 == Digit4)
            {
                SecondValue = Digit2 / Digit3;
                //Console.WriteLine("1, 3");
                //Console.WriteLine(SecondValue);
            }
            else if (Digit2 == Digit3)
            {
                SecondValue = Digit1 / Digit4;
                //Console.WriteLine("2, 3");
                //Console.WriteLine(SecondValue);
            }
            else if (Digit2 == Digit4)
            {
                SecondValue = Digit1 / Digit3;
                //Console.WriteLine("2, 4");
                //Console.WriteLine(SecondValue);
            }
            else
            {
                return false;
            }
            if (value == SecondValue)
            {
                return true;
            }
            return false;
        }
    }
}
