namespace metodos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine(" calcular a area do terreno");
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.WriteLine("digite a largura do terreno(m): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("digite o comprimento do terreno(m): ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(l, c);
        }

        static void area( double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine($"A area do terreno de {largura} x {comprimento} é de {a:F2}m²");
        }
    }
}
