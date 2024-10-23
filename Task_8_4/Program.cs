using System.Xml.Linq;
namespace Task_8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте введем данные о контакте.");
            Console.WriteLine("Введите ФИО: ");
            XElement myPerson = new XElement("Person");
            XAttribute myName = new XAttribute("name", Console.ReadLine());
            Console.WriteLine("Введите Улицу: ");
            XElement myAdress = new XElement("Adress");
            XElement myStreet = new XElement("Street", Console.ReadLine());
            Console.WriteLine("Введите номер дома: ");
            XElement myHNumber = new XElement("HouseNumber", Console.ReadLine());
            Console.WriteLine("Введите номер квартиры: ");
            XElement myFNumber = new XElement("FlatNumber", Console.ReadLine());
            XElement myPhones = new XElement("Phones");
            Console.WriteLine("Введите номер мобильного телефона: ");
            XElement myMPhone = new XElement("MobilePhone", Console.ReadLine());
            Console.WriteLine("Введите номер домашнего телефона: ");
            XElement myFPhone = new XElement("FlatPhone", Console.ReadLine());

            
            myAdress.Add(myStreet); myAdress.Add(myHNumber); myAdress.Add(myFNumber); 
            myPhones.Add(myMPhone); myPhones.Add(myFPhone);
            myPerson.Add(myName); myPerson.Add(myAdress); myPerson.Add(myPhones);

            myPerson.Save("_Person.xml");
            Console.WriteLine("Данные о контакте успешно сохранены в формате XML");
            Console.ReadKey();
        }
    }
}
