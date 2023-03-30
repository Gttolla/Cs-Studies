namespace RelDol
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double rel;
            double dol;

            Console.WriteLine("Conversor de Dolar para Real.");
            Console.Write("$ ");
            
            str = Console.ReadLine();
            dol = float.Parse(str);
            rel = dol * 5.14;

            Console.WriteLine($"R$ {rel}");     
        }
    }
}
