namespace Task_8_2
{
    internal class Program
    {
        static void AddPhones(ref Dictionary<string, string> phoneNumbers)
        {
            string Number = String.Empty;
            string FIO = String.Empty;
            Console.WriteLine("Необходимо ввести номера телефонов в справочник. Как только Вы введете пустой номер телефона будем считать что справочник заполнен.");
            do
            {
                Console.Write("Введите номер телефона: ");
                Number = Console.ReadLine();
                if (!String.IsNullOrEmpty(Number))
                {
                    Console.Write("Введите ФИО: ");
                    FIO = Console.ReadLine();
                    if (!String.IsNullOrEmpty(FIO))
                    {
                        phoneNumbers.Add(Number, FIO);
                    }
                }
            }
            while (!String.IsNullOrEmpty(Number));
        }
        static void Print(Dictionary<string, string> phoneNumbers)
        {
            foreach (KeyValuePair<string, string> e in phoneNumbers) Console.WriteLine($"{e}");
            Console.ReadKey();
        }
        static void FindbyNumber(Dictionary<string, string> phoneNumbers, string number)
        {
            if(phoneNumbers.TryGetValue(number, out var result))
            {
                Console.WriteLine($"Номер - {number} записан на ФИО: {result}");
            }
            else
            {
                Console.WriteLine("Номер не найден.");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("<<Телефонный справочник>>");
            Dictionary<string,string> phones = new Dictionary<string,string>();
            AddPhones(ref phones);
            Print(phones);
            Console.WriteLine("Введите номер телефона для поиска в справочнике: ");
            string findnumber = Console.ReadLine();
            FindbyNumber(phones, findnumber);
        }
    }
}
