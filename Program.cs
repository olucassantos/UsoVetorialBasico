using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoVetorialBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 5;
            string[] nomes = new string[quantidade];

            // Cria um laço para solicitar nomes
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Escreva um nome: ");
                nomes[i] = Console.ReadLine();
            }

            // Percorrer o vetor e escrever seus valores
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            // Percorrer o vetor e escrever seus valores
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}