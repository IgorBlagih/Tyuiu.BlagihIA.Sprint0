using Tyuiu.BlagihIA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.BlagihIA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1,5));

            Console.WriteLine(DataService.Substraction(10, 5));

            Console.WriteLine(DataService.Multiplication(6, 7));
            
            Console.WriteLine(DataService.Division(64, 4));

            Console.ReadKey();
        }
    }
}
