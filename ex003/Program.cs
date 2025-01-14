namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, resposta;
            num1 = 45;
            num2 = 35;
            
            resposta = num3 = num1 + num2;
            Console.WriteLine("a soma de {0} + {1} = {2}" , num1, num2, num3);

            resposta = num3 = num1 - num2;
            Console.WriteLine("a subtração de {0} - {1} = {2}" , num1, num2, num3);

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
