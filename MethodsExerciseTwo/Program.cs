using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExerciseTwo
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(Modulus(2, 4));
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(Multiply(4, 6));
            Console.WriteLine(Subtract(5, 7));
            Console.WriteLine(Divide(6, 8));
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }

}
