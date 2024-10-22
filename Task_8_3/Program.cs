using System.Security.Cryptography;

namespace Task_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<Проверка повторов>>");
            HashSet<int> set1 = new HashSet<int>();
            
            for (int i = 0; i < 10; i++) {
                Console.WriteLine();
                Console.WriteLine("Введите число: ");
                int newNumber = Int16.Parse(Console.ReadLine());
                if (set1.Contains(newNumber))
                {
                    Console.WriteLine($"\nЧисло: {newNumber} уже присутсвует в наборе.");
                }
                else
                {
                    set1.Add(newNumber);
                    Console.WriteLine($"\nЧисло: {newNumber} успешно добавлено в набор.");
                } 
            }
            Console.WriteLine();
            Console.WriteLine("Набор set1: ");
            foreach( int set in set1 ) { Console.Write(set); };
            Console.ReadKey();
        }
    }
}
