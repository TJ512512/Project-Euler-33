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
            float[] Digit1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            float[] Digit2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            float[] Digit3 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            float[] Digit4 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double Fraction = 1;
            for (int i = 0; i < Digit1.Length; i++)
            {
                for (int j = 0; j < Digit2.Length; j++)
                {
                    for (int k = 0; k < Digit3.Length; k++)
                    {
                        for (int l = 0; l < Digit4.Length; l++)
                        {
                            if (CancellingFractions(Digit1[i], Digit2[j], Digit3[k], Digit4[l]) == true)
                            {
                                double Temp = Convert.ToDouble(String.Concat(Digit1[i], Digit2[j]));
                                Temp /= Convert.ToDouble(String.Concat(Digit3[k], Digit4[l]));
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
