using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numeroPar = 0;

            Console.WriteLine("Sequência de números pares a partir de zero");
            Console.Write("Informe um número inteiro positivo: ");

            numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero <= 0)
            {
                Console.WriteLine($"O número {numero} não é positivo");
            }
            else
            {
                Console.WriteLine($"Números pares entre 0 e {numero}");

                Console.WriteLine("WHILE: ");
                while(numeroPar <= numero)
                {
                    Console.Write($"{numeroPar} ");
                    numeroPar = numeroPar + 2;
                }

                numeroPar = 0;
                Console.WriteLine("\n\nDO..WHILE: ");
                do
                {
                    Console.Write($"{numeroPar} ");
                    numeroPar = numeroPar + 2;                    
                }while(numeroPar <= numero);

                Console.WriteLine("\n\nFOR: ");
                for(numeroPar = 0; numeroPar <= numero; numeroPar +=2)
                {
                    Console.Write($"{numeroPar} ");
                }

            }
        }
    }
}
