using System; // Подключенное пространство имен
using System.Data;
using System.Globalization;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    /*class Program*/ // Объявление класса Program

    //static void Main(string[] args) // Объявление метода Main
    //{
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
    //var color = Console.ReadLine();
    //if (color == "red")
    //{
    //    Console.BackgroundColor = ConsoleColor.Red;
    //    Console.ForegroundColor = ConsoleColor.Black;
    //    Console.WriteLine("Your color is red!");
    //}
    //else if (color == "green")
    //{
    //    Console.BackgroundColor = ConsoleColor.Green;
    //    Console.ForegroundColor = ConsoleColor.Black;
    //    Console.WriteLine("Your color is green!");
    //}
    //else
    //{
    //    Console.BackgroundColor = ConsoleColor.Cyan;
    //    Console.ForegroundColor = ConsoleColor.Black;
    //    Console.WriteLine("Your color is cyan!");
    //Задание 4.3.5
    //string[] name = new string[6] {"S","E","R","G","E","J"};
    //string[] eman = new string[6];
    //for (int i = 0; i < name.Length; i++)
    //{
    //    int y = (name.Length - 1) - i;
    //    eman[i] = name[y];
    //}
    //Задание 4.3.11
    //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

    //for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
    //{
    //    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
    //        Console.Write(array[k, i] + " ");

    //Console.WriteLine();
    //Задание 4.3.12
    //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
    //int temp;
    //for (int i = 0; i < arr.Length; i++)
    //{
    //    for (int j = i + 1; j < arr.Length; j++)
    //    {
    //        if (arr[i] > arr[j])
    //        {
    //            temp = arr[i];
    //            arr[i] = arr[j];
    //            arr[j] = temp;
    //        }
    //    }
    //}
    //foreach (var item in arr)
    //{
    //    Console.WriteLine(item);
    //}
    //Задание 4.3.13
    //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
    //int summ = 0;
    //for (int i = 0; i < arr.Length; i++)
    //{
    //    summ = summ+arr[i];
    //}
    //Console.WriteLine(summ);
    //Задание 4.3.14
    //int[][] array = new int[3][];
    //array[0] = new int[2] { 1, 2 };
    //array[1] = new int[3] { 1, 2, 3 };
    //array[2] = new int[5] { 1, 2, 3, 4, 5 };
    //foreach (var num in array) 
    //{
    //    foreach (var item in num)
    //    {
    //        Console.Write(item + " ");
    //    }                       
    //}
    //Задание 4.3.15
    //int[] arr = { 1, 2, 3, -1 , 0 , -3 , 6 , 7, -4};
    //int result = 0;
    //for (int i = 0; i < arr.Length; i++)
    //{
    //    if (arr[i]>0)
    //    {
    //        result += 1;
    //    }
    //}
    //Console.WriteLine(result);
    //Console.ReadLine();
    //Задание 4.3.16
    //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
    //int result = 0;
    //foreach (var item in arr)
    //{
    //    if (item > 0)
    //        result++;
    //}
    //Console.WriteLine(result);
    //Задание 4.4.2
    //Console.WriteLine("Введите ваше имя");
    //string i = Console.ReadLine();
    //Console.WriteLine("Введите ваш возвраст");
    //string y = Console.ReadLine();
    //var anketa = (name: i, age: y);
    //Console.WriteLine("Ваше имя: {0}, Ваш возвраст {1}",anketa.name,anketa.age);
    //Задание 4.5.1
    //(string name, string surname,string login,int loginlength,bool pet,double age,string[] colors) User;
    //for (int U = 0; U < 3; U++)
    //{
    //    Console.WriteLine("Введите имя");
    //    User.name = Console.ReadLine();
    //    Console.WriteLine("Введите фамилию");
    //    User.surname = Console.ReadLine();
    //    Console.WriteLine("Введите логин");
    //    User.login = Console.ReadLine();
    //    User.loginlength = User.login.Length;
    //    Console.WriteLine("Есть ли у вас животные? Да или Нет");
    //    string Rpet = Console.ReadLine();
    //    if (Rpet == "Да")
    //    {
    //        User.pet = true;
    //    }
    //    else { User.pet = false; }
    //    Console.WriteLine("Введите возраст пользователя");
    //    User.age = Convert.ToInt32(Console.ReadLine());
    //    User.colors = new string[3];
    //    Console.WriteLine("Введите три любимых цвета пользователя");
    //    for (int i = 0; i < User.colors.Length; i++)
    //    {
    //        User.colors[i] = Console.ReadLine();
    //    }
    //Задание 5.1
    //(string Name, string[] Dishes) User;

    //Console.WriteLine("Введите ваше имя");
    //User.Name = Console.ReadLine();
    //User.Dishes = new string[5];
    //for (int i = 0; i < User.Dishes.Length; i++)
    //{
    //    Console.WriteLine("Введите ваше любимое блюдо {0}",i + 1);
    //    User.Dishes[i] = Console.ReadLine();
    //}
    //Задание 5.1.6
    //static int[] GetArrayFromConsole()
    //{
    //    var result = new int[5];

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }
    //    int temp = 0;
    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        for (int j = 0; j < result.Length; j++)
    //            if (result[i] > result[j])
    //            {
    //                temp = result[i];
    //                result[i] = result[j];
    //                result[j] = temp;
    //            }
    //        for (int i = 0; i < result.Length; i++)
    //        {
    //            Console.WriteLine(result[i]);
    //        }
    //    }

    //    return result;
    //}
    //static void ShowColors(string[] favcolors)
    //{
    //    Console.WriteLine("Ваши любимые цвета:");
    //    foreach (var color in favcolors)
    //    {
    //        Console.WriteLine(color);
    //    }
    //}
    //Задание 5.2.8
    //static int[] GetArrayFromConsole(int num = 5)
    //{
    //    var result = new int[3];

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }
    //    return result;
    //}
    //static void ShowArray(int[] array, bool inSort = false)
    //{
    //    var temp = array;
    //    if (inSort)
    //    {
    //        temp = SortArray(array);
    //    }
    //    foreach (var item in temp)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}
    //static int[] SortArray(int[] result)
    //{
    //    int temp = 0;
    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        for (int j = 0; j < result.Length; j++)
    //            if (result[i] > result[j])
    //            {
    //                temp = result[i];
    //                result[i] = result[j];
    //                result[j] = temp;
    //            }
    //        return result;
    //    }
    //}
    //static void Main(string[] args)
    //{
    //    var array = GetArrayFromConsole(10);
    //    ShowArray(array, true);
    //}
    //static void Main(string[] args)
    //{
    //    var array = GetArrayFromConsole();
    //    var ortedarray= SortArray(array)
    //}
    //Задание 5.3.1
    //static void Main()
    //{
    //    var age = 25;
    //    Console.WriteLine(age);
    //    ChangeAge(ref age);
    //    Console.WriteLine(age);
    //}
    //        static void ChangeAge(ref int age)
    //{
    //   Console.WriteLine("Введите возраст");
    //   age = Int32.Parse(Console.ReadLine());

    //}
    //Задание 5.3.8
    //static void Main()
    //{
    //    int num = 6;
    //    GetArrayFromConsole(ref num);
    //}
    //static int[] GetArrayFromConsole(ref int num)
    //{
    //    var result = new int[num];

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }
    //    return result;
    //}
    //Задание 5.3.11
    //static void Main()
    //{
    //    int num1 = 1; int num2 = 2; int num3 = 3; int num4 = 4;
    //    SumNumbers(ref num1, num2, out num3, num4);
    //}
    //static int SumNumbers(ref int num1, in int num2, out int num3, out int num4)
    //{ }
    //Задание 5.5.3
    //class MainClass
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine("Напишите что-то");
    //            var modif = Console.ReadLine();

    //            Console.WriteLine("Укажите глубину эха");
    //            var deep = int.Parse(Console.ReadLine());

    //            Echo(modif, deep);

    //            Console.ReadKey();
    //        }

    //        static void Echo(string modif, int deep)
    //        {
    //                if (modif.Length > 2)
    //                {
    //                    modif = modif.Remove(0, 2);
    //                }
    //                Console.BackgroundColor= (ConsoleColor)deep;
    //                Console.WriteLine("..."+modif);

    //            if (deep > 1)
    //            {
    //                Echo(modif, deep - 1);
    //            }
    //        }
    //    }
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Введите Х");
    //    int N = int.Parse(Console.ReadLine());
    //    Console.WriteLine("Введите У");
    //    byte pow = Byte.Parse(Console.ReadLine());
    //    Console.WriteLine(PowerUp(N,pow));
    //    Console.ReadKey();
    //}
    //static int PowerUp(int N, byte pow)
    //{
    //    if (pow == 0) 
    //    {
    //        return 0;
    //    }
    //    else
    //    {
    //        if (pow == 1)
    //        {
    //            return N;
    //        }
    //        else
    //        {
    //            return N * PowerUp(N,--pow);
    //        }
    //    }
    //}
    //    static decimal Factorial(int x)
    //{
    //    if (x == 0)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        return x * Factorial(x - 1);
    //    }
    //Итоговый проект 5.6
    class Program
    {
        static (string name, string surname, int age, string pets, int colors) GetUserInfo()
        {
            (string name, string surname, int age, string pets, int colors) User;

            Console.WriteLine("Введите ваше имя: ");
            User.name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            User.surname = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите ваш возраст: ");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));
            User.age = intage;

            Console.WriteLine("Есть ли у вас питомец? ");
            User.pets = Console.ReadLine();
            if (User.pets == "да")
            {
                string number;
                do
                {
                    Console.WriteLine("Сколько у вас пbтомцев? ");
                    number = Console.ReadLine();
                } while (CheckNum(number, out intage));
                int quntity = Int32.Parse(number);
                string[] allpestname = new string[quntity];
                GetPetsName(allpestname);
            }
            else
            {
                User.pets = "У вас нет пмтомцев";
                Console.WriteLine(User.pets);
            }

            string color;
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов ? ");
                color = Console.ReadLine();
            }
            while (CheckNum(color, out intage));
            User.colors = intage;
            if (User.colors > 0)
            {
                string[] colorsname = new string[User.colors];
                GetColorsName(colorsname);
            }
            else
            {
                User.colors = 0;
                Console.WriteLine("У вас нет любимых цветов");
            }
            ViewResult(User.name,User.surname,User.age,User.pets,User.colors);
            return User;
        }
        static string[] GetPetsName(string[] allpetsname)
        {
            for (int i = 0; i < allpetsname.Length; i++)
            {
                Console.WriteLine("Введите кличку {0} питомца ", i + 1);
                allpetsname[i] = Console.ReadLine();
            }
            return allpetsname;
        }
        static string[] GetColorsName(string[] colorname)
        {
            for (int i = 0; i < colorname.Length; i++)
            {
                Console.WriteLine("Введите цвет {0} ", i + 1);
                colorname[i] = Console.ReadLine();
            }
            return colorname;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            { 
                corrnumber= 0;
                return true;
            }
        }
        static void ViewResult(string name, string surname, int age, string pets, int color)
        {
            Console.WriteLine(name);
            Console.WriteLine(surname); 
            Console.WriteLine(age);
            Console.WriteLine(pets);
            Console.WriteLine(color);
        }
        static void Main()
        {
            GetUserInfo();
            Console.ReadLine();
        }

    }
}
    
