namespace ex_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;
            Console.Write("digite o genero: ");
            genero = Console.ReadLine().ToUpper();


            while (genero != "F" && genero != "M")
            {
                Console.Write("DIGITE O GENERO: ");
                genero = Console.ReadLine().ToUpper();
            }
            Console.WriteLine(" bem-vindos e bem-vindas ao curso de c#!");
        }
    }
}
