using System; // Подключенное пространство имен

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            //Задание 3.2.4
            //string MyName;
            //MyName = "Сергей";
            //Console.WriteLine(MyName);
            //Задание 3.2.4
            string MyName = "Сергей";
            Console.WriteLine(MyName);
            Console.WriteLine("\tПривет,мир"+"\n\tМне 25 лет"+"\n\tMy name is \n  Сергей");
            //Задание 3.2.8
            Console.WriteLine("\u0040");
            Console.WriteLine(" \x23");
            Console.ReadKey();
        }   
    }
}
