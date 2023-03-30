namespace ImpostoSal
{
    class Program
    {
        static void Main(string[] args)
        {            
            string sal;
            double numS;
            double numI;

            Console.Write("Digite seu salário: ");

            sal = Console.ReadLine();
            numS = double.Parse(sal);
            numI = numS;  

            if (numS < 1903.88)
            {   
                Console.WriteLine("Você é isento de imposto de renda.");
            }
            else if ((numS >= 1903.99) && (numS < 2826.66))
            {
                Console.WriteLine("Seu imposto é de 7,5%");
                Console.Write("Renda final: ");
                Console.Write(numS - numI * 0.075);
            }   
            else if ((numS >= 2826.66) && (numS < 3751.06))
            {
                Console.WriteLine("Seu imposto é de 15%");
                Console.Write("Renda final: ");
                Console.Write(numS - numI * 0.15); 
            }      
             else if ((numS >= 3751.06) && (numS < 4664.68))
            {
                Console.WriteLine("Seu imposto é de 22,5%");
                Console.Write("Renda final: ");
                Console.Write(numS - numI * 0.225); 
            }   
             else if (numS >= 4664.68)
            {
                Console.WriteLine("Seu imposto é de 27,5%");
                Console.Write("Renda final: ");
                Console.Write(numS - numI * 0.275); 
            }        
        }
    }
}