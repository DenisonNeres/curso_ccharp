namespace exx06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("os valores informados formam um triangulo");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um triângulo equilatero.");
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC) || ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um triângulo isósceles. ");
                }
                else
                {
                    Console.WriteLine("E ele é um triângulo escaleno");
                }
                else
                {
                    Console.WriteLine("os valores informados nao foram um triângulo");
                }
            }
                

        }
}
