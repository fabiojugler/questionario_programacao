using System;

namespace QuestionarioProgramacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1 - Em C#, encontre o maior numero inteiro em um array

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

            // Exibe em um prompt o maior número do array.
            Console.WriteLine(maiorNumero);
            Console.ReadKey();

            ArquivosTelefone.Executar();
        }
    }

    public class ArquivosTelefone
    {
        public static void Executar()
        {
            
        }
    }
}
