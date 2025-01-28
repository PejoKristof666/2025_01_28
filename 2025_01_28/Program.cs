using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_28
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Multiply
    {
        public virtual int Valami(int num)
        {
            return num * 5;
        }
        public double masikValami(int numB, int numC)
        {
            if (numB > numC)
            {
                return ((double)numB + (double)numC) / (double)numC;
            }
            else
            {
                return ((double)numB + (double)numC) / (double)numB;
            }
        }
    }
    public class OtherClass : Multiply
    {
        public override int Valami(int num)
        {
            return num * 7;
        }
        public double ThreeParameter(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
    }
}
