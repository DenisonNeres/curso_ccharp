namespace area_do_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Solicitar a base e a altura do triâgulo
            Console.WriteLine("Digite o valor da base do triangulo: ");
            double BaseTriagulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triângulo: ");
            double AlturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double area = (BaseTriagulo * AlturaTriangulo) / 2;

            Console.WriteLine("A area do tringulo é:" + area);
            
        }
    }
}
