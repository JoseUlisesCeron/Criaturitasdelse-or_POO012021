using System;

namespace Labwork01
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS LAS VARIABLES 
            int num1 = 0, num2 = 0;

            Console.WriteLine("Digite el primer numero para multiplicar: ");
            num1 =  Int32.Parse (Console.ReadLine());

            Console.WriteLine("Digite el segundo numero para multipolicargit ad: ");
            num2 = Int32.Parse (Console.ReadLine());
            //sumamos las variables 
             Console.WriteLine($"multiplicando {num1} * {num2} igual {AddNumbers(num1, num2)}" );

        }
            public static int AddNumbers(int num1, int num2)
            {
              return num1 * num2;
            }

    }
}