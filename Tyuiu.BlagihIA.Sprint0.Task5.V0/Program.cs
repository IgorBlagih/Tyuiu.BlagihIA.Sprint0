using Tyuiu.BlagihIA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.BlagihIA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" A + B = " + DataService.Addition(3, 5));

            Console.WriteLine("A - B = " + DataService.Substraction(10, 7));

            Console.WriteLine("A * B = " + DataService.Multiplication(5, 8));

            Console.WriteLine("A / B = " + DataService.Division(15, 0));

            Console.ReadKey();
        }
    }
}
