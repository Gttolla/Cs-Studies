namespace SNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            int numA;
            int count = 1;
            int MinNum = int.MaxValue;
            int MaxNum = 0;

            Console.WriteLine("");

            Console.WriteLine("Escreva uma sequêcia de números!");
            Console.Write("Quantos números teram essa sequência? ");
            
            numA = int.Parse(Console.ReadLine());
            if (numA < 3)
            {
                Console.WriteLine("");
                Console.WriteLine("A sequência deve conter mais de 2 números!");
            }
            else
            {
                num = new int[numA];

                Console.WriteLine("");

                for (int r = 0; r < num.Length; r++)
                {
                    Console.Write($"Número {count++}: "); 
                    num[r] = int.Parse(Console.ReadLine()); 
                    if (MaxNum < num[r])
                    {
                        MaxNum = num[r];
                    } 
                    if (MinNum > num[r])
                    {
                        MinNum = num[r];
                    }
                }

                Console.WriteLine("");

                Console.WriteLine($"A média da sequência é: {num.Sum() / num.Length}");
                Console.WriteLine($"O maior número da sequência é: {MaxNum}");
                Console.WriteLine($"O menor número da sequência é: {MinNum}");

            }
            
        }
    }
}