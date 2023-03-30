namespace VNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if(num < 0)
            {
                Console.Write("Seu número é negativo");
            }
            else if (num == 0)
            {   
                Console.Write("Seu número é 0");
            }
            else if (num > 0)
            {
                Console.Write("Seu número é positivo");
            }


        }
    }
}