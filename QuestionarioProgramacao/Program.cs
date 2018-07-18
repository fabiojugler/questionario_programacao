using System;
using System.IO;
using System.Text.RegularExpressions;

namespace QuestionarioProgramacao
{
    public class Program
    {
        // 1 - Em C#, encontre o maior numero inteiro em um array
        static void Main(string[] args)
        {
            int maiorNumero = 0;
            int[] numeros = { 10, 52, 67, 31, 19 };

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                    maiorNumero = numeros[i];
            }

            // Exibe em um prompt o maior número do array.
            Console.WriteLine(maiorNumero);
            Console.ReadKey();

            // Executa o exercício 2 ao pressionar qualquer tecla
            ArquivosTelefone.Executar();
        }
    }

    // 2 - Em C#, me passe a lista de arquivos texto em um diretório específico quem possuem em seu conteúdo números de telefone em um formato específico.
    public class ArquivosTelefone
    {
        public static void Executar()
        {
            #region Geração dos arquivos de texto

            using (StreamWriter writer = new StreamWriter("C:/Users/Public/arquivo01.txt"))
            {
                writer.WriteLine("(41)32566666");
                writer.WriteLine("(41)3256-6666");
                writer.WriteLine("3256-6666");
            }

            using (StreamWriter writer = new StreamWriter("C:/Users/Public/arquivo02.txt"))
            {
                writer.WriteLine("(41)88760192");
                writer.WriteLine("98876-0192");
                writer.WriteLine("(41)98876-0192");
            }

            using (StreamWriter writer = new StreamWriter("C:/Users/Public/arquivo03.txt"))
            {
                writer.WriteLine("3398-3456");
                writer.WriteLine("32562366");
                writer.WriteLine("98374-1232");
            }

            string diretorio = "C:/Users/Public/";
            string[] arquivos = { "arquivo01.txt", "arquivo02.txt", "arquivo03.txt" };

            #endregion
            
            // Formato de telefone a ser procurado nos arquivos: (XX)9XXXX-XXXX ou (XX)XXXX-XXXX
            string telefoneDDDeSeparador = @"^(\([0-9]{2}\))([9]{1})?([0-9]{4})-([0-9]{4})$";
            Regex rx = new Regex(telefoneDDDeSeparador);

            // Realiza a busca nos arquivos
            for (int i = 0; i < arquivos.Length; i++)
            {
                string arquivo = diretorio + arquivos[i];

                if (!File.Exists(arquivo))
                    Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");

                using (StreamReader sr = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        MatchCollection matches = rx.Matches(linha);
                        if (matches.Count > 0)
                            Console.WriteLine(arquivos[i] + " - " + linha);
                    }
                }
            }
        }
    }
}
