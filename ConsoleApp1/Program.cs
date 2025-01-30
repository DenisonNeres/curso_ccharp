using System.Diagnostics.Tracing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Denison Neres");
            Console.WriteLine();
        }
        static void escreva(string texto)
        {
            /* 
            
            char caracter = '=';
            int tamanho = texto.Length + 4;
            string linha = new string(caracter, tamanho);
            string textoCentralizado = texto.PadLeft(2 + texto.Length).PadLeft(tamanho);
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }

    }
}
