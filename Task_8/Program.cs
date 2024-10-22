namespace Task_8
{
    internal class Program
    {
        static List<int> AddItem()
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(rand.Next(100));
            }
            return list;
        }
        static void Print(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nЭлементов в коллекции: {list.Count}");
        }
        static void Remove(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    list.RemoveAt(i);
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> list = AddItem();
            Console.WriteLine("Коллекция заполнена:");
            Print(list);
            Remove(list);
            Console.WriteLine("\nИз коллекции удалены элементы в которых значение больше 25 и меньше 50");
            Print(list);
            Console.ReadLine();
        }
    }
}
