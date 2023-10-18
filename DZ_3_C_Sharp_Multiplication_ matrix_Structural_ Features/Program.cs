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
            Console.WriteLine("Задача 2\n«Веб-сайт»");
            Website website = new Website();
            Console.Write("Введите имя «Веб-сайт» -> ");
            string name = Console.ReadLine();
            website.SetName(name);

            Console.Write("Введите путь «Веб-сайт» -> ");
            string path = Console.ReadLine();
            website.SetPath(path);

            Console.Write("Введите описание «Веб-сайт» -> ");
            string description = Console.ReadLine();
            website.SetDescription(description);

            Console.Write("Введите ip адрес «Веб-сайт» -> ");
            string ipAddress = Console.ReadLine();
            website.SetIpAdress(ipAddress);

            website.Print();

            Console.ReadLine();
        }
    }
}
