using System;

namespace md02_CadernoExercicios_04
{
    class Program
    {
        /*
         4. Escrever um algoritmo para ler dois valores numéricos e apresentar a diferença do
            maior pelo menor
         */
        static void Main(string[] args)
        {
            int v1, v2, res=0;

            Console.WriteLine("Digite o Primeiro valor;");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor;");
            v2 = Convert.ToInt32(Console.ReadLine());

            //v1 > v2 | v1 < v2

            if (v1 > v2)
            {
                res = v1 - v2;
                Console.WriteLine("O primeiro valor é maior que o segundo.\n Sendo que a diferença" +
                    " do maior para o menor é: {0}", res.ToString("0"));
            }
            else
            {
                res = v2 - v1;
                Console.WriteLine("O segundo valor é maior que o primeiro.\n Sendo que a diferença" +
                    " do maior para o menor é: {0}", res.ToString("0"));
            }

        }
    }
}
