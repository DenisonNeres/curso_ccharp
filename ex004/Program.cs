namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;
            float num4, resposta;
            Console.WriteLine("digite um numero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite outro numero:");
            num2 = Convert.ToInt32(Console.ReadLine());





            resposta = num3 = num1 + num2;
            Console.WriteLine("a soma de {0} + {1} = {2}", num1, num2, num3);

            resposta = num3 = num1 - num2;
            Console.WriteLine("a subtração de {0} - {1} = {2}", num1, num2, num3);

            resposta = num3 = num1 * num2;
            Console.WriteLine("a multiplicação de {0} * {1} = {2}", num1, num2, num3);

            resposta = num3 = num1 / num2;
            Console.WriteLine("a divisao de {0} / {1} = {2}", num1, num2, resposta);


            num4 = num3 = num1 % num2;
            Console.WriteLine("a porcetagem de {0} / {1} = {2}", num1, num2, num3);

            num4 = 35f;
            resposta = num1 / num2;

            Console.WriteLine("a divisao de {0} / {1} = {2}", num1, num4, resposta);
        }
    }
}
