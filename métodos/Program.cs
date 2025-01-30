namespace métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // soma(3, 4);
            saudaçao("Denison");
        }

        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("a soma de " + a + " + " + b + " = " + resultado);
        }

        static void saudaçao(string nome)
        {
            Console.WriteLine(nome + ". Seja Bem Vindo");
        }
    }
}
