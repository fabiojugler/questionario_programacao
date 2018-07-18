using System;

namespace QuestionarioProgramacao
{
    class MaiorNumero
    {
        static void Main(string[] args)
        {
            int maiorNumero = 0;
            int[] numeros = new int[5];
            numeros[0] = 10;
            numeros[1] = 52;
            numeros[2] = 67;
            numeros[3] = 31;
            numeros[4] = 19;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                    maiorNumero = numeros[i];
            }

            Console.WriteLine(maiorNumero);

            // Mantém o console aberto.
            Console.ReadKey();
        }
    }
}
