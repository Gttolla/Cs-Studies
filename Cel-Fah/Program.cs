namespace CelFah
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel;
            double fah; 
            
            Console.WriteLine("Conversor de Celsius para Fahrenheit.");
            Console.Write("°C ");

            cel = double.Parse(Console.ReadLine());
            fah = cel * 1.8 + 32;

            Console.Write("°F ");
            Console.Write(fah);
        }
    }
}