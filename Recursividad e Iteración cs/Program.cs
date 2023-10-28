using System;

namespace TablasDeMultiplicarConWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESUL, T, I;
            string linea;

            Console.Write("Digite numeros: ");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            T = 1;

            while (T <= NUM)
            {
                I = 10;

                while (I >= 1)
                {
                    RESUL = T * I;
                    Console.WriteLine("{0} x {1} = {2}", T, I, RESUL);
                    I = I - 1;
                }

                T = T + 1;
            }

            Console.Write("Pulse una Tecla :");
            Console.ReadLine();
        }
    }
}
