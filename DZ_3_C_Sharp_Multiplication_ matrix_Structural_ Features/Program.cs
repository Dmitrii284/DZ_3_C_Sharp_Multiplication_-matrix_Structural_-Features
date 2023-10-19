using System.Threading.Tasks;

namespace DZ_3_C_Sharp_Multiplication__matrix_Structural__Features
{
    internal class Program
    {
        public static int num;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Task_2
            Console.WriteLine("Задача 2\nПалидром\nВведите чсло для проверки на палидром-> ");
            num = int.Parse(Console.ReadLine());
            Console.Write(Palindrom.isPalindrom);
            Console.WriteLine();

            //Task_4
            Console.WriteLine("\n\nЗадача 4\n«Веб-сайт»");
            Website website = new Website();
            Console.Write("Введите имя «Веб-сайт» -> ");
            string name = Console.ReadLine();
            website.SetName(name);

            Console.Write("Введите путь «Веб-сайт» -> ");
            string path = Console.ReadLine();
            website.SetPath(path);

            Console.Write("Введите описание «Веб-сайт» -> ");
            string description1 = Console.ReadLine();
            website.SetDescription(description1);

            Console.Write("Введите ip адрес «Веб-сайт» -> ");
            string ipAddress = Console.ReadLine();
            website.SetIpAdress(ipAddress);

            website.Print();

            Console.ReadLine();        

            //Task_5
            Console.WriteLine("\n\nЗадача 5 \n  «Journal»");
            Journal journal = new();
            journal.SetName("Play boy");
            journal.SetDate(DateOnly.Parse("1953-05-10"));
            journal.SetDescription("Хью Марстон Хефнер — американский издатель, основатель и шеф-редактор журнала «Playboy», " +
                                    "а также основатель компании «Playboy Enterprises». Прозвище — Хеф.");
            journal.SetTelNum("+7 (495) 797-45-60 Вася");
            journal.SetE_maill("PB@playboy.com");

            Console.WriteLine($"Название журнала: {journal.GetName()}");
            Console.WriteLine($"Год основания: {journal.DateOnly()}");
            Console.WriteLine($"Описание журнала: {journal.GetDescript()}");
            Console.WriteLine($"Контактный телефон: {journal.GetTelNum()}");
            Console.WriteLine($"Контактный email: {journal.GetE_maill()}");
            Console.WriteLine();

            Journal newJournal = new("Новый журнал0", DateOnly.Parse("2000-01-01"), "Описание нового журнала", "+7 (123) 456-7890666", "newjournal@example1.com");
            Journal newJournal1 = new("Новый журнал1", DateOnly.Parse("2056-01-01"), "Описание нового журнала1", "+7 (123) 456-7890333", "newjournal@example2.com");
            Journal newJournal2 = new("Новый журнал2", DateOnly.Parse("2022-01-01"), "Описание нового журнала2", "+7 (123) 456-7890222", "newjournal@example3.com");
            newJournal.Print();
            Console.WriteLine();
            newJournal1.Print();
            Console.WriteLine();
            newJournal2.Print();            

            ////Task_6
            Console.WriteLine("\n\nЗадача 6 \n «Shop»");
            //Создание объекта класса "Магазин"
            Shop shop = new Shop();

            // Ввод данных о магазине
            shop.InputData();

            // Вывод данных о магазине
            shop.OutputData();

            // Изменение названия магазина
            shop.SetName("Новое название магазина");

            // Вывод измененного названия магазина
            Console.WriteLine("Новое название магазина: " + shop.GetName());
        }

    }
    
}
