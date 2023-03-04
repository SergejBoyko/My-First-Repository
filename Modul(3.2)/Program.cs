using System; // Подключенное пространство имен
using System.Data;

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
            //string MyName = "Сергей";
            //Console.WriteLine(MyName);
            //Console.WriteLine("\tПривет,мир"+"\n\tМне 25 лет"+"\n\tMy name is \n  Сергей");
            //Задание 3.2.8
            //Console.WriteLine("\u0040");
            //Console.WriteLine(" \x23");
            //Console.ReadKey();
            //Задание 3.3.2
            //string MyName = "Sergej";
            //byte MyAge = 25;
            //bool HaveIApet = false;
            //double MyShoeSize = 42;

            //Console.WriteLine("My name is " + MyName);
            //Console.WriteLine("MyAge " + MyAge);
            //Console.WriteLine("Do I have a pet? " + HaveIApet);
            //Console.WriteLine("My shoe size is " + MyShoeSize);
            //Задание 3.4.3
            //enum DaysOfWeek : byte
            //{
            //    Monday = 1,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday
            //    Sunday
            //}
            //enum Semaphore : int
            //{
            //    Red = 100,
            //    Yellow = 200,
            //    Green = 300,
            //}
            //Задание 3.7
            //Console.WriteLine("Enter your name:" );
            //var name = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //var age = Console.ReadLine();
            //Console.WriteLine("Your name is {0} and age is {1}",name,age);
            //Console.WriteLine("Enter your birthdate: ");
            //var birthdate = Console.ReadLine();
            //Console.WriteLine("Your birthdate {0}", birthdate);
            //Задание 4.1.4
            //string a, b;
            //a = "123";
            //b= "124";
            //bool c = (a != b);
            //Console.WriteLine(c);
            //Задание 4.1.5
            //int a,b;
            //double x,y;
            //a= 1;
            //b= 2;
            //y = 3;
            //x= 4;
            //bool z = (a<b)|(x<y);
            //Console.WriteLine(z);
            //Задание 4.1.12
            //var a = 7;
            //var b = 7;

            //if (a == b)
            //{
            //    Console.WriteLine("Условие истинно");
            //}
            //else
            //{
            //    Console.WriteLine("Условие ложно");
            //}
            //Задание 4.1.17
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
        }
    }
}
