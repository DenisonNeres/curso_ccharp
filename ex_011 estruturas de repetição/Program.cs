namespace ex_011_estruturas_de_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("contagem regresiva");
            Console.WriteLine("===================");

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
